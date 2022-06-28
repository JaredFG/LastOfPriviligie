using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickup : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject Weapon;
    
    public GameObject player;
    public inventory inventory;
    public weapon weapon;
    public PlayerController playerController;
    void Start()
    {
        
        inventory= player.GetComponent<inventory>();
        playerController = player.GetComponent<PlayerController>();

    }
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            Debug.Log("Te detecte");
            if(inventory.GunSlot1 =="Null")
            {
                inventory.GunSlot1= weapon.GunName;
                Destroy(this.gameObject);
            }
            else if(inventory.GunSlot2 =="Null")
            {
                inventory.GunSlot2= weapon.GunName;
                Destroy(this.gameObject);
            }
            else if(inventory.GunSlot3 =="Null")
            {
                inventory.GunSlot3= weapon.GunName;
                Destroy(this.gameObject);
            }
            else if(inventory.GunSlot4 =="Null")
            {
                inventory.GunSlot4= weapon.GunName;
                Destroy(this.gameObject);
            }
            else
            {
                Debug.Log("tienes el inventario lleno");
            }
            
        }
    }
}
