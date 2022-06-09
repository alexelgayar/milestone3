using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionObjects : MonoBehaviour
{
    public GameObject[] objects;
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
        Vector3 pos = new Vector3(Random.Range(2f, 26f), 0, Random.Range(-18f, -1f));
        objects[i].transform.position = pos;
        objects[i].SetActive(true);
    }

    public void SpawnLater()
    {
        int i = Random.Range(3, 8);
        Invoke("SpawnOne", i);

    }
}
