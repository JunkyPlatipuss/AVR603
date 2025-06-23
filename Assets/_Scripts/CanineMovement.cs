using UnityEngine;

public class CanineMovement : MonoBehaviour
{

    public Transform target;
    private UnityEngine.AI.NavMeshAgent agent;
    public float MinDist = 70;
    private Vector3 pos;
    private Vector3 dogPos;
    private bool chck;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

        dogPos = this.transform.position;
        chck = false;
    }

    // Update is called once per frame
    void Update()
    {   
        pos = target.position;
        float Dist = Vector3.Distance(pos, dogPos);
        // Debug.Log(Dist);
        if (Dist <= MinDist || chck)
        {
            if (target != null)
            {
                agent.SetDestination(target.position);
                chck = true;
            }
        }
            
    }
}
