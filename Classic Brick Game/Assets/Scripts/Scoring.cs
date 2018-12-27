using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Added for UI

public class Scoring : MonoBehaviour
{
    //Attributes
    //Original boook Attributs
    static public int score;
    static public int lives;
    //Added attributs (mostly UI______)
    public GameObject scoreTxt;
    public GameObject livesTxt;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        lives = 3;


    }
    //Old UI System replaced in this script
    /*void OnGUI()
    {
        GUI.Box(Rect(10, 10, 90, 30), "Score: " + score);
        GUI.Box(Rect(Screen.width - 100, 10, 90, 30), "Lives: " + lives);
    }*/
    // Update is called once per frame
    void Update()
    {
        //added stateements
        scoreTxt.GetComponent<Text>().text = " Score: " +score;
        livesTxt.GetComponent<Text>().text = " Lives: " + lives;
    }

}
