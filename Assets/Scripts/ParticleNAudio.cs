using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class ParticleNAudio : MonoBehaviour
{
    public GameObject player;
public AudioSource source;    
public ParticleSystem effect;

    

void Start()
    {
        source = GetComponent<AudioSource>();
         
    }

    void OnTriggerEnter(Collider other)
    {
        source.Play();
        effect.Play();
    }

}