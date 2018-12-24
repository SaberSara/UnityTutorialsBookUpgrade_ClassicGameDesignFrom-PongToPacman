using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRelaunch : MonoBehaviour
{
    

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.position.x > 0)
            Scoring.scorep1++;
        else
            Scoring.scorep2++;
        

       //Added parts (Not workings good, uncomment! !
        //Reseting the force and direction pushed into for the ball in each relaunch with a ranged randoom directions and a random added forcess for x and y ( like for the Ball script instantiation tn the beginnings of the game start mode)
        //other.GetComponent<Rigidbody>().AddForce(0, 0, 0);
        //other.GetComponent<Rigidbody>().AddForce(Random.Range(6, 8), Random.Range(-4, -3), 0);


        other.transform.position = new Vector3(0, 0, 0);

    }
}

