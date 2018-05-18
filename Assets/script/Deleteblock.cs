using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deleteblock : MonoBehaviour {

    public GameObject deleteObject;

    public GameObject hit_by;

    void OnCollisionEnter(Collision collision)

    {

        if (collision.gameObject == hit_by)
        {
            Destroy(deleteObject);
        }

       
    }








}
