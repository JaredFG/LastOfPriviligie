using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    public Animator _animator;
    
    [Space]
    [Header("Gun inventory")]
    public string GunSlot1 = "Null";
    public string GunSlot2 = "Null";
    public string GunSlot3 = "Null";
    public string GunSlot4 = "Null";
    public string currentWeapon = "Null";
    public string[] Weapons = {"Pistol","Shotgun","Baston","Llave","Pan","Machete","MiniGun","Rocket","Crossbow","Katana","Extint"};
    public int pistolAmmo;
    public int shotgunAmmo;
    public int minigunAmmo;
    public int rocketAmmo;
    public int crossbowAmmo;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {   
        if(GunSlot1=="Null"&&GunSlot2=="Null"&&GunSlot3=="Null"&&GunSlot4=="Null")
        {
            currentWeapon = "Null";
        }
        if(GunSlot1 != "Null"||GunSlot2 != "Null"||GunSlot3 != "Null"||GunSlot4 != "Null")
        {
            _animator.SetBool("HasGun", true);
            if(GunSlot1 != "Null"&&GunSlot2 == "Null"&&GunSlot3 == "Null"&&GunSlot4 == "Null")
            {
                currentWeapon = GunSlot1;
                //Debug.Log(currentWeapon +"slot1");
                //Debug.Log(GunSlot1);
            }
            if(GunSlot1 == "Null"&&GunSlot2 != "Null"&&GunSlot3 == "Null"&&GunSlot4 == "Null")
            {
                currentWeapon = GunSlot2;
                //Debug.Log(currentWeapon+"slot2");
                //Debug.Log(GunSlot2);
            }
            if(GunSlot1 == "Null"&&GunSlot2 == "Null"&&GunSlot3 != "Null"&&GunSlot4 == "Null")
            {
                currentWeapon = GunSlot3;
                //Debug.Log(currentWeapon+"slot3");
                //Debug.Log(GunSlot3);
            }
            if(GunSlot1 == "Null"&&GunSlot2 == "Null"&&GunSlot3 == "Null"&&GunSlot4 != "Null")
            {
                currentWeapon = GunSlot4;
                //Debug.Log(currentWeapon+"slot4");
                //Debug.Log(GunSlot4);
            }
        }
        else
        {
            _animator.SetBool("HasGun", false);
        }
    }
    void LateUpdate()
	{
        if(!_animator.GetBool("HasGun"))
        {
            foreach(string item in Weapons)
            {
                _animator.SetBool(item,false);
            }
        }
        if(currentWeapon =="Pistol")
        {
            //Debug.Log("tienes pistola");
            foreach(string item in Weapons)
            {
                if(item == "Pistol")
                {
                    _animator.SetBool(item,true);
                }
                else
                {
                    _animator.SetBool(item,false);
                }
            }
        }
        else if(currentWeapon =="Shotgun")
        {
            //Debug.Log("tienes shot");
            foreach(string item in Weapons)
            {
                if(item == "Shotgun")
                {
                    _animator.SetBool(item,true);
                }
                else
                {
                    _animator.SetBool(item,false);
                }
            }
        }
        else if(currentWeapon =="Baston")
        {
            //Debug.Log("tienes baston");
            foreach(string item in Weapons)
            {
                if(item == "Baston")
                {
                    _animator.SetBool(item,true);
                }
                else
                {
                    _animator.SetBool(item,false);
                }
            }
        }
        else if(currentWeapon =="Llave")
        {
            foreach(string item in Weapons)
            {
                //Debug.Log("tienes llave");
                if(item == "Llave")
                {
                    _animator.SetBool(item,true);
                }
                else
                {
                    _animator.SetBool(item,false);
                }
            }
        }
        else if(currentWeapon =="Pan")
        {
            foreach(string item in Weapons)
            {
                //Debug.Log("tienes pan");
                if(item == "Pan")
                {
                    _animator.SetBool(item,true);
                }
                else
                {
                    _animator.SetBool(item,false);
                }
            }
        }
        else if(currentWeapon =="Machete")
        {
            foreach(string item in Weapons)
            {
                //Debug.Log("tienes machete");
                if(item == "Machete")
                {
                    _animator.SetBool(item,true);
                }
                else
                {
                    _animator.SetBool(item,false);
                }
            }
        }
        else if(currentWeapon =="MiniGun")
        {
            foreach(string item in Weapons)
            {
                //Debug.Log("tienes mini");
                if(item == "MiniGun")
                {
                    _animator.SetBool(item,true);
                }
                else
                {
                    _animator.SetBool(item,false);
                }
            }
        }
        else if(currentWeapon =="Rocket")
        {
            //Debug.Log("tienes racket");
            foreach(string item in Weapons)
            {
                if(item == "Rocket")
                {
                    _animator.SetBool(item,true);
                }
                else
                {
                    _animator.SetBool(item,false);
                }
            }
        }
        else if(currentWeapon =="Crossbow")
        {
            foreach(string item in Weapons)
            {
                //Debug.Log("tienes cross");
                if(item == "Crossbow")
                {
                    _animator.SetBool(item,true);
                }
                else
                {
                    _animator.SetBool(item,false);
                }
            }
        }
        else if(currentWeapon =="Katana")
        {
            foreach(string item in Weapons)
            {
                //Debug.Log("tienes kata");
                if(item == "Katana")
                {
                    _animator.SetBool(item,true);
                }
                else
                {
                    _animator.SetBool(item,false);
                }
            }
        }
        else if(currentWeapon =="Extint")
        {
            foreach(string item in Weapons)
            {
                //Debug.Log("tienes extint");
                if(item == "Extint")
                {
                    _animator.SetBool(item,true);
                }
                else
                {
                    _animator.SetBool(item,false);
                }
            }
        }
        else
        {
            _animator.SetBool("HasGun",false);
        }
        
    }
}
