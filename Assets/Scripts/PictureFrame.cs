using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(AudioSource))]
public class PictureFrame : MonoBehaviour
{

public GameObject player;
public AudioSource source;
public Animator transition;
public float transitionTime = 2f;
    
    void Start()
    {
        source = GetComponent<AudioSource>();
    }
    

 void OnTriggerEnter(Collider other)
 {
    LoadNextLevel();
 }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(1);
        player.SetActive(false);
    }

    IEnumerator LoadLevel(int levelIndex)
    {
       source.Play();
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(levelIndex);
        
    }

}
