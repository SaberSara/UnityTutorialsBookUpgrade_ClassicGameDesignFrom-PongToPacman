using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1 : MonoBehaviour
{
	private void Update()
	{
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 20 * Time.deltaTime, 0);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -20 * Time.deltaTime, 0);
        }
	}
}
