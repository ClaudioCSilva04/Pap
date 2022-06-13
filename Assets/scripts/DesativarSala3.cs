using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesativarSala3 : MonoBehaviour
{
  public GameObject comandoAceder;
  public GameObject Pilha1Aceder;
  public GameObject Pilha2Aceder;
  public GameObject DicasAceder;





   
    void Start()
    {
        
    }

    
    void Update()
    {
        if (comandoAceder.GetComponent<Coomando>().comandoImg.enabled==true)
        {
            comandoAceder.GetComponent<Coomando>().comandoImg.enabled = false;
        }


        if (Pilha1Aceder.GetComponent<AbrirMochilaPilhas>().pilhaVermelha.enabled == true)
        {
            Pilha1Aceder.GetComponent<AbrirMochilaPilhas>().pilhaVermelha.enabled = false;
        }


        if (Pilha2Aceder.GetComponent<AbrirMochila2>().pilhaAzul.enabled == true)
        {
      Pilha2Aceder.GetComponent<AbrirMochila2>().pilhaAzul.enabled = false;
        }

        if (DicasAceder.GetComponent<alavancaprojetor>().dicaprojetor.enabled == true)
        {
            DicasAceder.GetComponent<alavancaprojetor>().dicaprojetor.enabled = false;
        }


  }
}
