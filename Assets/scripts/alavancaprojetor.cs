using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class alavancaprojetor : MonoBehaviour
{
  public bool triggerEntered = false;//define se o trigger é ativado ou nao(default=false)
  [SerializeField] private bool upTrigger = false;//define que está em cima
  [SerializeField] private bool downTrigger = true;//define que está em baixo
  [SerializeField] private bool triggeredOnce = false;//define que está em baixo

  public GameObject verficarsetemcomando;
  public Image ComandoProjetor;//animador da alavanca do projetor
  public Animator QuadroBranco;//animador do quadro branco para cima
  public Animator QuadroBrancoDown;//animador do quadro branco para baixo
  public Text dicaprojetor;
  public GameObject projecaoObj;
  public GameObject acederComandoScript;
  
  void Start()
  {

  }


  // Update is called once per frame
  void Update()

  {

     

    if (Input.GetKeyDown("e") && triggerEntered == true)
    {

      if (downTrigger && acederComandoScript.GetComponent<Coomando>().temComando==true)
      {
        
        QuadroBranco.Play("AnimQuadro", 0, 0.0f);
        QuadroBranco.SetBool("KeyIsDownQuadro", true);
        projecaoObj.gameObject.SetActive(false);
        upTrigger = true;
        downTrigger = false;
      }
      else if(acederComandoScript.GetComponent<Coomando>().temComando == true)
      {
        
        QuadroBrancoDown.Play("AnimQuadroBaixo", 0, 0.0f);
        QuadroBrancoDown.SetBool("KeyIsDownQuadroBaixo", true);
        
        downTrigger = true;
        upTrigger = false;
        if(upTrigger == false)
        {
          projecaoObj.gameObject.SetActive(true);
        }
      }

      
    }

  }


    

     
      
    

 

  private void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Player"))
    {
      triggeredOnce = true;
      dicaprojetor.gameObject.SetActive(false);
      triggerEntered = true;
    }





  }

  private void OnTriggerExit(Collider other)
  {
    if (verficarsetemcomando.GetComponent<Coomando>().temComando == true) 
    {
      triggeredOnce = false;
      triggerEntered = false;
      dicaprojetor.gameObject.SetActive(true);
    }


      
  }



}
