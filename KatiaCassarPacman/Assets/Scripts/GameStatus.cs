using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    [SerializeField] int currentScore;
    [SerializeField] int pointsPerPacDot = 1;
    [SerializeField] TextMeshProUGUI scoreText;

    /* Awake() is a Unity built in method which is executed before the object's components are intisialised (before the Start()
     * method us executed)
     * In this method we're going to make sure that we only have ONE instance of GameStatus and that this instance is never
     * destroyed between loading scenes
     */
    void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length; // returns the amount of copies of GameStatus currently in 
        // the hierarchy

        if (gameStatusCount > 1)
        {
            print("Destroyed");
            Destroy(gameObject); // if there are more than one GameSatuts', destroy the new one to ensure that we only have ONE
            //gamestatus per game
        }
        else
        {
            //Keep only THIS GameStatus
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        currentScore = 0;
        scoreText = FindObjectOfType<TextMeshProUGUI>();
        scoreText.text = currentScore.ToString();
        print("testScore");
    }

    public void AddScore() // to be called when a dot is destroyed
    {
        currentScore += pointsPerPacDot;
        FindObjectOfType<TextMeshProUGUI>().text = currentScore.ToString();
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }
}
