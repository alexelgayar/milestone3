using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemBehavior : MonoBehaviour
{
    public GameObject gem;
    bool canSteal;
    AudioSource audioS;
    public AudioClip gemAppear;
    public AudioClip gemCollected;
    public AudioClip stealPoints;
    public bool startMe;

    // Start is called before the first frame update
    void Start()
    {
        canSteal = false;
        audioS = GetComponent<AudioSource>();
        print(gameObject.name);

        if (startMe)
        {
            float rand = Random.Range(15, 20);
            Invoke("showGem", rand);
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("gem"))
        {
            
            gem.gameObject.SetActive(false);
            canSteal = true;
            audioS.clip = gemCollected;
            audioS.Play();
            float rand = Random.Range(15, 20);
            Invoke("showGem", rand);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("dog"))
        {
            if (canSteal)
            {
                Score stealerScore = GetComponent<Score>();
                Score otherScore = collision.gameObject.GetComponent<Score>();
                stealerScore.score += 2;
                otherScore.score -= 2;
                audioS.clip = stealPoints;
                audioS.Play();
                canSteal = false;

            }
        }
    }

    void showGem()
    {
        canSteal = false;
        Vector3 newPos = new Vector3(Random.Range(0, 15), 0.86f, Random.Range(-9, 0));
        gem.transform.position = newPos;
        gem.SetActive(true);
        audioS.clip = gemAppear;
        audioS.Play();
    }
}
