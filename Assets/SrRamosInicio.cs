using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SrRamosInicio : MonoBehaviour
{

  public bool CanPatrol = false;
  public void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Player"))//se o player estiver no trigger
    {
      CanPatrol = true;
    }
    
    
    
    
    
    
    
  }
}
