using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deleteblock : MonoBehaviour {

    public GameObject deleteObject;


    void OnCollisionEnter(Collision collision)

    {

        if (collision.gameObject.name == "bell")
        {
            Destroy(deleteObject);
        }

       
    }








}
