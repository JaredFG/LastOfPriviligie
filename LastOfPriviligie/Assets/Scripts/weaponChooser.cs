using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class weaponChooser : MonoBehaviour
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
    public inventory inventory;
    public Text currentweaponText;
    public Image image;
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
        
        
        //if (!(image = gameObject.GetComponent<Image>()))
           // Debug.Log("I have no Image component! Fix meeeeeeeeeeeee");
        //Debug.Log(inventory.currentWeapon);
        if(inventory.currentWeapon =="Pistol")
        {
            
            image.sprite = pistolSprite;
            currentweaponText.text = inventory.pistolAmmo.ToString();
        }
        else if(inventory.currentWeapon =="Shotgun")
        {
            image.sprite = shotgunSprite;
            currentweaponText.text = inventory.shotgunAmmo.ToString();
        }
        else if(inventory.currentWeapon =="Baston")
        {
            image.sprite = bastonSprite;
            currentweaponText.text = "";
        }
        else if(inventory.currentWeapon =="Llave")
        {
            image.sprite = llaveSprite;
            currentweaponText.text ="";
        }
        else if(inventory.currentWeapon =="Pan")
        {
            image.sprite = panSprite;
            currentweaponText.text = "";
        }
        else if(inventory.currentWeapon =="Machete")
        {
            image.sprite = macheteSprite;
            currentweaponText.text = "";
        }
        else if(inventory.currentWeapon =="MiniGun")
        {
            image.sprite = minigunSprite;
            currentweaponText.text = inventory.minigunAmmo.ToString();
        }
        else if(inventory.currentWeapon =="Rocket")
        {
            image.sprite = rocketSprite;
            currentweaponText.text = inventory.rocketAmmo.ToString();
        }
        else if(inventory.currentWeapon =="Crossbow")
        {
            image.sprite = crossbowSprite;
            currentweaponText.text = inventory.crossbowAmmo.ToString();
        }
        else if(inventory.currentWeapon =="Katana")
        {
            image.sprite = katanaSprite;
            currentweaponText.text ="";
        }
        else
        {
            image.sprite = none;
            currentweaponText.text ="";
        }
        
    }
    }

