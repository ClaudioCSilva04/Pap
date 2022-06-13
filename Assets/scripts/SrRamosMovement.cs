using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SrRamosMovement : MonoBehaviour
{

  public GameObject[] pontos;
  int atual = 0;
  float rotSpeed;
  public float speed;
  
  float WPradius = 1;
  
  
  void Update()
  {
     
    if (Vector3.Distance(pontos[atual].transform.position, transform.position) < WPradius)
    {
      atual++;
      if(atual >= pontos.Length)
      {
        atual = 0;
      }
    }
    transform.position = Vector3.MoveTowards(transform.position, pontos[atual].transform.position, Time.deltaTime * speed);

    
    
  }






}
   
