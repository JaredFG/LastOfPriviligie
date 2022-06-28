using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject shooter;
    [Header("Bullets")]
    public GameObject pistolBulletPrefab;
    public GameObject shotgunBulletPrefab;
    public GameObject minigunBulletPrefab;
    public GameObject rocketBulletPrefab;
    public GameObject crossbowBulletPrefab;
    [Header("Weapons Hurtboxes-shootpoint")]
    public Transform pistolShootpoint;
    public Transform shotgunShootpoint;
    public Transform minigunShootpoint;
    public Transform rocketShootpoint;
    public Transform crossbowShootpoint;
    public GameObject bastonHurtbox;
    public GameObject llaveHurtbox;
    public GameObject panHurtbox;
    public GameObject macheteHurtbox;
    public GameObject extintHurtbox;
    public GameObject katanaHurtbox;
    public inventory inventory;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Shootpistol()
    { 
      if(inventory.pistolAmmo != 0)
      {
        GameObject myBullet = Instantiate(pistolBulletPrefab, pistolShootpoint.position, Quaternion.identity) as GameObject;
        Bullet bulletComponent = myBullet.GetComponent<Bullet>();
        if (shooter.transform.localScale.x < 0f) {
				// Left
				bulletComponent.direction = Vector2.left; // new Vector2(-1f, 0f)
			} else {
				// Right
				bulletComponent.direction = Vector2.right; // new Vector2(1f, 0f)
			}
      inventory.pistolAmmo -= 1;
      }
        
    }
    public void Shootshotgun()
    {
      if(inventory.shotgunAmmo!=0)
      {
        GameObject myBullet = Instantiate(shotgunBulletPrefab, shotgunShootpoint.position, Quaternion.identity) as GameObject;
        Bullet bulletComponent = myBullet.GetComponent<Bullet>();
        if (shooter.transform.localScale.x < 0f) {
				// Left
				bulletComponent.direction = Vector2.left; // new Vector2(-1f, 0f)
			} else {
				// Right
				bulletComponent.direction = Vector2.right; // new Vector2(1f, 0f)
			}
      inventory.shotgunAmmo-=1;
      }
        
    }
    public void Shootminigun()
    {
      if(inventory.minigunAmmo !=0)
      {
        GameObject myBullet = Instantiate(minigunBulletPrefab, minigunShootpoint.position, Quaternion.identity) as GameObject;
        Bullet bulletComponent = myBullet.GetComponent<Bullet>();
        if (shooter.transform.localScale.x < 0f) {
				// Left
				bulletComponent.direction = Vector2.left; // new Vector2(-1f, 0f)
			} else {
				// Right
				bulletComponent.direction = Vector2.right; // new Vector2(1f, 0f)
			}
      inventory.minigunAmmo -=1;
      }
        
    }
    public void Shootrocket()
    {
      if(inventory.minigunAmmo !=0)
      {
        GameObject myBullet = Instantiate(rocketBulletPrefab, rocketShootpoint.position, Quaternion.identity) as GameObject;
        Bullet bulletComponent = myBullet.GetComponent<Bullet>();
        if (shooter.transform.localScale.x < 0f) {
				// Left
				bulletComponent.direction = Vector2.left; // new Vector2(-1f, 0f)
			} else {
				// Right
				bulletComponent.direction = Vector2.right; // new Vector2(1f, 0f)
			}
      inventory.minigunAmmo-=1;
      }
        
    }
    public void Shootcrossbow()
    {
      if(inventory.crossbowAmmo!=0)
      {
        GameObject myBullet = Instantiate(crossbowBulletPrefab, crossbowShootpoint.position, Quaternion.identity) as GameObject;
        Bullet bulletComponent = myBullet.GetComponent<Bullet>();
        if (shooter.transform.localScale.x < 0f) {
				// Left
				bulletComponent.direction = Vector2.left; // new Vector2(-1f, 0f)
			} else {
				// Right
				bulletComponent.direction = Vector2.right; // new Vector2(1f, 0f)
			}
      inventory.crossbowAmmo-=1;
      }
        
    }
    public void PVPbaston()
    {
      StartCoroutine("attackbaston");
    }
    public void PVPllave()
    {
      StartCoroutine("attackllave");
    }
    public void PVPpan()
    {
      StartCoroutine("attackpan");
    }
    public void PVPmachete()
    {
      StartCoroutine("attackmachete");
    }
    public void PVPkatana()
    {
      StartCoroutine("attackkatana");
    }
    IEnumerator attackbaston()
    {
      bastonHurtbox.SetActive(true);
      yield return new WaitForSeconds(0.5f);
      bastonHurtbox.SetActive(false);
    }
    IEnumerator attackllave()
    {
      llaveHurtbox.SetActive(true);
      yield return new WaitForSeconds(0.5f);
      llaveHurtbox.SetActive(false);
    }
    IEnumerator attackpan()
    {
      panHurtbox.SetActive(true);
      yield return new WaitForSeconds(0.5f);
      panHurtbox.SetActive(false);
    }
    IEnumerator attackmachete()
    {
      macheteHurtbox.SetActive(true);
      yield return new WaitForSeconds(0.5f);
      macheteHurtbox.SetActive(false);
    }
    IEnumerator attackkatana()
    {
      katanaHurtbox.SetActive(true);
      yield return new WaitForSeconds(0.5f);
      katanaHurtbox.SetActive(false);
    }
}
