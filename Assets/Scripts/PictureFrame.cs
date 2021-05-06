using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(AudioSource))]
public class PictureFrame : MonoBehaviour
{

public GameObject player;
public AudioSource source;
    
    void Start()
    {
        source = GetComponent<AudioSource>();
    }
    

 void OnTriggerEnter(Collider other)
 {
     SceneManager.LoadScene(1);
     player.SetActive(false);
     
 }


}
