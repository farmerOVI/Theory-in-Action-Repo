using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{
    public void StartPlay()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }   
}
