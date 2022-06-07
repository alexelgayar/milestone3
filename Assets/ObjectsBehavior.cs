using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsBehavior : MonoBehaviour
{
    GameObject main;
    QuestionList behavior;
    // Start is called before the first frame update
    void Start()
    {
        main = GameObject.FindGameObjectsWithTag("MainCamera")[0];
        behavior = main.GetComponent<QuestionList>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject main = GameObject.FindGameObjectsWithTag("MainCamera")[0];
        QuestionList list = main.GetComponent<QuestionList>();
        this.gameObject.SetActive(false);
        list.displayQuestion(other.gameObject, this.gameObject);

    }
}
