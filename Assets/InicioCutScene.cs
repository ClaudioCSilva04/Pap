using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioCutScene : MonoBehaviour
{
  public GameObject player;
  public GameObject CutSceneCam;
  public GameObject SrRamos;
  

  public void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Player"))//se o player estiver no trigger
    {
      this.gameObject.GetComponent<BoxCollider>().enabled = false;
      SrRamos.gameObject.GetComponent<Animator>().enabled = false;
      CutSceneCam.SetActive(true);
      player.SetActive(false);
      StartCoroutine(FinishCut());
    }
  }

  IEnumerator FinishCut()
  {
    yield return new WaitForSeconds(12);
    player.SetActive(true);
    CutSceneCam.SetActive(false);
    SrRamos.gameObject.GetComponent<Animator>().enabled = true;
  }

}
