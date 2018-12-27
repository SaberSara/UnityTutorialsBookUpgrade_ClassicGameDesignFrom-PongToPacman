using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinshingTheGame : MonoBehaviour
{
    /// <AboutThisClass>
    /// This is an added class to conclude the game on a score of 12 by either p1 or p2!
    /// Check the Finished GAne GameObject in the hierarchy and the script attached to GameObject Score
    /// </AboutThisClass>




    //Attributs
    public GameObject FGObject;
    public GameObject BallObject;
    public Text FGText;

    //Methods
    // Start is called before the first frame update
    void Start()
    {
        FGObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Scoring.scorep1>=12) 
        {
            BallObject.SetActive(false);
            FGObject.SetActive(true);
            FGText.text = "Player 1 Won!";
        }
        else if(Scoring.scorep2 >= 12)
        {
            BallObject.SetActive(false);
            FGObject.SetActive(true);
            FGText.text = "Player 2 Won!";
        }

    }
}

//Thank you for reading