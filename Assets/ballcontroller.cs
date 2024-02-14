using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Random.Range(-10f, 10f), Random.Range(-10f,10f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource audioSource; //declare a AudioSource reference variable
        audioSource = GetComponent<AudioSource>(); // get a reference to our audio source
        audioSource.Play();
    }
}
