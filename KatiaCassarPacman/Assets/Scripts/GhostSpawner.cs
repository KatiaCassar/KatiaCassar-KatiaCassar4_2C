using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpawner : MonoBehaviour
{ 
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] int maximumNumberOfEnemies;
    [SerializeField] float spawnTime = 5f;
    [SerializeField] GameObject firstSpawnPoint; //types used for prefabs is
    //GameObject and here we are going to link to the first wayPoint prefab

    int currentNumberOfEnemies = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*A co-routine is a special method used to suspend execution (pause) and
     * return back to where it left off after either a number of seconds or
     * after a condition is met 
     */
    IEnumerator SpawnEnemies()
    {
        while (currentNumberOfEnemies < maximumNumberOfEnemies)
        {
            GameObject enemyClone = Instantiate(enemyPrefab, firstSpawnPoint.transform.position, Quaternion.identity);
            /* We are cloning an enemy by using the enemyPrefab and placinf it
             * on the first waypoint. For this Instantiate overloaded method,
             * we need to pass the rotation and Quateration. Identity means
             * zero rotation
             */

            currentNumberOfEnemies++;

            yield return new WaitForSeconds(spawnTime);
            /*  Thie yield keyword is used to indicate where the process should
             *  return back after the execution was suspended/paused
             */
        }
    }
}
