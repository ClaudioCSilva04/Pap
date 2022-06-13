using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSrRamos : MonoBehaviour
{
  public bool ponto1C = false; //bool do ponto1 (trigger OFF)
     
  public bool ponto2C = false; //bool do ponto2 (trigger OFF)
  public bool ponto3C = false; //bool do ponto3 (trigger OFF)
  public bool ponto4C = false; //bool do ponto4 (trigger OFF)
  public bool ponto5C = false; //bool do ponto5 (trigger OFF)
  public bool ponto6C = false; //bool do ponto6 (trigger OFF)
  public GameObject SrRamosOBJ;
  public Transform ponto5D;//transform do ponto5
  public GameObject ponto1D;//objeto do ponto1 
  void Start()
    {
    ponto1D.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  private void OnTriggerEnter(Collider other)
  {
    if(other.CompareTag("SrRamos"))
    {
     
      
      ponto2C = true;
      ponto3C = true;
      ponto4C = true;
      ponto5C = true;
      ponto6C = true;

      if (ponto1C == true && ponto2C == true && ponto3C == true && ponto4C == true)//se o srRamos estiver dentro dos triggers dos pontos...
      {
        SrRamosOBJ.transform.Rotate(0, 90, 0);
      }

      if(ponto5C == true && ponto6C == true)
      {
        //Instantiate(SrRamosOBJ, ponto5D.position, ponto5D.rotation);
      }


      if (ponto6C == true)
      {
        ponto1C = true;
        ponto1D.gameObject.SetActive(true);
        
      }
     
    }
  }

  

}
