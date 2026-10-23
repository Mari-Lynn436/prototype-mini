using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private float hInput;
    private float vInput;
    public float rotationSpeed;
    public Vector3 jump; 
    public float jumpForce = 2.0f;

    public bool isGrounded;
    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
        // notice how the "jump" only uses the y axis
    }
    void OnCollisionStay(){
        isGrounded = true; 
        // isGrounded means to stay on the ground and to only allow the player to jump once and not many many times into the air

        }
    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");
        // horizontal and vertical movement
        
        
        transform.Translate(Vector3.forward * speed * Time.deltaTime * vInput);
        
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * hInput);
       
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded){

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            // isGrounded being false allows a jump
        }
    }

}