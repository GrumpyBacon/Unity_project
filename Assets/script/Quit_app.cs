using UnityEngine;
using System.Collections;

public class Quit_app : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("q"))
          //  Debug.Log("Gane Quit");
        Application.Quit();
        
    }
}
