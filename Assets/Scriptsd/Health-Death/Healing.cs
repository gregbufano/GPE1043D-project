using UnityEngine;

public class Healing : MonoBehaviour
{
    public float HP;
    public AudioSource Healingeffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider collider)
    {
    if (collider.gameObject.TryGetComponent<Health>(out Health component))
    {
        component.Heal(HP);
        
    }
    healingEffective();
    Destroy(gameObject);
    }

    public void healingEffective()
    {
        Healingeffect.Play();
        Debug.Log("Audio has been played");
    }
}
