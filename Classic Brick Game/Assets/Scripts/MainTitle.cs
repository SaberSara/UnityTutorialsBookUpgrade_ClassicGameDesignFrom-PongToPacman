using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//new screen management system

public class MainTitle : MonoBehaviour
{
    //Attributs
    //Old UI attributs
    //public Texture backgroundTexture;
   
    // Start is called before the first frame update
    void Start()
    {

    }
    //Old UI fonction

    /*void OnGUI()
    {
        GUI.DrawTexture(
        Rect(0, 0, Screen.width, Screen.height),
        backgroundTexture);

    }**/
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Debug.Log("A key or mouse click has been detected");
            //Application.LoadLevel("BrickScene"); Deprecated statement
            //new statement for scenes 
            SceneManager.LoadScene("BrickScene");
        }
    }
}


