using UnityEngine;
using UnityEngine.SceneManagement;
public class PictureFrame : MonoBehaviour
{

public GameObject player;


 void OnTriggerEnter(Collider other)
 {
     SceneManager.LoadScene(1);
     player.SetActive(false);
 }

}
