using UnityEngine;

public class Fish : MonoBehaviour
{
    [Header("Fish Settings")]
    [SerializeField] private int rewards = 67; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<SharkController>() != null || other.CompareTag("Player"))
        {
            if (Score.Instance != null) Score.Instance.AddScore(rewards);
            Destroy(gameObject);
        }
    }
}
