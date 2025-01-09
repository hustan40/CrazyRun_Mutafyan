using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToBall : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    
    void LateUpdate()
    {
        transform.position = ball.transform.position;    
    }
}
