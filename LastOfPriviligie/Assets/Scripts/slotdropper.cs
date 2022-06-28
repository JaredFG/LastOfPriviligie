using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slotdropper : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject box1;
    public GameObject box2;
    public GameObject box3;
    public GameObject box4;
    [Header("Gun inventory")]
    public GameObject pistolPrefab;
    public GameObject shotgunPrefab;
    public GameObject minigunPrefab;
    public GameObject rocketPrefab;
    public GameObject crossbowPrefab;
    public GameObject llavePrefab;
    public GameObject panPrefab;
    public GameObject machetePrefab;
    public GameObject katanaPrefab;
    public GameObject bastonPrefab;
    public inventory inventory;
    public Transform spawnpoint;
    public GameObject player;
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
        
    }
    public void openBox1()
    {
        box1.SetActive(true);
    }
    public void openBox2()
    {
        box2.SetActive(true);
    }
    public void openBox3()
    {
        box3.SetActive(true);
    }
    public void openBox4()
    {
        box4.SetActive(true);
    }
    public void selectSlot1()
    {
        inventory.currentWeapon = inventory.GunSlot1;
        box1.SetActive(false);
    }
    public void selectSlot2()
    {
        inventory.currentWeapon = inventory.GunSlot2;
        box2.SetActive(false);
    }
    public void selectSlot3()
    {
        inventory.currentWeapon = inventory.GunSlot3;
        box3.SetActive(false);
    }
    public void selectSlot4()
    {
        inventory.currentWeapon = inventory.GunSlot4;
        box4.SetActive(false);
    }
    public void dropSlot1()
    {
        if(inventory.GunSlot1 =="Pistol")
        {
            GameObject weapon = Instantiate(pistolPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot1 = "Null";
            box1.SetActive(false);
        }
        else if(inventory.GunSlot1 =="Shotgun")
        {
            GameObject weapon = Instantiate(shotgunPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot1 = "Null";
            box1.SetActive(false);
        }
        else if(inventory.GunSlot1 =="Baston")
        {
            GameObject weapon = Instantiate(bastonPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot1 = "Null";
            box1.SetActive(false);
        }
        else if(inventory.GunSlot1 =="Llave")
        {
            GameObject weapon = Instantiate(llavePrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot1 = "Null";
            box1.SetActive(false);
        }
        else if(inventory.GunSlot1 =="Pan")
        {
            GameObject weapon = Instantiate(bastonPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot1 = "Null";
            box1.SetActive(false);
        }
        else if(inventory.GunSlot1 =="Machete")
        {
            GameObject weapon = Instantiate(machetePrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot1 = "Null";
            box1.SetActive(false);
        }
        else if(inventory.GunSlot1=="MiniGun")
        {
            GameObject weapon = Instantiate(minigunPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot1 = "Null";
            box1.SetActive(false);
        }
        else if(inventory.GunSlot1 =="Rocket")
        {
            GameObject weapon = Instantiate(rocketPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot1 = "Null";
            box1.SetActive(false);
        }
        else if(inventory.GunSlot1 =="Crossbow")
        {
            GameObject weapon = Instantiate(crossbowPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot1 = "Null";
            box1.SetActive(false);
        }
        else if(inventory.GunSlot1 =="Katana")
        {
            GameObject weapon = Instantiate(katanaPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot1 = "Null";
            box1.SetActive(false);
        }
        else
        {
            Debug.Log("no pasa nada");
            box1.SetActive(false);
        }
    }
    public void dropSlot2()
    {
        if(inventory.GunSlot2 =="Pistol")
        {
            GameObject weapon = Instantiate(pistolPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot2 = "Null";
            box2.SetActive(false);
        }
        else if(inventory.GunSlot2 =="Shotgun")
        {
            GameObject weapon = Instantiate(shotgunPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot2 = "Null";
            box2.SetActive(false);
        }
        else if(inventory.GunSlot2 =="Baston")
        {
            GameObject weapon = Instantiate(bastonPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot2 = "Null";
            box2.SetActive(false);
        }
        else if(inventory.GunSlot2 =="Llave")
        {
            GameObject weapon = Instantiate(llavePrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot2 = "Null";
            box2.SetActive(false);
        }
        else if(inventory.GunSlot2 =="Pan")
        {
            GameObject weapon = Instantiate(panPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot2 = "Null";
            box2.SetActive(false);
        }
        else if(inventory.GunSlot2 =="Machete")
        {
            GameObject weapon = Instantiate(machetePrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot2 = "Null";
            box2.SetActive(false);
        }
        else if(inventory.GunSlot2=="MiniGun")
        {
            GameObject weapon = Instantiate(minigunPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot2 = "Null";
            box2.SetActive(false);
        }
        else if(inventory.GunSlot2 =="Rocket")
        {
            GameObject weapon = Instantiate(rocketPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot2 = "Null";
            box2.SetActive(false);
        }
        else if(inventory.GunSlot2 =="Crossbow")
        {
            GameObject weapon = Instantiate(crossbowPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot2 = "Null";
            box2.SetActive(false);
        }
        else if(inventory.GunSlot2 =="Katana")
        {
            GameObject weapon = Instantiate(katanaPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot2 = "Null";
            box2.SetActive(false);
        }
        else
        {
            Debug.Log("no pasa nada 2");
            box2.SetActive(false);
        }
    }
    public void dropSlot3()
    {
        if(inventory.GunSlot3 =="Pistol")
        {
            GameObject weapon = Instantiate(pistolPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot3 = "Null";
            box3.SetActive(false);
        }
        else if(inventory.GunSlot3 =="Shotgun")
        {
            GameObject weapon = Instantiate(shotgunPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot3 = "Null";
            box3.SetActive(false);
        }
        else if(inventory.GunSlot3 =="Baston")
        {
            GameObject weapon = Instantiate(bastonPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot3 = "Null";
            box3.SetActive(false);
        }
        else if(inventory.GunSlot3 =="Llave")
        {
            GameObject weapon = Instantiate(llavePrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot3 = "Null";
            box3.SetActive(false);
        }
        else if(inventory.GunSlot3 =="Pan")
        {
            GameObject weapon = Instantiate(panPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot3 = "Null";
            box3.SetActive(false);
        }
        else if(inventory.GunSlot3 =="Machete")
        {
            GameObject weapon = Instantiate(machetePrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot3 = "Null";
            box3.SetActive(false);
        }
        else if(inventory.GunSlot3=="MiniGun")
        {
            GameObject weapon = Instantiate(minigunPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot3 = "Null";
            box3.SetActive(false);
        }
        else if(inventory.GunSlot3 =="Rocket")
        {
            GameObject weapon = Instantiate(rocketPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot3 = "Null";
            box3.SetActive(false);
        }
        else if(inventory.GunSlot3 =="Crossbow")
        {
            GameObject weapon = Instantiate(crossbowPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot3 = "Null";
            box3.SetActive(false);
        }
        else if(inventory.GunSlot3 =="Katana")
        {
            GameObject weapon = Instantiate(katanaPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot3 = "Null";
            box3.SetActive(false);
        }
        else
        {
            Debug.Log("no pasa nada 3");
            box3.SetActive(false);
        }
    }
    public void dropSlot4()
    {
        if(inventory.GunSlot4 =="Pistol")
        {
            GameObject weapon = Instantiate(pistolPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot4 = "Null";
            box4.SetActive(false);
        }
        else if(inventory.GunSlot4 =="Shotgun")
        {
            GameObject weapon = Instantiate(shotgunPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot4 = "Null";
            box4.SetActive(false);
        }
        else if(inventory.GunSlot4 =="Baston")
        {
            GameObject weapon = Instantiate(bastonPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot4 = "Null";
            box4.SetActive(false);
        }
        else if(inventory.GunSlot4 =="Llave")
        {
            GameObject weapon = Instantiate(llavePrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot4 = "Null";
            box4.SetActive(false);
        }
        else if(inventory.GunSlot4 =="Pan")
        {
            GameObject weapon = Instantiate(panPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot4 = "Null";
            box4.SetActive(false);
        }
        else if(inventory.GunSlot4 =="Machete")
        {
            GameObject weapon = Instantiate(machetePrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot4 = "Null";
            box4.SetActive(false);
        }
        else if(inventory.GunSlot4=="MiniGun")
        {
            GameObject weapon = Instantiate(minigunPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot4 = "Null";
            box4.SetActive(false);
        }
        else if(inventory.GunSlot4 =="Rocket")
        {
            GameObject weapon = Instantiate(rocketPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot4 = "Null";
            box4.SetActive(false);
        }
        else if(inventory.GunSlot4 =="Crossbow")
        {
            GameObject weapon = Instantiate(crossbowPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot4 = "Null";
            box4.SetActive(false);
        }
        else if(inventory.GunSlot4 =="Katana")
        {
            GameObject weapon = Instantiate(katanaPrefab, spawnpoint.position, Quaternion.identity) as GameObject;
            inventory.GunSlot4 = "Null";
            box4.SetActive(false);
        }
        else
        {
            Debug.Log("no pasa nada 4");
            box4.SetActive(false);
        }
    }
}
