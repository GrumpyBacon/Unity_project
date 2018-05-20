using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class On_collision_turnOffScript : MonoBehaviour {


    public GameObject scriptedObject;

    public GameObject colliderObject;


    void OnCollisionEnter(Collision collision)

    {






        if (gameObject.gameObject == colliderObject)
        {

            scriptedObject.GetComponent<Hammer_Spin>();
            enabled = false;






        }




        //if (collision.gameObject == colliderObject)
        {
           // Destroy(scriptedObject);
        }


    }





}
