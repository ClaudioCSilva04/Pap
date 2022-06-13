using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanterna : MonoBehaviour
{
  public bool isON;
  public Light luz;

    void Start()
    {
    isON = true;
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            isON=!isON;
        }

        if(isON == true)
        {
            luz.intensity = 42.0f;
        }
        else
        {
          luz.intensity = 0.0f;
        }
    }
}
