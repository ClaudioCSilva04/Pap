using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Diario : MonoBehaviour
{
       public Image DiarioSrRamos;//imagem do diario 
       public bool TriggerEntered = false;//trigger não está ativo
    void Start()
    {
        
    }

    
    void Update()
    {
        if (TriggerEntered == true && Input.GetKeyDown("e"))
        {
             DiarioSrRamos.gameObject.SetActive(true);
        }

        if (Input.GetKeyDown("escape"))
        {
          DiarioSrRamos.gameObject.SetActive(false);
        }
  }

  public void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Player"))//se o player estiver no trigger
    {
      TriggerEntered = true;//trigger está ativo
    }

  }

  public void OnTriggerExit(Collider other)
  {
    if (other.CompareTag("Player"))//se o player estiver no trigger
    {
      TriggerEntered = false;//trigger está ativo
    }

  }



}
