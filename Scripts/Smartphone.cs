using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smartphone : MonoBehaviour
{
   
    
    
    public GameObject lightsText;


   


    public AudioSource switchClick;

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
            lightsText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            lightsText.SetActive(false);
        }
    }



    void Update()
    {
        if(lightsAreOn && inReach && Input.GetButtonDown("Interact"))
        {
            
            
            
            switchClick.Play();
            lightsAreOff = true;
            lightsAreOn = false;
        }

        else if (lightsAreOff && inReach && Input.GetButtonDown("Interact"))
        {
           
           
           
            switchClick.Play();
            lightsAreOff = false;
            lightsAreOn = true;
        }


    }
}

