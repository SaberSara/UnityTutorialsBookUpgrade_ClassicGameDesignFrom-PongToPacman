using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript: MonoBehaviour
{
    void Start()
    {
        Screen.lockCursor = true;
    }

    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-20 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(20 * Time.deltaTime, 0, 0);
        }
        var h = 30.0f * Time.deltaTime * Input.GetAxis("Mouse X");
        transform.Translate(h, 0, 0);
    }
    void OnTriggerEnter(Collider other)
    {
        BallScript.yspeed = -BallScript.yspeed;

            
            if (other.GetComponent<Collider>().gameObject.transform.position.x >gameObject.transform.position.x)
            {
                BallScript.xspeed = Mathf.Abs(BallScript.xspeed);
            } else {
                BallScript.xspeed = -Mathf.Abs(BallScript.xspeed);
            }
            BallScript.collflag = true;
    }

}
