using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensorAlavanca : MonoBehaviour
{
  private bool triggerEntered = false;

  public Animator Alavanca;
  public Animator Giz;

  public Text TextoAlavanca;
  void Start()
    {
       
    }

    
    void Update()
  {
    if (Input.GetKeyDown("e") && triggerEntered == true)
    {

      Alavanca.SetBool("KeyIsDown", true);
      Giz.SetBool("KeyIsDownGiz", true);

    }

    if (Input.GetKey("e") && triggerEntered == true)
    {

      Alavanca.SetBool("KeyIsDown", true);
      Giz.SetBool("KeyIsDownGiz", true);
    }

    if (Input.GetKeyUp("e") && triggerEntered == true)
    {

      Alavanca.SetBool("KeyIsDown", false);
      Giz.SetBool("KeyIsDownGiz", false);
    }
  }


  private void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Player"))
    {
      triggerEntered = true;
      TextoAlavanca.gameObject.SetActive(true);
    }


  }

  private void OnTriggerExit(Collider other)
  {
    TextoAlavanca.gameObject.SetActive(false);
    triggerEntered = false;
   
  }

}
