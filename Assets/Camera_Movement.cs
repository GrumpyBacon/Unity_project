
using UnityEngine;
using System.Collections.Generic;
public class Camera_Movement : MonoBehaviour
{

   

    public List<GameObject> Target;

    public int Cameranumber = 0;

    public Transform target;

    public float smoothspeed = 0.125f;
    public Vector3 offset;






    private void Awake()
    {
        //sceneMainCamera = gameObject.GetComponent<Camera>();
    }
    private void FixedUpdate()
    {

        switch (Cameranumber)
        {
            case 0:

                CameraTarget();
                Vector3 desiredPosition = target.position + offset;
                Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

            case 1:
                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;



            default:

                //Debug.Log("camera change error");
                break;




        }





    }

    void CameraTarget()
    {
        //Debug.Log(Cameranumber);
        target = Target[Cameranumber].transform;




    }

    public void incrementplace()
    {
        //Debug.Log("FDJJDSJFD");
        Cameranumber += 1;


    }



}