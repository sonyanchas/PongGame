using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKey(KeyCode.W))
                transform.Translate(0f, 0.05f, 0f);
                if (transform.position.y > 2.5f)
                {
                    transform.position = new Vector3(transform.position.x, 2.5f, 0f);
                }   
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(0f, -0.05f, 0f);
                    if (transform.position.y < -2.5f)
                    {
                    transform.position = new Vector3(transform.position.x, -2.5f, 0f);
                    }
            }
        }
    }
}
