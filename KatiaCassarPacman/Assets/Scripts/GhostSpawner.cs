using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpawner : MonoBehaviour
{ 
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject firstSpawnPoint; //types used for prefabs is
    //GameObject and here we are going to link to the first wayPoint prefab



    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemies();
    }

    /*A co-routine is a special method used to suspend execution (pause) and
     * return back to where it left off after either a number of seconds or
     * after a condition is met 
     */
    public void SpawnEnemies()
    {
            GameObject enemyClone = Instantiate(enemyPrefab, firstSpawnPoint.transform.position, Quaternion.identity);
            /* We are cloning an enemy by using the enemyPrefab and placinf it
             * on the first waypoint. For this Instantiate overloaded method,
             * we need to pass the rotation and Quateration. Identity means
             * zero rotation
             */
    }
}
