using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTopScript : MonoBehaviour
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
        BallScript.yspeed = -BallScript.yspeed;
        BallScript.collflag = true;
    }
}
