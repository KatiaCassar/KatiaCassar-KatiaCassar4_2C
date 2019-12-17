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
        if(tag == "dots"){
            level.CountDots();
        }  
    }

    private void OnTriggerEnter2D(Collider2D col) 
    {

        if(col.gameObject.tag == "pacman"){
            FindObjectOfType<GameStatus>().AddScore();
            level.DotDestroyed();
            Destroy(gameObject);
            
        }
    }
}

