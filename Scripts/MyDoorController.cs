using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDoorController : MonoBehaviour
{
   public AudioSource OpenDoorSound;
    public AudioSource CloseDoorSound;
   private Animator doorAnim;

   private bool doorOpen = false;

   private void Awake()
   {
    doorAnim = gameObject.GetComponent<Animator>();
   }

   public void PlayAnimation()
   {
        if(!doorOpen)
        {
            doorAnim.Play("BasementDoorOpen", 0, 0.0f);
            doorOpen = true;
            OpenDoorSound.Play();
        }
        else
        {
            doorAnim.Play("BasementDoorClosed", 0, 0.0f);
            doorOpen = false;
            CloseDoorSound.Play();
        }
   }
}
