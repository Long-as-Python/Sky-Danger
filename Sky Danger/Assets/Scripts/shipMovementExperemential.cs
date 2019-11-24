using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipMovementExperemential : MonoBehaviour
{
    [Range(5f, 100f)]
    public float speed = 12f;
    public float f = 0f;
    void Update()

    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            if (f < 5)
            {
                f = f + 0.05f;
            }
        }
        else
        {
            if(f >= 0)
            {
                f = f - 0.01f;
            }
            if(f < 0)
            {
                f = 0;
            }
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {

        }
        transform.position += new Vector3(0, 0, f * speed * Time.deltaTime);
    }
}
