using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateDoor : MonoBehaviour
{
  
  [SerializeField] private Animator AnimPorta = null;
  [SerializeField] public bool closeTrigger = false;
  [SerializeField] public bool openTrigger = false;
  public GameObject SensorEntradaporta2;

  
  
  void Start()
    {
        
    }

    
    void Update()
    {
        
    }

  private void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Player"))
    {
      if (closeTrigger)
      {
        AnimPorta.Play("AnimPorta", 0, 0.0f);
        gameObject.SetActive(false);
        SensorEntradaporta2.gameObject.SetActive(true);
      }
      else if (openTrigger)
      {
        if (other.CompareTag("Player"))
        {
          if (openTrigger)
          {
            AnimPorta.Play("PortaAbrir", 0, 0.0f);
            gameObject.SetActive(false);
           
          }
        }
      }

    }

  }

}
