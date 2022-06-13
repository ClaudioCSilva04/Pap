using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
  //variaveis inicio
  public float mouseSensitivity = 300f;
  public Transform playerBody;

  float xRotation = 0f;
  float yRotation = 0f;
  //variaveis fim

  
  void Start()
  {
    Cursor.lockState = CursorLockMode.Locked; //rato fica desativado na tela (invisivel)
  }


  void Update()
  {
    float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime; //detetar a posi��o do rato (x,y)
    float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime; //detetar a posi��o do rato (x,y)

    xRotation -= mouseY;
    xRotation = Mathf.Clamp(xRotation, -90f, 90f); //fun��o matematica para definir rota��o do rato
    yRotation = Mathf.Clamp(yRotation, -90f, 90f); //fun��o matematica para definir rota��o do rato

    transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); //definir posi��o (transform) da camera 
    playerBody.Rotate(Vector3.up * mouseX);



  }







}




