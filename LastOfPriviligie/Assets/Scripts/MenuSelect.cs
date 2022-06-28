using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class MenuSelect : MonoBehaviour
{
    public PlayableDirector director;
    private Renderer rend;
    // Start is called before the first frame update

    [SerializeField]
    private Color colorToTurnTo = Color.white;
    [SerializeField]
    private Color colorBack = Color.white;
    public string level;
    public bool exit =true;
    public bool notDone;
    public GameObject advice;
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        if(exit)
        {
            StartCoroutine("changeColor");
            StartCoroutine("starDirectorExit");
            
        }
        
        else if(notDone)
        {
            StartCoroutine("notDoneYet");
        }
        else 
        {
        StartCoroutine("changeColor");
        StartCoroutine("starDirector");
        
        }
        
        
    }
    IEnumerator changeColor()
    {
        rend.material.color = colorToTurnTo;
        yield return new WaitForSeconds(1);
        rend.material.color = colorBack;
    }
    IEnumerator starDirector()
    {
        director.Play();
        yield return new  WaitForSeconds(5);
        SceneManager.LoadScene(level);
    }
    IEnumerator starDirectorExit()
    {
        director.Play();
        yield return new  WaitForSeconds(5);
        Application.Quit();
    }
    IEnumerator notDoneYet()
    {
        advice.SetActive(true);
        yield return new WaitForSeconds(3);
        advice.SetActive(false);
    }
}
