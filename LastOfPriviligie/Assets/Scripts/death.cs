using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Color colorToTurnTo = Color.white;
    [SerializeField]
    private Color colorBack = Color.white;
    private Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("bullet"))
        {
            StartCoroutine("changeColor");
            Destroy(col.gameObject);
        }
    }
    IEnumerator changeColor()
    {
        rend.material.color = colorToTurnTo;
        yield return new WaitForSeconds(0.5f);
        rend.material.color = colorBack;
    }
}
