using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrust_ball : MonoBehaviour {

    public float speed;



    // Use this for initialization
    private void OnCollisionEnter(Collision collision)
    {
        

        if (collision.gameObject.tag == "hammer") {

          
            Debug.Log("hammer");
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back * speed);




        }



        





    }


    

    
	
	// Update is called once per frame
	void Update () {
		



	}
}
