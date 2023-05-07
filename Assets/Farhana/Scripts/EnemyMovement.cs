using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform target; // the target position for the character to move towards
    public float attackRange = 2.0f; // the range at which the enemy will start its attack animation
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // find a point on the NavMesh surface that is close to the target position
        NavMeshHit hit;
        if (NavMesh.SamplePosition(target.position, out hit, 10.0f, NavMesh.AllAreas))
        {
            // set the NavMesh agent's destination to the closest point on the NavMesh surface
            agent.SetDestination(hit.position);

            // check if the player is within attack range
            float distance = Vector3.Distance(transform.position, target.position);
            if (distance < attackRange)
            {
                // trigger the attack animation
                GetComponent<Animator>().SetTrigger("Attack");
            }
        }
    }
}
