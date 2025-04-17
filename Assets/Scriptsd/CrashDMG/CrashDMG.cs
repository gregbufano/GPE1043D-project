using UnityEngine;

public class CrashDMG : MonoBehaviour
{
    public float Damage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onTriggerEnter(Collider other)
    {
        Debug.Log("Event Triggered");
        if (GetComponent<Collider>().gameObject.TryGetComponent<Health>(out Health component))
        {
            component.TakeDamage(Damage);
        }
    }
}
