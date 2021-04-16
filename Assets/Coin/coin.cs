using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class coin : MonoBehaviour
{
    public static int score = 0;
    public Text text;
    public static int lives = 1;
    public Text livesText;

    private void Start()
    {
        text.text = "score " + score.ToString();
        livesText.text = "Lives " + lives;
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            score = score + 10;
            text.text = "score " + score.ToString();
        }

        if (other.gameObject.CompareTag("Ogre"))
        {
            lives = lives - 1;
            livesText.text = "Lives " + lives;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //if (lives == 0)
                
        }

    }
}
