using UnityEngine;

public class AiController : MonoBehaviour
{
    public AiPawn pawn;

    public Transform target;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }
    public void ProcessInputs()
    {
       // MoveRigidbody()
       MoveTransform();
    }

    public void MoveRigidbody()
    {
        Vector3 directionToTarget = target.position - pawn.transform.position;

        directionToTarget = directionToTarget.normalized;

        pawn.MoveRigidbody(directionToTarget);
    }

    public void MoveTransform()
    {
        Vector3 directionToTarget = target.position - pawn.transform.position;

        directionToTarget = directionToTarget.normalized;

        pawn.MoveTransform(directionToTarget);
    }
}
