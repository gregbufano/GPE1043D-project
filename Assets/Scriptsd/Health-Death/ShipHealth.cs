using UnityEngine;

public class ShipHealth : MonoBehaviour
{
    public Health healthComponent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthComponent = GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
