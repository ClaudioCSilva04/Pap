using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animcontroller : MonoBehaviour
{
  public Animator LetraT;
    void Start()
    {
    LetraT = GetComponent<Animator>();
    }

   
    void Update()
    {
    if (Input.GetKeyDown("e"))
    {

      LetraT.SetBool("isdown", true);
      
    }

    if (Input.GetKey("e"))
    {

      LetraT.SetBool("isdown", true);

    }

    if (Input.GetKeyUp("e"))
    {

      LetraT.SetBool("isdown", false);

    }

  }
}
