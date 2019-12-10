using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintBox : MonoBehaviour
{
    [Header("Hint Box UI")]
    [SerializeField]
    GameObject hintBox;
    [SerializeField]
    Vector2 moveToPosition;
    [SerializeField]
    float moveSpeed;
    [SerializeField]
    float delay;
    
    

    Vector2 startPos;
    

    // Start is called before the first frame update
    void Start()
    {
        startPos = hintBox.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("ShowHint");

    }

    IEnumerator ShowHint() 
    {
        hintBox.transform.position = Vector2.Lerp(startPos, moveToPosition, moveSpeed * Time.deltaTime);
        yield return new WaitForSeconds(delay);
        hintBox.transform.position = Vector2.Lerp(moveToPosition, startPos, moveSpeed * Time.deltaTime);
    }
}
