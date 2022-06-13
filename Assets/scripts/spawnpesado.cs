using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpesado : MonoBehaviour
{

  public GameObject plat;



  void Start()
  {
    
  }


  void Update()
  {

  }
  //pressionar placa 
  private void OnTriggerEnter(Collider collision)
  {
    if (collision.gameObject.tag == "h" && collision.gameObject.tag == "t" && collision.gameObject.tag == "m" && collision.gameObject.tag == "l")
    {

      Destroy(plat);

    }

    


  }
}
