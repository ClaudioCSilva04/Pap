using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbrirMochilaPilhas : MonoBehaviour
{

  public GameObject verficarsetemcomando;//verficar se o comando está com o jogador
  public Image inventariosemazul;//imagem do inventario
  public Image inventariosempilhas;//imagem do inventario sem as pilhas
  public Image inventariosempilhavermelha;//imagem do inventario sem a pilha azul apenas
  
  public Image pilhaVermelha;//imagem da pilha azul
  private bool isTrigger = false;//verifica se esta dentro do trigger(nao esta por default)
  public bool botaoclicadovermelho = false;//verifica se o botao azul e clicado

  public GameObject playermove;
  private void Update()
  {
    if (Input.GetKeyDown("e") && isTrigger == true)
    {
      if (botaoclicadovermelho == true)
      {
        
        inventariosempilhas.gameObject.SetActive(true);
        inventariosempilhavermelha.gameObject.SetActive(false);
      }
      inventariosempilhavermelha.gameObject.SetActive(true);
      Cursor.lockState = CursorLockMode.None;//... e o rato vai ficar visivel para poder aceder ao inventario...
      Cursor.visible = true;

      playermove.GetComponent<PlayerMovement>().lookSpeed = 0.0f;//...tambem vai proibir que a camera se mova, o que significa que o valor do "lookSpeed" e 0
      playermove.GetComponent<PlayerMovement>().walkingSpeed = 0.0f;
    }

    if (verficarsetemcomando.GetComponent<Coomando>().temComando == true)
    {
      inventariosempilhas.gameObject.SetActive(false);
      inventariosempilhavermelha.gameObject.SetActive(false);
      Cursor.lockState = CursorLockMode.Locked;//... e o rato vai ficar visivel para poder aceder ao inventario...
      Cursor.visible = false;

      playermove.GetComponent<PlayerMovement>().lookSpeed = 2.0f;
      
    }

    if(Input.GetKeyDown("escape"))
    {
      
        inventariosempilhavermelha.gameObject.SetActive(false);
        inventariosempilhas.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;//... e o rato vai ficar visivel para poder aceder ao inventario...
        Cursor.visible = false;

        playermove.GetComponent<PlayerMovement>().lookSpeed = 2.0f;//...tambem vai deixar que a camera se mova, o que significa que o valor do "lookSpeed" e 2
        playermove.GetComponent<PlayerMovement>().walkingSpeed = 7.5f;
      }
      
    }

  



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

  public void BotaoVermelho()//funcao do botaoazul
  {
    botaoclicadovermelho = true;//diz que o botao azul foi clicado
    pilhaVermelha.gameObject.SetActive(true);//aparece a imagem da pilha azul no canto inferior direito
  }

}
