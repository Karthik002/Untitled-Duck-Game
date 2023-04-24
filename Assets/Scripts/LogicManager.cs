using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicManager : MonoBehaviour
{
    public GameObject duck;
    public float timer = 0f;
    public float spawnRate = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnDuck();
            timer = 0f;
        }
    }

    void SpawnDuck()
    {
        Instantiate(duck, new Vector3(Random.Range(-3f, 3f), 1f, Random.Range(-3f, 3f)));
    }
    
}
