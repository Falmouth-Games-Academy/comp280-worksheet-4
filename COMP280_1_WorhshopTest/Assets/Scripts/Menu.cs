using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    [SerializeField]
    GameObject menu;

    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
            menu.SetActive(true);
    }

    public void Resume() 
    {
        menu.SetActive(false);
    }

    public void Quit() 
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
