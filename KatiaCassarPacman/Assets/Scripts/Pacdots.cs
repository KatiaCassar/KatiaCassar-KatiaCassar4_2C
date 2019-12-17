using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacdots : MonoBehaviour
{


    Level level; // a copy/instance of the Level class
    GameStatus gameStatus;

    void Start()
    {
        level = FindObjectOfType<Level>();

        gameStatus = FindObjectOfType<GameStatus>();
        
        level.CountDots();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameStatus.AddScore();
        FindObjectOfType<GameStatus>().AddScore();
        level.DotDestroyed();

        if(tag == "pacman")
        {
            Destroy(gameObject);
            level.DotDestroyed();
        }
    }

}

