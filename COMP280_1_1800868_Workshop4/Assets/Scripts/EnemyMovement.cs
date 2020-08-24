using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    float radius;
    [SerializeField]
    Transform radar;
    [SerializeField]
    GameObject[] enemys;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RandomPos", 2.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RandomPos() 
    {
        //Set random positions for each of the enemies in the array
        foreach (GameObject enemy in enemys) 
        {
            enemy.transform.position = new Vector2(enemy.transform.position.x, enemy.transform.position.y) + new Vector2(Random.Range(-radius, radius), Random.Range(-radius, radius));
        }
    }
}
