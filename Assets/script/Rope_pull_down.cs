using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope_pull_down : MonoBehaviour {

    bool hit = false;


    private void Update()
    {
            if (hit == true)
            {
                transform.Translate(Vector3.down * 0.10f);


            }
           

        
    }



    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "D4_Ball_3")
        {


            hit = true;
            Debug.Log("hit");




        }
    }







    //private void on(Collision collision)
    







    





}
