using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public delegate void Notify();

public class RingTrigger : MonoBehaviour
{

    public event Notify GhostEntered; // event

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter(Collider other){
        Debug.Log(other.transform.parent.gameObject.name + " triggers.");
        print(other.gameObject);

        if (other.gameObject.transform.parent.CompareTag("sheep"))
        {
            GhostSheepBehavior script = other.transform.parent.GetComponent <GhostSheepBehavior>();
        

            if (!script.isGhost)
            {
                OnGhostEntered();

            }
        }
    }

    protected virtual void OnGhostEntered() //protected virtual method
    {
        //if ProcessCompleted is not null then call delegate
        GhostEntered?.Invoke();
    }
}
