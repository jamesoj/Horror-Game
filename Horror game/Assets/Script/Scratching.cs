using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scratching : MonoBehaviour
{

    private AudioSource myAudioSource;
    private int Count = 0;
    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player" && Count < 1)
        {
            myAudioSource.Play();
            Count++;

        }
    }
}
