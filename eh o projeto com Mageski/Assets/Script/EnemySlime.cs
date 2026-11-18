using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class EnemySlime : MonoBehaviour
{

    private GameManager gameManager;
    private Animator anim;

    [SerializeField] private int hp;
    private bool isDie;

    [SerializeField] private EnemyState state;

    [SerializeField] private const float idleWaitTime = 3f;
    [SerializeField] private const float patrolWaitTime = 5f;
    
    [Header("AI Details")]
    private NavMeshAgent agent;
    private Vector3 destination;
    private int idWayPoint;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        gameManager = FindAnyObjectByType(typeof(GameManager)) as GameManager;
        
        ChangeState(state);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GetHit(int amount)
    {

        if (isDie)
        {
            return;
        }
        
        hp -= amount;
        
        if (hp > 0)
        {
            anim.SetTrigger("getHit");
        }
        else
        {
            anim.SetTrigger("die");
            StartCoroutine(Died());
            isDie = true;
        }
    }

    private IEnumerator Died()
    {
        yield return new WaitForSeconds(2.5f);
        Destroy(this.gameObject);
    }

    private void StateManager() //Responsável por informar o que vai acontecer em cada estado, armazenando o que acontecerá em cada um deles
    {
        switch (state)
        {
            case EnemyState.IDLE:
                break;
            case EnemyState.ALERT:
                break;
            case  EnemyState.EXPLORE:
                break;
            case EnemyState.PATROL:
                break;
            case EnemyState.FOLLOW:
                break;
            
        }
    }

    private void ChangeState(EnemyState mewState) //responsável por mudar de estado
    {
        
        StopAllCoroutines();
        
        state = mewState;
        
        switch (state)
        {
            case EnemyState.IDLE:
                destination = transform.position;
                agent.destination = destination;
                StartCoroutine(IdleRoutine());
                break;
            case EnemyState.PATROL:
                idWayPoint = Random.Range(0, gameManager.slimeWayPoints.Length);
                destination = gameManager.slimeWayPoints[idWayPoint].position;
                agent.destination = destination;
                StartCoroutine(PatrolRoutine());
                break;
            case EnemyState.ALERT:
                break;
            
        }
    }

    private IEnumerator IdleRoutine()
    {
        yield return new WaitForSeconds(idleWaitTime);

        if (Random.Range(0, 100) < 50)
        {
            ChangeState(EnemyState.IDLE);
        }
        else
        {
            ChangeState(EnemyState.PATROL);
        }
    }

    private IEnumerator PatrolRoutine()
    {
        yield return new WaitForSeconds(patrolWaitTime);

        ChangeState(EnemyState.IDLE);
    }

}
