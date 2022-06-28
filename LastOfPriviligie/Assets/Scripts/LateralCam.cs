using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * control de camara con bordes
 * Autor: Jared Abraham Flores Guarneros
*/
public class LateralCam : MonoBehaviour
{

    private Transform playerTransform;
    public float leftlimit;
    public float rightlimit;
    public float toplimit;
    public float bottomlimit;
    // Start is called before the first frame update
    void Start()
    {
        //se obtiene el transform de el jugador
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        

    }
    

    // Update is called once per frame
    void LateUpdate()
    {
        
        //se actualiza la posicion de la  camara entre los valores maximos
        Vector3 temp = transform.position;
        temp.x = playerTransform.position.x;
        temp.y = playerTransform.position.y;

        transform.position = temp;

        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, leftlimit, rightlimit),
            Mathf.Clamp(transform.position.y, bottomlimit, toplimit),
            transform.position.z);

    }
    
}
