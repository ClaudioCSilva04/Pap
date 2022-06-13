using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class keyclick : MonoBehaviour
{
  public bool hasKey = false;//verifica se tem chave
  [SerializeField] public Image imagemchave;//imagem da chave
  public GameObject key;//objeto da chave
  public bool keyIsinInventory = false;


  void Start()
    {
    hasKey = false;
    
    }

    
    void Update()
    {
    
    }

  private void OnTriggerEnter(Collider other)
  {

    if (other.CompareTag("Player"))
    {
      imagemchave.gameObject.SetActive(true);

      keyIsinInventory = true;

      hasKey = true;

      key.gameObject.SetActive(false);

    }
    else
    {
      keyIsinInventory = false;
    }
  }




}

