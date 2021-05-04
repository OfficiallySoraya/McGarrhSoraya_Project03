using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class WaHoo : MonoBehaviour

{
    public GameObject player;
    private AudioSource source;
    
    void Start()
    {
        source = GetComponent<AudioSource>();
    }
    
    void Update() 
    {
    
        if(Input.GetKeyDown(KeyCode.Space))
        {
            source.Play();
        }
    }

}