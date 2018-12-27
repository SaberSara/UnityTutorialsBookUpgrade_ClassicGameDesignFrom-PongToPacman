using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBrickScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (var y = 0; y < 8; y++)
        {
            for (var x = 0; x < 15; x++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = new Vector3(x * 2f - 14f, y - 1f, 0f);
                cube.transform.localScale = new Vector3(1.9f, 0.9f, 1f);
                cube.AddComponent<BrickScript>();
                cube.GetComponent<Collider>().isTrigger = true;
                if (y < 2)
                    cube.GetComponent<Renderer>().material.color =  Color.yellow;
                else if (y < 4)  
                    cube.GetComponent<Renderer>().material.color =  Color.cyan;
                else if (y < 6)
                    cube.GetComponent<Renderer>().material.color =  Color.blue;
                else
                    cube.GetComponent<Renderer>().material.color =  Color.red;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
