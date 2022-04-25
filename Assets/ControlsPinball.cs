using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsPinball : MonoBehaviour
{
    public GameObject left;
    public bool leftBool;
    public float leftTimerA;
    public float leftTimerB;
    public GameObject right;
    public bool rightBool;
    public float rightTimerA;
    public float rightTimerB;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Left();
        }
        if (leftBool == true)
        {
            leftTimerA -= Time.deltaTime;
        }
        if (leftTimerA <= 0 && leftTimerB > -.2f)
        {
            left.GetComponent<HingeJoint>().useMotor = false;
            leftBool = false;
            leftTimerB -= Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Right();
        }
        if (rightBool == true)
        {
            rightTimerA -= Time.deltaTime;
        }
        if (rightTimerA <= 0 && rightTimerB > -.2f)
        {
            right.GetComponent<HingeJoint>().useMotor = false;
            rightBool = false;
            rightTimerB -= Time.deltaTime;
        }
    }
    public void Left()
    {
        if (leftTimerB <= 0)
        {
            left.GetComponent<HingeJoint>().useMotor = true;
            leftBool = true;
            leftTimerA = .2f;
            leftTimerB = .2f;
        }
    }
    public void Right()
    {
        if (rightTimerB <= 0)
        {
            right.GetComponent<HingeJoint>().useMotor = true;
            rightBool = true;
            rightTimerA = .2f;
            rightTimerB = .2f;
        }
    }
}
