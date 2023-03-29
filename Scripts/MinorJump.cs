using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinorJump : MonoBehaviour
{
  public GameObject cupObject;
  public GameObject sphereTrig;
  public AudioSource jumpscareSound;

 

  void OnTriggerEnter(Collider other)
  {
    this.gameObject.GetComponent<BoxCollider>().enabled = false;
    sphereTrig.SetActive(true);
    jumpscareSound.Play();
    StartCoroutine(DeactivateSphere());


  }

  IEnumerator DeactivateSphere()
  {
    yield return new WaitForSeconds(0.5f);
    sphereTrig.SetActive(false);
   
  }
  
}
