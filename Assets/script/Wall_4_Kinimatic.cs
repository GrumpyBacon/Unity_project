using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_4_Kinimatic : MonoBehaviour {

    public GameObject kinematicOff;
    public GameObject trigger;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == trigger)

        {
             var rb = kinematicOff.GetComponent<Rigidbody>();
            rb.isKinematic = false;
            




        }


        if (other.gameObject == trigger)

        {

            Destroy(trigger);



        }
       
        


    }


















}
