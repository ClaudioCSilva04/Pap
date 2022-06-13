using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta2Animate : MonoBehaviour
{
  [SerializeField] private Animator AnimPorta = null;//define por default que a animação é nula(parada)
  [SerializeField] public bool closeTrigger = false;//define que porta está fechada
  [SerializeField] public bool openTrigger = false;//define que porta está aberta
  
  public GameObject verfificarlivro;//script para aceder ao script do livroabrir
  
  public GameObject SensorEntradaporta3;

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
        AnimPorta.Play("AnimPorta2Fechar", 0, 0.0f);
        gameObject.SetActive(false);
        SensorEntradaporta3.gameObject.SetActive(true);
        
      }
      else if (openTrigger)
      {
        if (other.CompareTag("Player"))
        {
          if (openTrigger)
          {
            
            AnimPorta.Play("AnimPorta2", 0, 0.0f);
            gameObject.SetActive(false);
          }
        }
      }


     

    }
  }
}
