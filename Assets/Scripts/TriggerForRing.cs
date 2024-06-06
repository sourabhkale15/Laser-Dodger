using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerForRing : MonoBehaviour
{
    [SerializeField] private Transform playerpostion;

    private void OnTriggerEnter(Collider other)
    {
       // Debug.Log("ojj");
       // Debug.Log(other.gameObject.name);
        if (other.gameObject.name =="player ")
        {
          //  Debug.Log("oh");
            playerpostion.position = new Vector3(9.69999981f, 11.1999998f, -115.900002f);
        }
    }
}
