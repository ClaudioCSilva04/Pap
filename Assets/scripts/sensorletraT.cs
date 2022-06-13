using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sensorletraT : MonoBehaviour
{
  private bool triggerEntered = false;

  public Animator LetraT;

  public Text textoT;
  void Start()
  {
    LetraT = GetComponent<Animator>();
    
  }

  void Update()
  {
    if (Input.GetKeyDown("e") && triggerEntered == true)
    {

      LetraT.SetBool("isdown", true);

    }

    if (Input.GetKey("e") && triggerEntered == true)
    {

      LetraT.SetBool("isdown", true);

    }

    if (Input.GetKeyUp("e") && triggerEntered == true)
    {

      LetraT.SetBool("isdown", false);

    }
  }


  private void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Player"))
    {
      triggerEntered = true;
      textoT.gameObject.SetActive(true);
    }
    

  }

  private void OnTriggerExit(Collider other)
  {
    textoT.gameObject.SetActive(false);
    triggerEntered = false;
  }


}
