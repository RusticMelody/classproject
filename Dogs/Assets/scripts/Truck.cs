using UnityEngine;
using TMPro;

public class Truck : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

    private new void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Old") && transform.CompareTag("Truck"))
        {
            score++;
            scoreText.text = "Big Dog: " + score.ToString();
            Destroy(collision.gameObject);
        }
    }
}
