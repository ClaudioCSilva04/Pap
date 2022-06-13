using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonitorSala3Options : MonoBehaviour
{
  [SerializeField] private Animator AnimPorta = null;//criar animador para aceder � anima��o da porta da sala 2
  public AudioSource Error;//som erro
  public AudioSource Correct;//som correto
  public Button A;//botao A
  public Button B;//botao B
  public Button C;//botao C
  public GameObject sensorDesativarTudo;
  public bool CorrectisClicked = false; //define que o botao correto AINDA nao foi clicado
  public void BotaoA()
  {
    //som erro
    Correct.Play();
    CorrectisClicked = true;
  }


  public void BotaoB()
  {
    //som erro
    Error.Play();
    CorrectisClicked = false;
  }


  public void BotaoC()
  {
    //som correto
    Error.Play();
    CorrectisClicked = false;

  }

  public void Update()
  {
    if (CorrectisClicked == true)
    {
      AnimPorta.Play("AnimPorta3", 0, 0.0f);
      sensorDesativarTudo.SetActive(true);
    }

  }

}
