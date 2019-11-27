using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotSpawnerL2 : MonoBehaviour
{
    GameObject[] dot;
    GameObject randomDot;

    Vector2 DotPosition, startingPosition;
    //both of these variables are positions (x and y) so thier type is Vector 2


    void Start()
    {
        startingPosition = transform.position;
        LoadDotFromResources();
        GetRandomDot();
        SpawnDot();
    }

    void LoadDotFromResources()
    {
        dot = Resources.LoadAll<GameObject>("DotsL2");
        /* The Resources class is responsible for functionality related to loading
         * assets from the assets folder. To work we need to have a folder named
         * Resources and all assets to be loaded need to be placed inside this
         * folder. The type for prefabs is GameObject
         */

        DotPosition = transform.position;
    }

    void GetRandomDot()
    {
        int randomNumber = Random.Range(0, dot.Length); //random index from array

        randomDot = dot[randomNumber];
    }

    void SpawnDot()
    {
        Instantiate(randomDot, DotPosition, transform.rotation);
    }
}
