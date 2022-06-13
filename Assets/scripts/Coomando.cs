using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coomando : MonoBehaviour
{

  public GameObject comando;//acede o objeto comando
  public Image comandoImg;//acede a imagemdo comando
  private bool tempilhas = false;//para verificar se tem as duas pilhas colectadas
  private bool tempilhaAzul = false;//para verficar se tem a pilha azul
  private bool tempilhaVermelha = false;//para verficar se tem a pilha vermelha
  public bool temComando = false;//para verficar se tem o comando (util no script: "alavancaprojetor.cs")
  public GameObject verificarPilhaVermelha;//para aceder ao script da pilha vermelha: "AbrirMochilaPilhas.cs"
  public GameObject verificarPilhaAzul;//para aceder ao script da pilha vermelha: "AbrirMochila2.cs"
  public GameObject textoDicaComando;//acede à dica do comando: "Não podes interagir com o comando! SEM PILHAS!"
  


  void Start()
  {
    temComando = false;
  }

  // Update is called once per frame
  void Update()
  {
    //verifica se clicou na pilha vermelha
    if(verificarPilhaVermelha.GetComponent<AbrirMochilaPilhas>().botaoclicadovermelho == true)
    {
      tempilhaVermelha = true;//se sim, a pilha vermelha está verificada 
    }

    //verifica se clicou na pilha azul
    if (verificarPilhaAzul.GetComponent<AbrirMochila2>().botaoclicadoazul == true)
    {
      tempilhaAzul = true; //se sim, a pilha azul está verificada 
    }
   //verifica se as duas pilhas form colectadas
    if (tempilhaVermelha == true && tempilhaAzul == true)
    {
      tempilhas = true;//se sim, estão as duas verificadas
    }
  }

  private void OnTriggerEnter(Collider other)
  {
    if (tempilhas == true)//se tiver as duas pilhas
    {
      temComando = true;
      comando.gameObject.SetActive(false);//desaparece o objeto do comando
      comandoImg.gameObject.SetActive(true);//aparece a imagem do comando no inventário
      textoDicaComando.gameObject.SetActive(false);//a dica do comando desparece
      
    }
    else
    {
      temComando = false;
    }


    if (other.CompareTag("Player"))//se o jogador entrar no trigger
    {

      textoDicaComando.gameObject.SetActive(true);//a dica aparece


    }


    if (other.CompareTag("Player")&& tempilhas == true) //se o player entrar no trigger e se tiver as duas pilhas ao mesmo tempo
    {

      textoDicaComando.gameObject.SetActive(false);//a dica desaparece


    }

  }

  private void OnTriggerExit(Collider other)
  {
    if (other.CompareTag("Player"))//se o jogador nsair do trigger
    {
      textoDicaComando.gameObject.SetActive(false);//a dica desaparece
    }
  }



}
