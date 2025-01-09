using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectStar : MonoBehaviour
{
    [SerializeField] WinScript winScript;
    AudioSource pickUpSound;
    private void Awake()
    {
        pickUpSound = GetComponent<AudioSource>();  
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            winScript.collectCount++;
            pickUpSound.Play();
            Destroy(gameObject, 0.3f);
        }
       
    }
}
