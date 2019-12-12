using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crosshair : MonoBehaviour
{
    [SerializeField]
    Image image;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        //If hit object run code below else set crosshair colour to white
        if (Physics.Raycast(ray, out hit)) 
        {
            //If raycast hits an enemy chanse crosshair colour to red else change it back to white
            if (hit.transform.name.Contains("Enemy"))
            {
                image.color = new Color(1, 0, 0, 1);

                //Left click to destroy the enemy
                if (Input.GetMouseButtonDown(0)) 
                {
                    hit.transform.GetComponent<Enemy>().KillEnemy();
                }
            }
            else
                image.color = new Color(1, 1, 1, 1);
        }
        else
            image.color = new Color(1, 1, 1, 1);
    }
}
