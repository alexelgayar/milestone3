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

        main = GameObject.FindGameObjectsWithTag("MainCamera")[0];
        list = main.GetComponent<QuestionList>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        list.displayQuestion(other.gameObject, this.gameObject);

        this.gameObject.SetActive(false);

    }
}
