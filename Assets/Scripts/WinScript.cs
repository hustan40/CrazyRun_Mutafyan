using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class WinScript : MonoBehaviour
{
    [SerializeField] private TimeToSolve timeToSolve;
    [SerializeField] private GameObject timeBar, winPanel, pausePanel, starOn,starOut, placeStar1, placeStar2, placeStar3;
    [SerializeField] public byte winScored = 0, toWinCollect, collectCount;
    AudioSource winSound;

    private void Awake()
    {
        GameObject[] stars = GameObject.FindGameObjectsWithTag("Star");
        winSound = GetComponent<AudioSource>();
        foreach (GameObject star in stars)
        {
            toWinCollect++;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Time.timeScale = 0.0f;
            timeBar.SetActive(false);
            pausePanel.SetActive(false);
            winPanel.SetActive(true);
            winScored = 1;
            winSound.Play();
            WinInfo();
        }
    }

    void WinInfo()
    {
        if(timeToSolve.solveUspel == true | collectCount  == toWinCollect)
        {
            winScored = 2;
            if (timeToSolve.solveUspel == true & collectCount == toWinCollect)
            {
                winScored = 3;
            }
        }

        switch (winScored)
        {
            case 1:
                Instantiate(starOn,placeStar1.transform);
                Instantiate(starOut, placeStar2.transform);
                Instantiate(starOut, placeStar3.transform);
                break;
            case 2:
                Instantiate(starOn, placeStar1.transform);
                Instantiate(starOn, placeStar2.transform);
                Instantiate(starOut, placeStar3.transform);
                break;
            case 3:
                Instantiate(starOn, placeStar1.transform);
                Instantiate(starOn, placeStar2.transform);
                Instantiate(starOn, placeStar3.transform);
                break;

        }
    }
}

