using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class SrRamosAI : MonoBehaviour
{
 public NavMeshAgent agent;

  public Transform player;

  public GameObject AcederSrRamosInicio;//acede ao script de iniciar o movimento

  public LayerMask whatIsGround, whatIsPlayer;

  public float health;

  public bool isPatroling = false;
  //Patroling
  public Vector3 walkPoint;
  bool walkPointSet;
  public float walkPointRange;

  //Attacking
  public float timeBetweenAttacks;
  bool alreadyAttacked;
  

  //States
  public float sightRange, attackRange;
  public bool playerInSightRange, playerInAttackRange;

  private void Awake()
  {
    player = GameObject.Find("personagem").transform;
    agent = GetComponent<NavMeshAgent>();
    
  }

  private void Update()
  {
    //Check for sight and attack range
    
    playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
    playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);
    
    if (!playerInSightRange && !playerInAttackRange && AcederSrRamosInicio.GetComponent<SrRamosInicio>().CanPatrol == true)
    {
       Patroling();
      isPatroling = true;
    }
    /*
    if (playerInSightRange && !playerInAttackRange)
    {
      
      ChasePlayer();
      isPatroling = false;
    } 
    
    if (playerInAttackRange && playerInSightRange)
    {
      AttackPlayer();
    } 

    */
  }

  public void Patroling()
  {
    if (AcederSrRamosInicio.GetComponent<SrRamosInicio>().CanPatrol == true)
    {


      isPatroling = true;
      if (!walkPointSet) SearchWalkPoint();

      if (walkPointSet && isPatroling == true)
      {
        agent.SetDestination(walkPoint);

      }
    }

    Vector3 distanceToWalkPoint = transform.position - walkPoint;

    //Walkpoint reached
    if (distanceToWalkPoint.magnitude < 1f)
      walkPointSet = false;
  }
  private void SearchWalkPoint()
  {

    //Calculate random point in range
    float randomZ = Random.Range(-walkPointRange, walkPointRange);
    float randomX = Random.Range(-walkPointRange, walkPointRange);

    walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, 0f + randomZ);

    if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
      walkPointSet = true;
  }
  /*
  private void ChasePlayer()
  {
    agent.SetDestination(player.position);
    
    isPatroling = false;
  }
  */
  private void AttackPlayer()
  {
    //Make sure enemy doesn't move
    
    //agent.SetDestination(transform.position);

    transform.LookAt(player);

    if (!alreadyAttacked)
    {
      ///Attack code here
     
      ///End of attack code

      alreadyAttacked = true;
      Invoke(nameof(ResetAttack), timeBetweenAttacks);
    }
    
  }

  private void ResetAttack()
  {
    alreadyAttacked = false;
  }

  
  private void DestroyEnemy()
  {
    Destroy(gameObject);
  }

  private void OnDrawGizmosSelected()
  {
    Gizmos.color = Color.red;
    Gizmos.DrawWireSphere(transform.position, attackRange);
    Gizmos.color = Color.yellow;
    Gizmos.DrawWireSphere(transform.position, sightRange);
  }

  /*
  public void OnCollisionEnter(Collision col)
  {
    if (col.collider.CompareTag("Walls")) 
    {
      Patroling();
    }
  }
  */
}
