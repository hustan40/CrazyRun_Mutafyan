using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeToSolve : MonoBehaviour
{
    [SerializeField] public float timeToSolve;
    [SerializeField] public Image cooldown;
    [SerializeField] public bool solveUspel = true;

    private void Awake()
    {
        cooldown.fillAmount = 1;
    }

    void Update()
    {
        TimeSolving();
    }

    private void TimeSolving()
    {
        cooldown.fillAmount -= 1.0f / timeToSolve * Time.deltaTime;
        if (cooldown.fillAmount <= 0.0f)
        {
            solveUspel = false;
        }
    }
}
