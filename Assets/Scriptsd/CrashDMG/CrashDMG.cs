using UnityEngine;

public class CrashDMG : MonoBehaviour
{
    public Health healthComponent;
    public float Damage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collider){
    if (collider.gameObject.TryGetComponent<Health>(out Health component))
    {
        component.TakeDamage(Damage);
        
    }
   }
}
