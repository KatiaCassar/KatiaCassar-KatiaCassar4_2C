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

    private void OnTriggerEnter2D(Collider2D col)
    {

        if(col.gameObject.tag == "pacman")
        {
            col.gameObject.transform.position= new Vector3 (14,14,0);
            FindObjectOfType<GameStatus>().LiveDestroyed();
            
            GetComponent<AudioSource>().PlayOneShot(pacmanDiesSound);
        }
    }

}

