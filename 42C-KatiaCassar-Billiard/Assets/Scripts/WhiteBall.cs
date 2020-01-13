using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBall : MonoBehaviour
{
    int ranX;
    int ranY;
    
    ColouredBall colouredball;
    
    // Start is called before the first frame update
    void Start()
    {
    
        colouredball = FindObjectOfType<ColouredBall>();
        ranX = Random.Range(-1, 2);
        ranY = Random.Range(15, 21);
    }

    // Update is called once per frame
    void Update()
    {
        //left click pressed
        if (Input.GetMouseButtonDown(0))
        {
            //shoot the Ball
            colouredball.GetComponent<Rigidbody2D>().velocity = new Vector2(ranX, ranY);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D col){
        colouredball.DestroyBallWhenHitsHole(col, gameObject);
    }
    
}
