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
        SpawnLater();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnOne()
    {
        int i = Random.Range(0, objects.Length - 1);
        float x = Random.Range(-16, 16);
        float z = Random.Range(-7.5f, 7.7f);
        objects[i].transform.Translate(x, 0 ,z);
        objects[i].SetActive(true);
        oneSpawned = true;
    }

    public void SpawnLater()
    {
        int i = Random.Range(3, 8);
        Invoke("SpawnOne", i);

    }
}
