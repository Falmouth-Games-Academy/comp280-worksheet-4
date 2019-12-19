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
    [SerializeField]
    GameObject lowHealthText;

    float health = 100;

    // Start is called before the first frame update
    void Start()
    {
        lowHealthText.SetActive(false);
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

        if (health <= 20)
            lowHealthText.SetActive(true);
    }
}
