using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepPrompt : MonoBehaviour {

    public GameObject Sleep;

    // Use this for initialization
    void Start()
    {
        Sleep.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Sleep.SetActive(true);


        }
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerExit(Collider other)
    {
        Sleep.SetActive(false);


    }
}
