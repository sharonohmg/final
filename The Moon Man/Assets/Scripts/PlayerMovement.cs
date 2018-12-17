using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    public float turn;
   


	
	void Start () {

        speed = 5f;
        turn = 5f;
	}
	
	
	void Update () {

        transform.Translate(speed * Input.GetAxis("Horizontal")*Time.deltaTime,0f, speed * Input.GetAxis("Vertical") * Time.deltaTime);

	}
}
