using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sensorpc2final : MonoBehaviour
{
  private bool triggerEntered = false;//avisa se estiver no trigger
  public Image monitor;//imagem do  monitor
  private bool livroAberto = false;//avisa que o livro foi aberto
  

  public GameObject playermove;//acede ao script do movimento do jogador
  void Start()
    {
        
    }

   
    void Update()
    {
    if (Input.GetKeyDown("e") && triggerEntered == true)
        {
          monitor.gameObject.SetActive(true);
          playermove.GetComponent<PlayerMovement>().lookSpeed = 0.0f;
          Cursor.lockState = CursorLockMode.None;
          Cursor.visible = true;
          playermove.GetComponent<PlayerMovement>().walkingSpeed = 0.0f;
        }


    if (Input.GetKeyDown("escape"))
        {
          monitor.gameObject.SetActive(false);

          playermove.GetComponent<PlayerMovement>().lookSpeed = 2.0f;

          Cursor.lockState = CursorLockMode.Locked;
          Cursor.visible = false;
          playermove.GetComponent<PlayerMovement>().walkingSpeed = 7.5f;
        }

        

  }

  private void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Player"))
    {
      triggerEntered = true;
     
    }


  }

  private void OnTriggerExit(Collider other)
  {
    triggerEntered = false;
    
  }






}
