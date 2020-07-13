using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonster : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject monster;
    public float secondsBetweenSpawn = 5;
    public float elapsedTime = 0.0f; 
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > secondsBetweenSpawn)
        {
            elapsedTime = 0;
            Instantiate(monster, transform);
        }
    }
}
