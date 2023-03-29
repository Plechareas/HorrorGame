using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JammedDoor : MonoBehaviour
{
   
    
    
    public GameObject JammedDoorText;


   


    public AudioSource JammedSound;

    public bool lightsAreOn;
    public bool lightsAreOff;
    public bool inReach;


    void Start()
    {
        inReach = false;
        lightsAreOn = false;
        lightsAreOff = true;
        
        
        
    }



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            JammedDoorText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
           JammedDoorText.SetActive(false);
        }
    }



    void Update()
    {
        if(lightsAreOn && inReach && Input.GetButtonDown("Interact"))
        {
            
            
            
            JammedSound.Play();
            lightsAreOff = true;
            lightsAreOn = false;
        }

        else if (lightsAreOff && inReach && Input.GetButtonDown("Interact"))
        {
           
           
           
            JammedSound.Play();
            lightsAreOff = false;
            lightsAreOn = true;
        }


    }
}

