using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressureSystem : MonoBehaviour
{
  //variaveis inicio
  [SerializeField]
  GameObject livro;
  
  //variaveis fim


  //livro começa desativado
  void Start()
  {
   livro.gameObject.SetActive(false);
  }

  //pressionar placa para livro ativar
  void OnTriggerEnter(Collider col)
  {
    if (col.CompareTag("moverobjetos"))
    {


      if (livro.activeInHierarchy == false)
      {
        livro.gameObject.SetActive(true);
      }
    }
    
   

  }
}
