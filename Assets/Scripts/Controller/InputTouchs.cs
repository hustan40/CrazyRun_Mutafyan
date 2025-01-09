using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTouchs : MonoBehaviour
{
    public Vector2 GetTouchDeltaPosition()
    {
        return Input.GetTouch(0).deltaPosition;
    }

    public bool IsTouchCheck()
    {
        if (Input.touchCount > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
