using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class livrosensor : MonoBehaviour
{
  public bool LivroEstaAberto = false;
  public Image livroaberto;//imagem do livro aberto
  public GameObject SensorPc2Final;//sensor do pc da sala 2
  public GameObject livro;//objeto do livro
  
  private bool triggerEntered = false;//verifica se está dentro do trigger
    
  void Start()
    {
        
    }

    void Update()
    {
        
    }

  private void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Player")&& livro.activeInHierarchy == true)//se o player estiver no trigger e o livro estiver ativo na hierarquia:
    {
      triggerEntered = true;
      

      LivroEstaAberto = true;
      livroaberto.gameObject.SetActive(true);//ativa a imagem do livro aberto

      SensorPc2Final.gameObject.SetActive(true);//ativa o sensor do pc da sala 2

    }


  }

  private void OnTriggerExit(Collider other)
  {
    
    triggerEntered = false;
    livroaberto.gameObject.SetActive(false);//desativa a imagem do livro aberto
    LivroEstaAberto = false;

  }






}
