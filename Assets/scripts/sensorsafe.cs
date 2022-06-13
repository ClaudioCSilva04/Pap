using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sensorsafe : MonoBehaviour
{
  [SerializeField] public Image imagemchave;
  public Text textocofre;
  [SerializeField] public Image imagemcofre;

  private bool CofreEstaAbertof = false;
  public GameObject sensorcofrepc1;

  void Start()
    {
        
    }

  
    void Update()
    {
    if (CofreEstaAbertof == true)
    {

      sensorcofrepc1.gameObject.SetActive(true);

    }

  }

  private void OnTriggerEnter(Collider other)
  {

    if (other.CompareTag("Player"))
    {

      if (imagemchave.IsActive() == false)
      {

        textocofre.gameObject.SetActive(true);
        CofreEstaAbertof = false;
      }
      else
      {
        CofreEstaAbertof = true;
        imagemcofre.gameObject.SetActive(true);
      }


     

      

    }
  }

  private void OnTriggerExit(Collider other)
  {
    textocofre.gameObject.SetActive(false);
    imagemcofre.gameObject.SetActive(false);
  }


}
