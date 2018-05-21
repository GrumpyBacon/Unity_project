using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_button : MonoBehaviour {

    public Rigidbody rb;
    
    void Update () {

        if (Input.GetKeyDown("s"))

            rb.isKinematic = false;

    }
	
	
}
