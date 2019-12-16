using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacdots : MonoBehaviour
{


    //Level level; // a copy/instance of the Level class
    //GameStatus gameStatus;

    void Start()
    {
       // level = FindObjectOfType<Level>();
        /* instead of dragging the Level object to the level variable, the 
         * FindObjectOfType method will assign the variable on its own at runtime.
         */

       // gameStatus = FindObjectOfType<GameStatus>();

        
       // level.CountBreakableBlocks();
        /* Since this Block script is found in all of our blocks, each and every
             * block, will run this script separately. If we have 84 blocks, the Start()
             * method will be executed 84 times and thus, the breakableBlock variable
             * will be incremented 84 times as well.
             */
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //gameStatus.AddScore();
      //  FindObjectOfType<GameStatus>().AddScore();
      //  level.BlockDestroyed();
        Destroy(gameObject); 
    }

}
