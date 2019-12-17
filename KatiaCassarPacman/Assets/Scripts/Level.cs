using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] int pacdots; //counter for all blocks in the scene
    [SerializeField] int lives;
    /* This variable is placed in the Level script and not in the Block script since otherwise, each block
     * would have a separate breakableBlocks variable and all would have just the value one.
     * The Level script is executed only once for the whole scene while the Block script is executed once
     * for each block.
     */
     

    LevelLoader levelLoader; //copy/instance of the LevelLoader class

    void Start()
    {
        levelLoader = FindObjectOfType<LevelLoader>();
    }

    public void CountDots()
    {
        pacdots++; 
    }

    /* This method will be called everytime a block is destroyed and it will check if there are any
     * breakable blocks left in the scene.
     */
    public void DotDestroyed()
    {
        pacdots--; 

        if (pacdots <= 0)
        {
            //load next scene
            levelLoader.LoadNextScene();
        }
    }
    
    public void LiveDestroyed(){
        lives--;
        if (lives <= 0){
            SceneManager.LoadScene("LoseScene");
        }
    }
}
