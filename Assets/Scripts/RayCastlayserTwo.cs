using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.HID;
using UnityEngine.SceneManagement;

public class RayCastlayserTwo : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private LineRenderer lineRenderer;
    [SerializeField] LayerMask layerMask;
    private bool once;
    RaycastHit hit, hit2 ;
    [SerializeField] private Transform ball;
    void Start()
    {
        Invoke("delay", 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (once == true)
        {
            layser();
            //  hit = new RaycastHit();
        }


    }

    private void layser()
    {
        Ray ray = new Ray(transform.position,  Vector3.left);
        // lineRenderer.SetPosition(0, Vector3.forward*2);

        Physics.Raycast(ray, out hit, 150, layerMask);
        Debug.DrawRay(transform.position, Vector3.left* 250, Color.red, 10);
        //Debug.DrawLine(transform.position, transform.forward, Color.red, 10);
        // lineRenderer.SetPosition(1, Vector3.forward*150);
        if (hit.collider != null)
        {
            Debug.Log("oj");
            Debug.Log(hit.collider.gameObject.name);
            if (hit.collider.gameObject.name == "player ")
            {
                Debug.Log("works");
                SceneManager.LoadScene("GameOverScreen");
            }
        }

    }


    private void delay()
    {
        once = true;
    }



}
