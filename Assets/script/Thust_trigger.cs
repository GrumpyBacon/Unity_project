using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thust_trigger : MonoBehaviour {

    public float speed;



    // Use this for initialization
    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == "hammer")
        {


            Debug.Log("hammer");
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * speed);

            


        }









    }
}
