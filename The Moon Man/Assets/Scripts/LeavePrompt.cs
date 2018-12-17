﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeavePrompt : MonoBehaviour {

    public GameObject UiObject;
    public GameObject Yes;
    public GameObject No;

	
	void Start () {
        UiObject.SetActive(false);
        Yes.SetActive(false);
        No.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            UiObject.SetActive(true);
            Yes.SetActive(true);
            No.SetActive(true);
          
        }
    }


    void Update () {
		
	}

    void OnTriggerExit(Collider other)
    {
        UiObject.SetActive(false);
        Yes.SetActive(false);
        No.SetActive(false);

    }
}
