using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SlotInventory : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite pistolSprite;
    public Sprite shotgunSprite;
    public Sprite minigunSprite;
    public Sprite crossbowSprite;

    public Sprite rocketSprite;
    public Sprite bastonSprite;
    public Sprite llaveSprite;
    public Sprite panSprite;
    public Sprite macheteSprite;
    public Sprite katanaSprite;
    public Sprite none;
    public Button slot1Image;
    public Button slot2Image;
    public Button slot3Image;
    public Button slot4Image;
    public Text slot1Text;
    public Text slot2Text;
    public Text slot3Text;
    public Text slot4Text;
    public inventory inventory;
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
        checkSlot1();
        checkSlot2();
        checkSlot3();
        checkSlot4();
    }
    public void checkSlot1()
    {
        if(inventory.GunSlot1 =="Pistol")
        {
            
            slot1Image.image.sprite = pistolSprite;
            slot1Text.text = inventory.pistolAmmo.ToString();
        }
        else if(inventory.GunSlot1 =="Shotgun")
        {
            slot1Image.image.sprite = shotgunSprite;
            slot1Text.text = inventory.shotgunAmmo.ToString();
        }
        else if(inventory.GunSlot1 =="Baston")
        {
            slot1Image.image.sprite = bastonSprite;
            slot1Text.text = "";
        }
        else if(inventory.GunSlot1 =="Llave")
        {
            slot1Image.image.sprite = llaveSprite;
            slot1Text.text ="";
        }
        else if(inventory.GunSlot1 =="Pan")
        {
            slot1Image.image.sprite = panSprite;
            slot1Text.text = "";
        }
        else if(inventory.GunSlot1 =="Machete")
        {
            slot1Image.image.sprite = macheteSprite;
            slot1Text.text = "";
        }
        else if(inventory.GunSlot1=="MiniGun")
        {
            slot1Image.image.sprite = minigunSprite;
            slot1Text.text = inventory.minigunAmmo.ToString();
        }
        else if(inventory.GunSlot1 =="Rocket")
        {
            slot1Image.image.sprite = rocketSprite;
            slot1Text.text = inventory.rocketAmmo.ToString();
        }
        else if(inventory.GunSlot1 =="Crossbow")
        {
            slot1Image.image.sprite = crossbowSprite;
            slot1Text.text = inventory.crossbowAmmo.ToString();
        }
        else if(inventory.GunSlot1 =="Katana")
        {
            slot1Image.image.sprite = katanaSprite;
            slot1Text.text ="";
        }
        else
        {
            slot1Image.image.sprite = none;
            slot1Text.text ="";
        }
    }
    public void checkSlot2()
    {
        if(inventory.GunSlot2 =="Pistol")
        {
            
            slot2Image.image.sprite = pistolSprite;
            slot2Text.text = inventory.pistolAmmo.ToString();
        }
        else if(inventory.GunSlot2 =="Shotgun")
        {
            slot2Image.image.sprite = shotgunSprite;
            slot2Text.text = inventory.shotgunAmmo.ToString();
        }
        else if(inventory.GunSlot2 =="Baston")
        {
            slot2Image.image.sprite = bastonSprite;
            slot2Text.text = "";
        }
        else if(inventory.GunSlot2 =="Llave")
        {
            slot2Image.image.sprite = llaveSprite;
            slot2Text.text ="";
        }
        else if(inventory.GunSlot2 =="Pan")
        {
            slot2Image.image.sprite = panSprite;
            slot2Text.text = "";
        }
        else if(inventory.GunSlot2 =="Machete")
        {
            slot2Image.image.sprite = macheteSprite;
            slot2Text.text = "";
        }
        else if(inventory.GunSlot2=="MiniGun")
        {
            slot2Image.image.sprite = minigunSprite;
            slot2Text.text = inventory.minigunAmmo.ToString();
        }
        else if(inventory.GunSlot2 =="Rocket")
        {
            slot2Image.image.sprite = rocketSprite;
            slot2Text.text = inventory.rocketAmmo.ToString();
        }
        else if(inventory.GunSlot2 =="Crossbow")
        {
            slot2Image.image.sprite = crossbowSprite;
            slot2Text.text = inventory.crossbowAmmo.ToString();
        }
        else if(inventory.GunSlot2 =="Katana")
        {
            slot2Image.image.sprite = katanaSprite;
            slot2Text.text ="";
        }
        else
        {
            slot2Image.image.sprite = none;
            slot2Text.text ="";
        }
    }
    public void checkSlot3()
    {
        if(inventory.GunSlot3 =="Pistol")
        {
            
            slot3Image.image.sprite = pistolSprite;
            slot3Text.text = inventory.pistolAmmo.ToString();
        }
        else if(inventory.GunSlot3 =="Shotgun")
        {
            slot3Image.image.sprite = shotgunSprite;
            slot3Text.text = inventory.shotgunAmmo.ToString();
        }
        else if(inventory.GunSlot3 =="Baston")
        {
            slot3Image.image.sprite = bastonSprite;
            slot3Text.text = "";
        }
        else if(inventory.GunSlot3 =="Llave")
        {
            slot3Image.image.sprite = llaveSprite;
            slot3Text.text ="";
        }
        else if(inventory.GunSlot3 =="Pan")
        {
            slot3Image.image.sprite = panSprite;
            slot3Text.text = "";
        }
        else if(inventory.GunSlot3 =="Machete")
        {
            slot3Image.image.sprite = macheteSprite;
            slot3Text.text = "";
        }
        else if(inventory.GunSlot3=="MiniGun")
        {
            slot3Image.image.sprite = minigunSprite;
            slot3Text.text = inventory.minigunAmmo.ToString();
        }
        else if(inventory.GunSlot3 =="Rocket")
        {
            slot3Image.image.sprite = rocketSprite;
            slot3Text.text = inventory.rocketAmmo.ToString();
        }
        else if(inventory.GunSlot3 =="Crossbow")
        {
            slot3Image.image.sprite = crossbowSprite;
            slot3Text.text = inventory.crossbowAmmo.ToString();
        }
        else if(inventory.GunSlot3 =="Katana")
        {
            slot3Image.image.sprite = katanaSprite;
            slot3Text.text ="";
        }
        else
        {
            slot3Image.image.sprite = none;
            slot3Text.text ="";
        }
    }
    public void checkSlot4()
    {
        if(inventory.GunSlot4 =="Pistol")
        {
            
            slot4Image.image.sprite = pistolSprite;
            slot4Text.text = inventory.pistolAmmo.ToString();
        }
        else if(inventory.GunSlot4 =="Shotgun")
        {
            slot4Image.image.sprite = shotgunSprite;
            slot4Text.text = inventory.shotgunAmmo.ToString();
        }
        else if(inventory.GunSlot4 =="Baston")
        {
            slot4Image.image.sprite = bastonSprite;
            slot4Text.text = "";
        }
        else if(inventory.GunSlot4 =="Llave")
        {
            slot4Image.image.sprite = llaveSprite;
            slot4Text.text ="";
        }
        else if(inventory.GunSlot4 =="Pan")
        {
            slot4Image.image.sprite = panSprite;
            slot4Text.text = "";
        }
        else if(inventory.GunSlot4 =="Machete")
        {
            slot4Image.image.sprite = macheteSprite;
            slot4Text.text = "";
        }
        else if(inventory.GunSlot4=="MiniGun")
        {
            slot4Image.image.sprite = minigunSprite;
            slot4Text.text = inventory.minigunAmmo.ToString();
        }
        else if(inventory.GunSlot4 =="Rocket")
        {
            slot4Image.image.sprite = rocketSprite;
            slot4Text.text = inventory.rocketAmmo.ToString();
        }
        else if(inventory.GunSlot4 =="Crossbow")
        {
            slot4Image.image.sprite = crossbowSprite;
            slot4Text.text = inventory.crossbowAmmo.ToString();
        }
        else if(inventory.GunSlot4 =="Katana")
        {
            slot4Image.image.sprite = katanaSprite;
            slot4Text.text ="";
        }
        else
        {
            slot4Image.image.sprite = none;
            slot4Text.text ="";
        }
    }
}
