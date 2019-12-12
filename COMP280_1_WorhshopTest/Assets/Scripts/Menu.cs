using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    [SerializeField]
    GameObject menu;
    [SerializeField]
    GameObject contorllerMenu;
    [SerializeField]
    GameObject Player;

    bool pauseMenuOpen;

    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
        contorllerMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenuOpen = true;
            menu.SetActive(true);
        }

        if (pauseMenuOpen)
        { 
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Player.transform.eulerAngles = Vector3.zero;
        }   
    }

    public void Resume() 
    {
        menu.SetActive(false);
        contorllerMenu.SetActive(false);
        pauseMenuOpen = false;
    }

    public void Quit() 
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void PauseMenu() 
    {
        menu.SetActive(true);
    }

    public void Controls()
    {
        menu.SetActive(false);
        contorllerMenu.SetActive(true);
    }

    public void ReturnToPauseMenu() 
    {
        menu.SetActive(true);
        contorllerMenu.SetActive(false);
    }
}
