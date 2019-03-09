using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float movementSpeed;
    public float myCelsius;
    public float myFarenheit;



    // Use this for initialization
    void Start () {
        // movementSpeed = 1f;
        myCelsius = 1f;

        myFarenheit = myCelsius * 9 / 5 + 32;

        print(myFarenheit);
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.Translate(movementSpeed*Input.GetAxis("Horizontal")*Time.deltaTime, 0, movementSpeed*Input.GetAxis("Vertical") * Time.deltaTime);
	}
}
