using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bell_movement : MonoBehaviour
{
    public static bool hit;
    private void Update()
    {
        
        if (hit == true) {transform.Translate(Vector3.up *0.3f); }
    }

    private void OnCollisionEnter(Collision collision)
    {
       

        if (collision.gameObject.name == "seesawplank")
        {
            hit = true;
        }

        if (collision.gameObject.name == "cube123")
        {
            
            hit = false;
            gameObject.transform.position = gameObject.transform.position;
        }

    }
   






}
