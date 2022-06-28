using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Menu : MonoBehaviour
{
    public PlayableDirector director;
    private Renderer rend;
    // Start is called before the first frame update
    public string textoADecir;
    [SerializeField]
    private Color colorToTurnTo = Color.white;
    [SerializeField]
    private Color colorBack = Color.white;
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
        Debug.Log(textoADecir);
        StartCoroutine("changeColor");
        StartCoroutine("starDirector");
        
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
        yield return new  WaitForSeconds(1);
    }
}
