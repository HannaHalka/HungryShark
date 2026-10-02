using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score Instance { get; private set; }

    [SerializeField] private int score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);   
    }

    private void Start()
    {
        UpdateScoreUI(); 
    }

    public void AddScore(int amount)
    {
        score += amount;
        Debug.Log("Score: " + score); 
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null) scoreText.text = "Score: " + score;
    }

    public int GetScore()
    {
        return score;
    }
}