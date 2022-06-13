using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class codepanel : MonoBehaviour
{
  //variaveis inicio
  [SerializeField] private Image imagemcode;

  public GameObject cameraobj;

  public GameObject plataformaObj;

  public GameObject playermove;

  public bool TriggerEntered = false;




  public Text Displaynumeros;
  
  
  //string codeTextValue = "0000";
     /*
  public Text um;
  public Text dois;
  public Text tres;
  public Text quatro;
  public Text cinco;
  public Text seis;
  public Text sete;
  public Text oito;
  public Text nove;
  */
  //variaveis fim

  void Start()
  {

    

  }



  void Update()
  {

    if (TriggerEntered == true && Input.GetKeyDown("e"))
    {
      imagemcode.gameObject.SetActive(true);

      playermove.GetComponent<PlayerMovement>().lookSpeed = 0.0f;

      Cursor.lockState = CursorLockMode.None;
      Cursor.visible = true;
    }

    if (Input.GetKeyDown("escape"))
    {
      imagemcode.gameObject.SetActive(false);

      playermove.GetComponent<PlayerMovement>().lookSpeed = 2.0f;

      Cursor.lockState = CursorLockMode.Locked;
      Cursor.visible = false;
    }



  }
  //funcao para escrever numero 1 no textnum ("display do code lock")



  public void codetexto1()
  {

    codigoGen("1");

  }
  //funcao para escrever numero 2 no textnum ("display do code lock")
  public void codetexto2()
  {

    codigoGen("2");

  }
  //funcao para escrever numero 3 no textnum ("display do code lock")
  public void codetexto3()
  {
    codigoGen("3");

  }
  //funcao para escrever numero 4 no textnum ("display do code lock")
  public void codetexto4()
  {

    codigoGen("4");

  }
  //funcao para escrever numero 5 no textnum ("display do code lock")
  public void codetexto5()
  {

    codigoGen("5");

  }
  //funcao para escrever numero 6 no textnum ("display do code lock")
  public void codetexto6()
  {

    codigoGen("6");
  }
  //funcao para escrever numero 7 no textnum ("display do code lock")
  public void codetexto7()
  {

    codigoGen("7");
  }
  //funcao para escrever numero 8 no textnum ("display do code lock")
  public void codetexto8()
  {

    codigoGen("8");

  }
  //funcao para escrever numero 9 no textnum ("display do code lock")
  public void codetexto9()
  {

    codigoGen("9");

  }
  
  public void codigoGen(string codigo)
  {
    Displaynumeros.text += codigo;

    if (Displaynumeros.text == "2589")
    {
      Displaynumeros.text = "CORRETO";

     plataformaObj.gameObject.SetActive(false);

    }

    if (Displaynumeros.text.Length >= 4)
    {
      Displaynumeros.text = "";
    }
    
   


  }

 

  void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Player"))
    {
      TriggerEntered = true;
    }



  }

  void OnTriggerExit(Collider other)
  {
    if (other.CompareTag("Player"))
    {
      TriggerEntered = false;
    }
  }

}
