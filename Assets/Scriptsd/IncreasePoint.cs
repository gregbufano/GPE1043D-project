using UnityEngine;

public class IncreasePoint : MonoBehaviour
{
    public int ScoreIncreaseAmount;
    public AudioSource Pickup;
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
        Pickup.Play();
        GetPoints();
        
    }
    public void GetPoints()
    {
        GameManager.instance.IncreaseScore(ScoreIncreaseAmount);
        Destroy(gameObject);
    }
}
