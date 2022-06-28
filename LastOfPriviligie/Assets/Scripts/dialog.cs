using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialog : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject otherSprite;
    
    public bool first = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        otherSprite.SetActive(true);
        this.gameObject.SetActive(false);
        
        
        
    }
}
