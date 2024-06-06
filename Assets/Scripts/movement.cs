using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{

    [SerializeField]  private Rigidbody rb;
    [SerializeField] int Moveforce;
    [SerializeField] float rotationforce;
    private Vector2 value;
    [SerializeField] private Transform VirtualCamera;
    [SerializeField] private AudioSource audioSourace;
    [SerializeField] Animator animator;
    private bool isgrounded;
    void Start()
    {
        
    }

    private void Update()
    {

        rotationforce = VirtualCamera.rotation.y;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.name=="ground"))
        {
            isgrounded = true;
        }

        if ((collision.gameObject.name == "Plane"))
        {
            SceneManager.LoadScene("GameOverScreen");
        }

    }

    public void jump(InputAction.CallbackContext context)
    {
        if (context.performed) 
        {
            if (isgrounded) 
            {  //Debug.Log("jump");
                rb.AddForce(Vector3.up * 15, ForceMode.VelocityChange);
                audioSourace.Play();
                isgrounded = false;
            }
        }
       
    }
    
     public void Move(InputAction.CallbackContext context)
     { value = context.ReadValue<Vector2>();
         if (context.performed)
         {
            // Debug.Log(value);
           //  Debug.Log("move");
             if (value == Vector2.up)
             {
                // Debug.Log("w");
                 transform.Translate(Vector3.forward * Moveforce * Time.deltaTime);
                 animator.SetBool("run", true);
             }
             else if(value == Vector2.right)
             {
                // Debug.Log("d");
                 transform.Translate(Vector3.right * Moveforce * Time.deltaTime);
                 // VirtualCamera.rotation = Quaternion.Euler(0f,rotationforce * Time.deltaTime*10, 0f);
                 VirtualCamera.rotation = Quaternion.Euler(
          VirtualCamera.rotation.eulerAngles.x,
          VirtualCamera.rotation.eulerAngles.y + 9,
          VirtualCamera.rotation.eulerAngles.z);


                transform.rotation = Quaternion.Euler(
         transform.rotation.eulerAngles.x,
         transform.rotation.eulerAngles.y + 10,
         transform.rotation.eulerAngles.z);
             }
             else if(value==Vector2.left)
                 {
                 //Debug.Log("a");
                 transform.Translate(Vector3.left * Moveforce * Time.deltaTime);
                 // VirtualCamera.rotation = Quaternion.Euler(0f, rotationforce * Time.deltaTime * 10, 0f); ;

                 VirtualCamera.rotation = Quaternion.Euler(
         VirtualCamera.rotation.eulerAngles.x,
         VirtualCamera.rotation.eulerAngles.y - 9,
         VirtualCamera.rotation.eulerAngles.z);


                 transform.rotation = Quaternion.Euler(
         transform.rotation.eulerAngles.x,
         transform.rotation.eulerAngles.y - 10,
         transform.rotation.eulerAngles.z);
             }
             else if(value==Vector2.down) 
             {
                // Debug.Log("s");
                 transform.Translate(Vector3.back * Moveforce * Time.deltaTime);
             }

             animator.SetBool("run", false);

        }

     }
      

}
