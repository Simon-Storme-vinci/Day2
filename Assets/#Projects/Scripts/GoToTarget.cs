using UnityEngine;
using UnityEngine.AI;

public class GoToTarget : MonoBehaviour
{
    [SerializeField] private Transform target;
    private NavMeshAgent agent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(target.position);
        agent.avoidancePriority = Random.Range(1, 100);
        agent.radius = Random.Range(0.5f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
