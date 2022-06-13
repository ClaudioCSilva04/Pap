using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MENU : MonoBehaviour
{
  public GameObject Res1;  
  public GameObject Res2;
  public Image BtnSettings;

  public void LoadScene(string sceneName)
  {
    SceneManager.LoadScene(sceneName);
  }

  public void Settings()
  {
    BtnSettings.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
    Res1.gameObject.SetActive(true);
    Res2.gameObject.SetActive(true);
  }

  public void Resolution1()
  {
    Screen.SetResolution(1920, 1080, true);
  }

  public void Resolution2()
  {
    Screen.SetResolution(1280, 720, true);
  }

}
