using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PAUSE : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GamePaused = false;
    public GameObject pauseMenuUI;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
            {
                Resume();
            }
            else{
                Pause();
            }
        }
    }
    public void Resume()
        {
            //la ventana de pausa se desactiva
            pauseMenuUI.SetActive(false);
            Time.timeScale=1f;
            GamePaused = false;


        }
        public void Pause(){
            //la ventana de pausa se activa
            pauseMenuUI.SetActive(true);
            Time.timeScale=0f;
            GamePaused = true;

        }
        public void LoadMenu()
        {
            //se carga el menu de regreso
            Time.timeScale=1f;
            SceneManager.LoadScene( "MainMenu");

        }
        public void check()
        {
            Debug.Log("si sirve");
        }
}
