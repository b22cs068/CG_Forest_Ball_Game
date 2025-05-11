using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene(1); // Replace '1' with the index or name of the scene you want to load
    }
}
