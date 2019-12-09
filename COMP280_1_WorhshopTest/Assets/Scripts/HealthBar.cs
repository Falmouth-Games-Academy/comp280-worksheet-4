using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    Image bar;
    [SerializeField]
    float damage;

    float health = 100;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Damage", 2.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Damage() 
    {
        health -= damage;
        bar.fillAmount = (health / 100);
    }
}
