using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    //Attributs

    public AudioClip BeepSound;


    //Methodss
    void Start()
    {
        GetComponent<Rigidbody>().freezeRotation = true;
        //called the courotine to replace the old statement for better performancess>>
        //>yield WaitForSeconds(3);
        ///////
        StartCoroutine(Delay());
        GetComponent<Rigidbody>().AddForce(Random.Range(6, 8), Random.Range(-4, -3), 0);
    }
    void Update()
    {
        transform.position= transform.position+new Vector3(0,0,transform.position.z*0);
    }

    void OnCollisionEnter(Collision other)
    {
        GetComponent<AudioSource>().PlayOneShot(BeepSound);
    }

    //Added the courotine to replace the "wait for seconds in the book, for betters performancess
    IEnumerator Delay()
    {

        yield return new WaitForSeconds(3);
    }
}
