using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public AudioSource scoreSound;
    public AudioClip scoreClip;
    private int score = 0;

    private new void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Young") && transform.CompareTag("NPC"))
        {
            score++;
            scoreText.text = "Small Dog: " + score.ToString();
            Destroy(collision.gameObject);
            scoreSound.PlayOneShot(scoreClip);
        }
    }
}
