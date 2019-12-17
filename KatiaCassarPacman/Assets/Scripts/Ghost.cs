using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{

    [SerializeField] AudioClip pacmanDiesSound;
    Level level; // a copy/instance of the Level class
    GameStatus gameStatus;

    void Start()
    {
        level = FindObjectOfType<Level>();

        gameStatus = FindObjectOfType<GameStatus>();
        
    }

    private void OnCollision2D(Collider2D collision)
    {
        gameStatus.DecreaseLive();
        FindObjectOfType<GameStatus>().DecreaseLive();
        level.LiveDestroyed();

        if(tag == "pacman")
        {
            Destroy(gameObject);
            level.LiveDestroyed();
            
            GetComponent<AudioSource>().PlayOneShot(pacmanDiesSound);
        }
    }

}

