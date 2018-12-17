using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatPrompt : MonoBehaviour {

    public GameObject Eat;
   
    
    // Use this for initialization
    void Start () {
        Eat.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Eat.SetActive(true);


        }
    }

    // Update is called once per frame
    void Update () {
		
	}


    void OnTriggerExit(Collider other)
    {
        Eat.SetActive(false);
       

    }
}
