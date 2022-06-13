using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaidaDaEscola : MonoBehaviour
{
  [SerializeField] private Animator AnimPorta1 = null;//define por default que a animação é nula(parada)
  [SerializeField] private Animator AnimPorta2 = null;//define por default que a animação é nula(parada)
  public GameObject verificarPorta1;
  public GameObject verificarPorta2;
  public GameObject verificarPorta3;

  public bool TriggerEntered = false;

  public bool CompleteStage1 = false;
  public bool CompleteStage2 = false;
  public bool CompleteStage3 = false;
  public bool CompleteAllStages = false;




  void Start()
  {

  }


  void Update()
  {
    if (verificarPorta1.GetComponent<Monitorsala1Options>().CorrectisClicked == true)
    {
      CompleteStage1 = true;
    }

    if (verificarPorta2.GetComponent<monitoroptions>().CorrectisClicked == true)
    {
      CompleteStage2 = true;
    }


    if (verificarPorta3.GetComponent<MonitorSala3Options>().CorrectisClicked == true)
    {
      CompleteStage3 = true;
    }

    if (CompleteStage1 == true && CompleteStage2 == true && CompleteStage3 == true)
    {
      CompleteAllStages = true;
    }
  }

  public void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Player"))//se o player estiver no trigger
    {
      if(CompleteAllStages == true)
      {
        AnimPorta1.Play("PortaSaida1Abrir", 0, 0.0f);
        AnimPorta2.Play("PortaSaida2Abrir", 0, 0.0f);
      }
      
    }
  }

}
