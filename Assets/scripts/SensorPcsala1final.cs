using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensorPcsala1final : MonoBehaviour
{
  private bool triggerEntered = false;//verifica se está dentro do trigger
  public Image monitor1;//imagem do monitor

  

  public GameObject playermove;//acede ao script do movimento do jogador
  void Start()
  {

  }


  void Update()
  {
    if (Input.GetKeyDown("e") && triggerEntered == true)
    {
      monitor1.gameObject.SetActive(true);//ativa a imagem do monitor
      playermove.GetComponent<PlayerMovement>().lookSpeed = 0.0f;//o jogador nao consegue olhar para os lados (movimentação da camera, valor 0)
      Cursor.lockState = CursorLockMode.None;// o rato fica desbloqueado
      Cursor.visible = true;//o rato aparece no ecrã para possiblitar a escolha
      playermove.GetComponent<PlayerMovement>().walkingSpeed = 0.0f;
    }

    if (Input.GetKeyDown("escape") && triggerEntered == false)
    {
      monitor1.gameObject.SetActive(false);//desativa a imagem do monitor
      playermove.GetComponent<PlayerMovement>().lookSpeed = 2.0f;//o jogador  consegue olhar para os lados (movimentação da camera, valor 2)
      Cursor.lockState = CursorLockMode.Locked;// o rato fica bloqueado
      Cursor.visible = false;//o rato desaparece do ecrã
      playermove.GetComponent<PlayerMovement>().walkingSpeed = 7.5f;
    }

  }

  private void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Player"))//se o player estiver no trigger
    {
      triggerEntered = true;   
    }


  }

  private void OnTriggerExit(Collider other)
  {
   triggerEntered = false;
  }




}
