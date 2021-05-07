using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class ParticleNAudio : MonoBehaviour
{
    public GameObject player;
public AudioSource source;    
public ParticleSystem _psystem;

    

void Start()
    {
        source = GetComponent<AudioSource>();
         GetComponent<ParticleSystem>();
    }

    void OnTriggerEnter(Collider other)
    {
        source.Play();
        _psystem.Play();
    }

}