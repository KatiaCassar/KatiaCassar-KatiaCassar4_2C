using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
   public void LoadLevel(string sceneName)
    {
        if (sceneName == "StartScene")
            FindObjectOfType<GameStatus>().ResetGame();

    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        /* To fetch the next scene, we need the current scene's index. The 
         * GetActiveScene() method returns all of the data about the current scene -
         * though, we only need to buildIndex value.
         */
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void Quit()
    {
         Application.Quit();
    }

}
