using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ammocounter : MonoBehaviour
{
    // Start is called before the first frame update
    public Text textpistol;
    public Text textshotgun;
    public Text textminigun;
    public Text textcrossbow;
    public Text textrocket;
    public GameObject player;
    
    
    public inventory inventory;
    void Start()
    {
        inventory= player.GetComponent<inventory>();
        
    }
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(inventory.crossbowAmmo);
        textpistol.text = inventory.pistolAmmo.ToString();
        textshotgun.text = inventory.shotgunAmmo.ToString();
        textminigun.text = inventory.minigunAmmo.ToString();
        textcrossbow.text = inventory.crossbowAmmo.ToString();
        textrocket.text = inventory.rocketAmmo.ToString();
    }
}
