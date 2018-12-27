using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    //
    //Attributs
    public AudioClip BeepSound;
    static public float launchtimer;
    static public float  xspeed;
    static public float yspeed;
    static public bool collflag;

    //Methods
    void Start()
        {
            launchtimer = 2.0f;
            xspeed = -8.0f;
            yspeed = -8.0f;
            collflag = true;
        }
    void Update()
        {
        transform.position=new Vector3(transform.position.x,transform.position.y,transform.position.z*0);
            launchtimer -= Time.deltaTime;
        if (launchtimer <= 0.0f)
            {
                transform.Translate(new Vector3(xspeed, yspeed, 0) * Time.deltaTime);
                launchtimer = 0.0f;
            }
        }
    void OnTriggerEnter( Collider other)
        {
            GetComponent<AudioSource>().PlayOneShot(BeepSound);
        }
}
