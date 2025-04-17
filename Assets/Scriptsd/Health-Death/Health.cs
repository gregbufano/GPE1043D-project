using UnityEngine;

public class Health : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth;

     public Death deathComponent;

   
    void Start()
    {
        deathComponent = GetComponent<Death>();
    }

    
    void Update()
    {
        
    }

    public void Heal(float amount)
    {
        currentHealth = currentHealth + amount;

        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        
    }

    public void TakeDamage(float amount)
    {
        currentHealth = currentHealth - amount;

        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);


        if (currentHealth <= 0)
        {
            // Die
            print("Triggering Death");
            deathComponent.Die();
        }
    }

    public bool IsAlive()
    {
        if (currentHealth > 0)
        {
            return true;
        }

        return false;
    }
}

