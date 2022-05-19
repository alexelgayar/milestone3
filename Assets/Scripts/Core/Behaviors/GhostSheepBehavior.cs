using System.Linq;
using UnityEngine;

public class GhostSheepBehavior : AgentBehaviour
{

    public bool isGhost;
    CelluloAgentRigidBody script;
    RingTrigger rt;
    bool colliding;
    AudioSource audioS;
    public AudioClip ghost;
    public AudioClip winPoint;
    public AudioClip losePoint;
    public AudioClip sheep;





    public void Start(){

        gameObject.tag = "sheep";

        isGhost = false;


        if (rt == null) {
            rt = GameObject.FindObjectOfType<RingTrigger>();
        }

        rt.GhostEntered += GhostEntered;


        script = GetComponent<CelluloAgentRigidBody>();


        audioS = GetComponent<AudioSource>();


        
        float rand = Random.Range(25, 30);

        Invoke("invokeLoop", rand);

    }
    
    public override Steering GetSteering()
    {

        
        Steering steering = new Steering();
        

        if (isGhost)
        {
            agent.SetVisualEffect(0, Color.yellow, 255);


            GameObject closest = findClosestDog();
            if (colliding)
            {
                steering.linear = Vector3.zero;
            }
            else
            {
                Vector3 to = closest.transform.position - transform.position;
                steering.linear = to * agent.maxAccel;
            }

        }
        else
        {

            script.SetVisualEffect(0, Color.green, 255);

            GameObject[] dogs;
            dogs = GameObject.FindGameObjectsWithTag("dog");
            steering.linear = Vector3.zero;
            
            foreach(GameObject dog in dogs){
                Vector3 vec = (transform.position - dog.transform.position);
                if (vec.magnitude < 4) { 

                    steering.linear += vec * (1/ vec.magnitude);
                   
                }
            }
            steering.linear = steering.linear * agent.maxAccel;

        }


        steering.linear = this.transform.parent.TransformDirection(Vector3.ClampMagnitude(steering.linear, agent.maxAccel));
        

        return steering;
    }

    public GameObject findClosestDog()
    {
        GameObject[] dogs;
        dogs = GameObject.FindGameObjectsWithTag("dog");
        GameObject closest = null;
        float dist = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach(GameObject go in dogs)
        {
            Vector3 diff = go.transform.position - position;
            float curDist = diff.sqrMagnitude;
            if(curDist < dist)
            {
                closest = go;
                dist = curDist;
            }
        }
        return closest;
    }

    public void invokeLoop()
    {
        float rand = Random.Range(25, 30);

        if (isGhost)
        {
            audioS.clip = sheep;
            audioS.Play();
            isGhost = false;
        }
        else
        {
            audioS.clip = ghost;
            audioS.Play();

            isGhost = true;
        }

        Invoke("invokeLoop", rand);
    }

    public void GhostEntered()
    {
        GameObject closest = findClosestDog();
        Score scr = closest.GetComponent<Score>();
        scr.score += 1;
        audioS.clip = winPoint;
        audioS.Play();
    }

    private void OnCollisionEnter(Collision collision)

    {
        
        if (isGhost)
        {
            if (collision.gameObject.tag == "dog")
            {
                colliding = true;
                GameObject coll = collision.gameObject;
                Score scr = coll.GetComponent<Score>();
                audioS.clip = losePoint;
                audioS.Play();
                scr.score -= 1;

            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {

        if (isGhost)
        {
            if (collision.gameObject.tag == "dog")
            {
                colliding = false;
            }
        }

    }


}
