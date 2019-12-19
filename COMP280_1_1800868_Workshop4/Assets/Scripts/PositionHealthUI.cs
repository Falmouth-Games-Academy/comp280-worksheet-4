using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionHealthUI : MonoBehaviour
{
    [SerializeField]
    Camera cam;
    [SerializeField]
    Transform watch;

    Vector2 UIPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UIPos = cam.WorldToScreenPoint(watch.position);
        transform.position = UIPos;
    }
}
