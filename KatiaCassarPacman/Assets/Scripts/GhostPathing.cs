using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostPathing : MonoBehaviour
{
    [SerializeField] List<Transform> waypoints;  //to create list in the inspector
    [SerializeField] float moveSpeed = 2f;
    int waypointIndex = 0; //keep track of current waypints that the enemy need to move towards

    // Start is called before the first frame update
    void Start()
    {
        transform.position = waypoints[waypointIndex].transform.position;
        //set the enemy position to the first waypoint when the enemy loads
    }

    // Update is called once per frame
    void Update()
    {
        if (waypointIndex < waypoints.Count)
        {
            //Since we have waypoints still to travel on, we will move the
            //enemy from one co-ordinate to another
            var targetPosition = waypoints[waypointIndex].transform.position;
            targetPosition.z = 0f;
            var movementThisFrame = moveSpeed * Time.deltaTime; //frame rate independent

            transform.position = Vector2.MoveTowards(transform.position, targetPosition, movementThisFrame);
            /* The MoveTowards method returns different coordinates from one
             * frame to another to move the current object to the target
             * position at different intervals.
             */

            if (transform.position == targetPosition)
            {
                waypointIndex++; //go to the next waypoint (set new targetr)
            }
        }
        else
        {
            waypointIndex = 2;
        
            //Destroy(gameObject);
            /*GameObject with an uppercase G is the class which describes the
             * data a game object can have, and the methods it can execute. The
             * gameObject with a lowercase g is the current game object to which
             * this script is attached to. In this case, its's one of the enemies.
             */
        }

    }
}
