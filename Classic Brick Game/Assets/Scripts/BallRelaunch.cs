using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//new screen management system


public class BallRelaunch : MonoBehaviour
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
        other.transform.position = new Vector3(0, -7, 0);
        BallScript.xspeed = 8.0f;
        BallScript.yspeed = -8.0f;
        BallScript.launchtimer = 1.0f;
        Scoring.lives--;
        if (Scoring.lives == 0)
        {
            //Application.LoadLevel("BrickTitleScene"); Deprecated statement
            //new statement for scenes 
            SceneManager.LoadScene("BrickTitleScene");
        }
    }
}
