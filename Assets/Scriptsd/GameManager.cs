using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public UIManager uiManager;

    public int score = 0;
    public int lives = 1;

    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReduceLiveByOne()
    {
        lives--;
        if (lives <= 0)
        {
            Lose();
        }
    }
    public void Win()
    {
       if (score >= 200)
            {
        Debug.Log("You Win!");
        SceneManager.LoadScene("WinScene");
        }
    }
    public void Lose()
    {
        // prep for adding loss 
    }

    public void IncreaseScore(int amount)
    {
         score += amount;
         uiManager.UpdateText("" + score);
    }
}
