using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatePorta3 : MonoBehaviour
{
  [SerializeField] private Animator AnimPorta = null;//define por default que a animação é nula(parada)
  [SerializeField] private bool closeTrigger = false;//define que porta está fechada
  [SerializeField] private bool openTrigger = false;//define que porta está aberta
  
  


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
        AnimPorta.Play("Porta3AnimFechar", 0, 0.0f);
        gameObject.SetActive(false);
        
      }
      else if (openTrigger)
      {
        if (other.CompareTag("Player"))
        {
          if (openTrigger)
          {
            AnimPorta.Play("Porta3Anim", 0, 0.0f);
            gameObject.SetActive(false);
          }
        }
      }

    }
  }
}



