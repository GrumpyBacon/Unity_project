using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrust_trigger_right : MonoBehaviour {

    public float speed;



    // Use this for initialization
    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == "Thrust_right")
        {


            //Debug.Log("hammer");
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * speed);




        }









    }
}
