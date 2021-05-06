using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScene : MonoBehaviour
{
void Start()
    {
        
        Cursor.visible = false;
    }

    void Update()
        {
            Cursor.lockState = CursorLockMode.Locked;
            

        }

}
