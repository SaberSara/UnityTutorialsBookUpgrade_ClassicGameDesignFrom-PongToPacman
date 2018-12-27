using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//Added is needed for the neww UI System (important ti to imports! before to use UI the new systems!!!!! !).

public class Scoring : MonoBehaviour
{
    //Attributs
    static public int scorep1;
    static public int scorep2;
    //the new UI Text to call
    public Text P1Text;
    public Text P2Text;

    // Start is called before the first frame update
    void Start()
    {
        scorep1 = 0;
        scorep2 = 0;
        //Initialize the new UI objects Texts
        P1Text.text = "Player 1:  " + scorep1;
        P2Text.text = "Player 2: " + scorep2;
    }

    // Update is called once per frame
    void Update()
    {
        P1Text.text = "Player 1:  " + scorep1;
        P2Text.text = "Player 2: " + scorep2;
    }


    //Gettuing replace for old GUI system by the new UI system from Unity 4.6
    /// <note>
    /// Here is the old code 
    /// void OnGUI()
    ///{
    ///    GUI.Box(Rect(10, 10, 90, 30), "Player 1: " + scorep1);
    ///    GUI.Box(Rect(Screen.width - 100, 10, 90, 30),
    ///    "Player 2: " + scorep2);
    ///}
    /// 
    /// </notey>

}
