using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Wendy's Codes/Movement/Player")]

public class PlayerMovement : MonoBehaviour {

    public CharacterController charController;
    public Vector3 directionInfo;
    public float force = 5;
    public float gravity = 20;
    public float jumpForce = 20;
	// Use this for initialization
	void Start () {
        charController = this.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        

        if (charController.isGrounded)
        {
            directionInfo = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            // direction * a force = movment
            //directionInfo *= force;
            directionInfo = directionInfo * force;



            if (Input.GetButton("Jump"))
            {
                directionInfo.y = jumpForce;
            }
        }
 

        directionInfo.y -= gravity * Time.deltaTime; //this emulates gravity
        //now lets move the object using our character controller
        charController.Move(directionInfo * Time.deltaTime);
        
	}
}
