using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sensorpcsala3 : MonoBehaviour
{
  private bool triggerEntered = false;
  public Image monitor3;
  public GameObject comandoVerificar;
  public GameObject acederProjetor;
  public GameObject acederComandoScript;


  public GameObject playermove;
  void Start()
  {

  }


  void Update()
  {
    if(Input.GetKeyDown("e") && triggerEntered == true)
    {
      monitor3.gameObject.SetActive(true);
      playermove.GetComponent<PlayerMovement>().lookSpeed = 0.0f;
      Cursor.lockState = CursorLockMode.None;
      Cursor.visible = true;
      playermove.GetComponent<PlayerMovement>().walkingSpeed = 0.0f;
      

    }

    if (Input.GetKeyDown("escape"))
    {
      monitor3.gameObject.SetActive(false);
      
      playermove.GetComponent<PlayerMovement>().lookSpeed = 2.0f;

      Cursor.lockState = CursorLockMode.Locked;
      Cursor.visible = false;
      acederProjetor.GetComponent<alavancaprojetor>().triggerEntered = true;
      playermove.GetComponent<PlayerMovement>().walkingSpeed = 7.5f;
    }

  }

  private void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Player") && comandoVerificar.GetComponent<Coomando>().temComando == true)
    {
      triggerEntered = true;
      acederComandoScript.GetComponent<Coomando>().temComando = false; //desativa o comando para não atrapalhar no trigger do pc
    }


  }

  private void OnTriggerExit(Collider other)
  {
    triggerEntered = false;
    acederComandoScript.GetComponent<Coomando>().temComando = true; //ativa o comando 
  }



}
