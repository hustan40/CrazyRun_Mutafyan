using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealTotate : MonoBehaviour
{
    public Joystick joystick;
    InputTouchs inputTouchs;
    [SerializeField] GameObject labb;
    Rigidbody rbLAbb;
    [SerializeField] float powerBall, vertical_input, horizontal_input;
    [Range(-1, 1)]
    [SerializeField] int inventX, inventY;
    bool moving;
    void Awake()
    {
        inputTouchs = GetComponent<InputTouchs>();
        rbLAbb = labb.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (inputTouchs.IsTouchCheck())
        {
            moving = true;
            vertical_input = joystick.Vertical;
            horizontal_input = joystick.Horizontal;
        }
        else
        {
            moving = false;
            vertical_input = 0;
            horizontal_input = 0;
        }

    }

    private void FixedUpdate()
    {
        if (moving)
        {
            MoveBall();
        }
    }

    private void MoveBall()
    {
        rbLAbb.AddTorque(horizontal_input * powerBall * inventY, 0, vertical_input * powerBall * inventX);
    }
}

