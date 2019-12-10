using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintBox : MonoBehaviour
{
    [Header("Hint Box UI")]
    [SerializeField]
    GameObject hintBox;
    [SerializeField]
    float delay;
    

    // Start is called before the first frame update
    void Start()
    {
        hintBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
            StartCoroutine("ShowHint");
    }

    IEnumerator ShowHint() 
    {
        hintBox.SetActive(true);
        yield return new WaitForSeconds(delay);
        hintBox.SetActive(false);
    }
}
