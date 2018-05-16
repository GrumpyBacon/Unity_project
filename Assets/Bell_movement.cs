using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bell_movement : MonoBehaviour
{
    public static bool hit;
    private void Update()
    {
        
        if (hit) {transform.Translate(Vector3.up *0.125f); }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "seesawplank")
        {
            hit = true;
        }

        while (collision.gameObject.name == "cube123")
        {
            hit = false;
        }

    }
   






}
