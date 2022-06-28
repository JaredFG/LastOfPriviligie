using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showinventory : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool InventoryShowed = false;
    public GameObject InventoryUI;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            if (InventoryShowed)
            {
                NoShowI();
            }
            else{
                ShowI();
            }
        }
    }
    public void NoShowI()
        {
            //la ventana de pausa se desactiva
            InventoryUI.SetActive(false);
            Time.timeScale=1f;
            InventoryShowed = false;


        }
        public void ShowI(){
            //la ventana de pausa se activa
            InventoryUI.SetActive(true);
            Time.timeScale=0f;
            InventoryShowed = true;

        }
}
