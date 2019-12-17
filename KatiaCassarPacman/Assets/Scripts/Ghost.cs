using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{

    [SerializeField] AudioClip pacmanDiesSound;
    [SerializeField] float ghostXaxis;
    [SerializeField] float ghostYaxis;
    
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
            col.gameObject.transform.position= new Vector3 (ghostXaxis, ghostYaxis, 0);
            FindObjectOfType<GameStatus>().LiveDestroyed();
            
            AudioSource.PlayClipAtPoint(pacmanDiesSound, Camera.main.transform.position);
        }
    }

}

