using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
     public float direction = 1f; // initial direction
    public float speed = 20f; // speed of rotation

    void Update ()
    {
        float angle = transform.eulerAngles.z;
        if (angle > 180f) angle -= 360f;

        if ((angle < -55f) || (angle > 55f)) direction *= -1f; // reverse direction (toggles between 1 & -1)

        transform.Rotate (0, 0, speed * direction * Time.deltaTime);
    }
}
