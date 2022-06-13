using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
  
  //variaveis inicio
  [Header("Movement")]
  public float moveSpeed = 6f;
  public float movementMultiplier = 10f;
  float rbDrag = 6f;

  float horizontalMovement;
  float verticalMovement;

  Vector3 moveDirection;

  Rigidbody rb;
  //variaveis fim

  private void Start()
  {
    rb = GetComponent<Rigidbody>();
    rb.freezeRotation = true;
  }


  private void Update()
  {
    MyInput();
    ControlDrag();
  }

  void MyInput()
  {

    horizontalMovement = Input.GetAxisRaw("Horizontal"); //detetar input (botao) para movimento horizontal
    verticalMovement = Input.GetAxisRaw("Vertical");     //detetar input(botao) para movimento vertical

    moveDirection = transform.forward * verticalMovement + transform.right * horizontalMovement; 
  }

  void ControlDrag()
  {
    rb.drag = 6f;
  }




  private void FixedUpdate()
  {
    MovePlayer(); //mover player funcao
  }

  void MovePlayer()
  {
    rb.AddForce(moveDirection.normalized * moveSpeed * movementMultiplier, ForceMode.Acceleration); //adicionar força para movimentar jogador (Player)
  }
  
}









