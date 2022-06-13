using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peçasnivel2 : MonoBehaviour
{
  public GameObject peçah;
  public GameObject peçat;
  public GameObject peçam;
  public GameObject peçal;

  public string TagH;
  public string TagT;
  public string TagM;
  public string TagL;
  [SerializeField]  Animator animplat;



    void Start()
    {
    animplat = GetComponent<Animator>();
    }

    
    void Update()
    {
        
    }

  private void OnTriggerEnter(Collider collision)
  {
    if(collision.gameObject.tag == "TagH")
    {


      
    }

    if (collision.gameObject.name == "TagT")
    {

      
    }

    if (collision.gameObject.tag == "TagM")
    {

      animplat.Play("ativar");
    }

    if (collision.gameObject.name == "TagL")
    {


    }


  }


}
