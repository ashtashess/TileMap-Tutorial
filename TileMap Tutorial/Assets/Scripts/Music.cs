using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioClip MusicClip;

    public AudioClip MusicClip2;

    public AudioSource MusicSource;

    // Start is called before the first frame update
    void Start()
    {
        MusicSource.clip = MusicClip;
        MusicSource.Play();

    }
  
       
 

// Update is called once per frame
void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            MusicSource.Stop();   
    }

}
