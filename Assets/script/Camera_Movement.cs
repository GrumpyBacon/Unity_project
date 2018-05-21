
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

            // Starting Ball
            case 0:

                offset.x = 10;
                offset.y = 10;
                offset.z = 10;
                CameraTarget();
                Vector3 desiredPosition = target.position + offset;
                Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

                // Domino
            case 1:

                
                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;
               
                // 1st Hammer
            case 2:

                offset.z = -10;
                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

           

            case 3:

                //Bell
                offset.x = -10;
                offset.z = -18;
                offset.y = 10;
                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

            case 4:

                //Ball _1

                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;


            case 5:

                //Ball _2

                offset.x = 10;
                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

            case 6:

                //Ball _3
                offset.x = -10;
                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

            case 7:

                //Bucket
                offset.x = 10;
                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

            case 8:

                //Weight

                offset.z = 10;
                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

            case 9:
                //Hammer _1

                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

            case 10:
                // HAmmer _2

                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

            case 11:
                //HAmmer _3

                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

            case 12:
                // Hammer _4

                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

            case 13:
                // RaceBall_A1

                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

            case 14:
                // Raceball_A2
                offset.y = -10;
                offset.z = 0;
                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

            case 15:
                // RaceBall_A3
                offset.y = 0;
                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

            case 16:
                // Button _1
                offset.y = 10;
                offset.x = 10;
                offset.z = 10;
                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

            case 17:

                // Bigg Hammer
                offset.y = 25;
                offset.x = 25;
                offset.z = 25;
                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

            case 18:

                //Big Ball _A1

                offset.y = -20;
                offset.x = 40;
                offset.z = -40;
            
                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

            case 19:
                //Big Ball _A2
                offset.y = 50;
                offset.x = 50;
                offset.z = 50;

                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

            case 20:
                //Col _A1
                offset.y = 20;
                offset.x = 20;
                offset.z = 20;

                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

            case 21:
                //HammerSwing _A1
                offset.y = 50;
                offset.x = 50;
                offset.z = 50;

                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

            case 22:
                //Col_A2
                offset.y = 20;
                offset.x = 20;
                offset.z = 20;

                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

            case 23:
                //Door

                offset.y = 50;
                offset.x = -50;
                offset.z = -50;

                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

            case 24:
                //HammerSwing _A2

                offset.y = 70;
                offset.x = -70;
                offset.z = -70;
                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

            case 25:
                //BigBall A3

                offset.y = 50;
                offset.x = -50;
                offset.z = -50;
                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

            case 26:
                //HammerSwing A3
                offset.y = 70;
                offset.x = -70;
                offset.z = -70;
                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

            case 27:
                //BigBall A4

                offset.y = 70;
                offset.x = -70;
                offset.z = -70;

                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

            case 28:
                offset.y = 30;
                offset.x = -100;
                offset.z = -100;

                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

            case 29:

                offset.y = 10;
                offset.x = -70;
                offset.z = -70;

                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

            case 30:
                offset.y = 90;
                offset.x = -150;
                offset.z = -500;

                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

            case 31:


                CameraTarget();
                desiredPosition = target.position + offset;
                smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
                transform.position = smoothedPosition;

                transform.LookAt(target);
                break;

            case 32:


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