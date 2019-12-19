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
        // Open pause menu and freeze time
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenuOpen = true;
            menu.SetActive(true);
            Time.timeScale = 0;
        }

        //Made the cursor visible and unlocking it out of place
        if (pauseMenuOpen)
        { 
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }   
    }

    //Unenable pause menu and unfreeze time
    public void Resume() 
    {
        menu.SetActive(false);
        contorllerMenu.SetActive(false);
        pauseMenuOpen = false;
        Time.timeScale = 1;
    }

    //Take player out of playmode
    public void Quit() 
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    //Enable pause menu
    public void PauseMenu() 
    {
        menu.SetActive(true);
    }

    //Enable pause menu and unenable controller menu
    public void Controls()
    {
        menu.SetActive(false);
        contorllerMenu.SetActive(true);
    }

    //Unenable pause menu and enable controller menu
    public void ReturnToPauseMenu() 
    {
        menu.SetActive(true);
        contorllerMenu.SetActive(false);
    }
}
