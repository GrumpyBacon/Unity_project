using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer_Spin : MonoBehaviour {

 
    void start ()
    {
        HingeJoint hinge = GetComponent<HingeJoint>();
        JointMotor motor = hinge.motor;
        motor.force = 1000000;
        motor.targetVelocity = -1000000;
        motor.freeSpin = true;
        hinge.motor = motor;
        hinge.useMotor = true;
    }
}
