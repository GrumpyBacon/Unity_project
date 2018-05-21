
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Camerachangescript : MonoBehaviour
{

    
    public Camera_Movement camChange;

    public GameObject cameraTrigger;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cam_change")
        {
            camChange.incrementplace();

            Destroy(cameraTrigger);
        }
        //Debug.Log("Hi");

    }




}









