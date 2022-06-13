using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensordoPc : MonoBehaviour
{
  private bool triggerEntered = false; // faz a verificação da entrada no trigger

  
  public GameObject verificarSensorChave; //aceder ao script "keyclick.cs"
  public GameObject verificarSensorLivro; //aceder ao script "livrosensor.cs"
  public GameObject verificarSensorComando; //aceder ao script "Coomando.cs"
  public GameObject triggerPcSala3;



  void Start()
  {

  }


  void Update()
  {


  }

  private void OnTriggerEnter(Collider other)
  {
    
    if (other.CompareTag("Player"))//se o player entrar no trigger...
    {
      triggerEntered = true;//verifica que entrou (true)
      
    }

    if (verificarSensorComando.GetComponent<Coomando>().comandoImg.enabled==true)//se tiver o comando
    {
      
      triggerPcSala3.SetActive(true);//ativa o trigger para responder no pc da sala 3
    }


  }

  private void OnTriggerExit(Collider other)
  {
    
    triggerEntered = false;
   
  }

}
