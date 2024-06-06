using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movelayser : MonoBehaviour
{
    private int Number=0;
    private float timer = 0f;
    private bool moveRight = true;
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 5f)
        {
            timer = 0f;
            moveRight = !moveRight;
        }

        if (moveRight)
        {
            transform.Translate(Vector3.right * Time.deltaTime * 5f);
        }
        else
        {
            transform.Translate(Vector3.left * Time.deltaTime * 5f);
        }
        // linetransform.RotateAround(capsuletransform.position, Vector3.up, 2f * Time.deltaTime);
        // transform.LookAt(capsuletransform);
        // transform.LookAt(playertransform);

    }




  

  

}

