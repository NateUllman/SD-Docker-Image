using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TerrainSwitch : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("s"))
        {
            print("s key was pressed");
            //SceneManager.LoadScene("SampleScene");
            // If you want the current scene to disappear and the new scene to appear, then you should use "LoadSceneMode.Single" like: 
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        }
        if (Input.GetKeyDown("e"))
        {
            print("e key was pressed");
            SceneManager.LoadScene("Asteroide");
        }
        if (Input.GetKeyDown("a"))
        {
            print("a key was pressed");
            SceneManager.LoadScene("Asteroid");
        }
    }
}
