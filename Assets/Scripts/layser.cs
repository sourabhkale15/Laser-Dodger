using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class layser : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject bullet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Instantiate(bullet,transform.position,Quaternion.identity);
        }
        
    }
}
