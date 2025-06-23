using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public Transform target1;
    public Transform target2;
    public Transform target3;
    public Transform target4;
    public Transform target5;
    public Transform target6;
    private Transform[] targets;
    private int i;
    private UnityEngine.AI.NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        targets = new Transform[6];
        targets[0] = target1;
        targets[1] = target2;
        targets[2] = target3;
        targets[3] = target4;
        targets[4] = target5;
        targets[5] = target6;
        i = 0;
        agent.SetDestination(target1.position);
    }

    void FixedUpdate()
    {
        // if (target != null)
            // agent.SetDestination(target1.position);
    }

    void OnTriggerEnter(Collider other)
    {
        switch (i)
        {
            case 5:
                i = 0;
                agent.SetDestination(targets[i].position);
                break;
            default:
                i += 1;
                agent.SetDestination(targets[i].position);
                break;
        }
        
    }
}
