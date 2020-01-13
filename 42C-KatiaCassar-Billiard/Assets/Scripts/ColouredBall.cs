using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColouredBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    private void OnCollisionEnter2D(Collision2D col){
        DestroyBallWhenHitsHole(col, gameObject);
    }
    
    public void DestroyBallWhenHitsHole(Collision2D collision, GameObject ball){

        if(gameObject.tag == "hole")
        {
            if(ball.tag == "ColouredBall"){
                Destroy(gameObject);
            }
            
            else if (ball.tag == "WhiteBall"){
                Destroy(gameObject);
            }
        }
    }
}
