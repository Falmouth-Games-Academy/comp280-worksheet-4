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


        if (Physics.Raycast(ray, out hit)) 
        {
            if (hit.transform.name.Contains("Enemy"))
            {
                image.color = new Color(1, 0, 0, 1);

                if (Input.GetMouseButtonDown(0)) 
                {
                    hit.transform.GetComponent<Enemy>().KillEnemy();
                }
            }
        }
        else
            image.color = new Color(1, 1, 1, 1);
    }
}
