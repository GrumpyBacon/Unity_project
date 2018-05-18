using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight_Move_up : MonoBehaviour {


    bool hit = false;


    private void Update()
    {
        if (hit == true)
        {
            transform.Translate(Vector3.up * 0.10f);



        }



    }



    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "D4_Ball_3")
        {


            hit = true;
            




        }
    }










}
