using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsBehavior : MonoBehaviour
{
    GameObject main;
    QuestionList list;
    // Start is called before the first frame update
    void Start()
    {
        print(gameObject.transform.position.x);
        print(gameObject.transform.position.z);

        main = GameObject.FindGameObjectsWithTag("MainCamera")[0];
        list = main.GetComponent<QuestionList>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        this.gameObject.SetActive(false);
        list.displayQuestion(other.gameObject, this.gameObject);

    }
}
