using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class RotateLabyrinth : MonoBehaviour
{
    public Joystick joystick;
    InputTouchs inputTouchs;
    [SerializeField] GameObject ball;
    Rigidbody rbBall;
    [SerializeField] float powerBall, vertical_input, horizontal_input;
    [Range(-1, 1)]
    [SerializeField] int inventX, inventY;
    bool moving;
    void Awake()
    {
        inputTouchs = GetComponent<InputTouchs>();
        rbBall = ball.GetComponent<Rigidbody>();
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
        rbBall.AddForce(vertical_input * powerBall * inventY, 0, horizontal_input * powerBall * inventX);
    }
}
