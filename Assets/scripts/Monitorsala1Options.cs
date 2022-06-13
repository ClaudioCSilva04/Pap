using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monitorsala1Options : MonoBehaviour
{
  [SerializeField] private Animator AnimPorta = null;//criar animador para aceder à animação da porta da sala 1
  public AudioSource Error;//som erro
  public AudioSource Correct;//som correto
  public Button A;//botao A
  public Button B;//botao B
  public Button C;//botao C
  public GameObject VerificarChave;//acede ao script do keyclick.cs para verificar variavel
  public bool CorrectisClicked = false; //define que o botao correto AINDA nao foi clicado
  public void BotaoA()
  {
    //som de erro
    Error.Play();
    CorrectisClicked = false;
  }


  public void BotaoB()
  {
    //som de correto
    Correct.Play();
    CorrectisClicked = true;//botao correto clicado
  }


  public void BotaoC()
  {
    //som de erro
    Error.Play();
    CorrectisClicked = false;
  }

  public void Update()
  {
    if(CorrectisClicked == true)
    {
      AnimPorta.Play("PortaAbrir", 0, 0.0f);
      VerificarChave.GetComponent<keyclick>().imagemchave.enabled = false;
    }
  }

}
