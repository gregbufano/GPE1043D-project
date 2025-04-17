using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour

{
    public float Damage = 10;
    private void OnTriggerEnter(Collider collider){

    
    if (collider.gameObject.TryGetComponent<Health>(out Health component))
    {
        component.TakeDamage(Damage);
        Destroy(gameObject);
    }
   
    }
}
