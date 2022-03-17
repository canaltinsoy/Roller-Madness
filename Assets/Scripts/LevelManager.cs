using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{


    public void RestartLevel()
    {

        print("Level restarted");

        int currentScene = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(currentScene);
    }
    public void NextLevel()
    {
        print("Next level loaded");
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        int sceneIndex = SceneManager.sceneCountInBuildSettings - 1;

        if(nextSceneIndex <= sceneIndex)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        if(nextSceneIndex > sceneIndex)
        {
            SceneManager.LoadScene(0);
        }


    }


}
