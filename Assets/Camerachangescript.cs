
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Camerachangescript : MonoBehaviour
{

    
    public Camera_Movement camChange;

    public GameObject cameraObject;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cam_change")
        {
            camChange.incrementplace();
        }
        Debug.Log("Hi");

    }




}









