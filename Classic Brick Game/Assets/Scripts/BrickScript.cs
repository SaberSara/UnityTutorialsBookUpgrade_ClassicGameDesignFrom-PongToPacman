using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (BallScript.collflag == true)
{
            BallScript.yspeed = -BallScript.yspeed;
            BallScript.collflag = false;
            Destroy(gameObject);
            Scoring.score += 10;

        }

    }
}