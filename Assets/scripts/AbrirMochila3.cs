using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbrirMochila3 : MonoBehaviour
{
  public GameObject verficarsetemcomando;//verficar se o comando está com o jogador
  public Image inventariosempilhas;//imagem do inventario sem as pilhas
  public GameObject playermove;//script do movimento do jogador
  public bool isTrigger = false;

  private void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Player"))
    {
      isTrigger = true;
    }
  }

  private void OnTriggerExit(Collider other)
  {
    if (other.CompareTag("Player"))
    {
      isTrigger = false;
    }
  }

  void Update()
  {
    if (Input.GetKeyDown("e") && isTrigger == true)
    {
      inventariosempilhas.gameObject.SetActive(true);
      Cursor.lockState = CursorLockMode.None;//... e o rato vai ficar visivel para poder aceder ao inventario...
      Cursor.visible = true;

      playermove.GetComponent<PlayerMovement>().lookSpeed = 0.0f;//...tambem vai proibir que a camera se mova, o que significa que o valor do "lookSpeed" e 0
      playermove.GetComponent<PlayerMovement>().walkingSpeed = 0.0f;

      if (verficarsetemcomando.GetComponent<Coomando>().temComando == true)
      {
        inventariosempilhas.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;//... e o rato vai ficar visivel para poder aceder ao inventario...
        Cursor.visible = false;

        playermove.GetComponent<PlayerMovement>().lookSpeed = 2.0f;
        
      }
    }


    if (Input.GetKeyDown("escape"))
    {
      inventariosempilhas.gameObject.SetActive(false);
      Cursor.lockState = CursorLockMode.Locked;//... e o rato vai ficar invisivel para não poder aceder mais ao inventario...
      Cursor.visible = false;

      playermove.GetComponent<PlayerMovement>().lookSpeed = 2.0f;//...tambem vai deixar que a camera se mova, o que significa que o valor do "lookSpeed" e 2
      playermove.GetComponent<PlayerMovement>().walkingSpeed = 7.5f;
    }



  }
}
