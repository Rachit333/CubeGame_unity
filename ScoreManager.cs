using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public Transform player;
    private float currentScore;
    private float highScore;

    public TMP_Text highScoreText; 

    void Start()
    {
        highScore = PlayerPrefs.GetFloat("HighScore", 0f);

        highScoreText.text = "High Score: " + highScore.ToString("F2");
    }

    void Update()
    {
        if (player != null)
        {
            if (player.position.y >= -0.01f)
            {
                currentScore = player.position.z;

                if (currentScore > highScore)
                {
                    highScore = currentScore;
                    
                    PlayerPrefs.SetFloat("HighScore", highScore);
                    PlayerPrefs.Save(); 

                    
                    highScoreText.text = "High Score: " + highScore.ToString("F2"); 
                }
            }
        }
    }
}
