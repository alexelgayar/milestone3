using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionObjects : MonoBehaviour
{
    public GameObject[] objects;
    public bool oneSpawned;
    // Start is called before the first frame update
    void Start()
    {
        int i = Random.Range(3, 8);
        Invoke("SpawnOne", i);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnOne()
    {
        int i = Random.Range(0, objects.Length - 1);
        objects[i].SetActive(true);
        oneSpawned = true;
    }
}
