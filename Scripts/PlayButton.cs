using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    // Load next scene
    public void PlayScene()
    {
        SceneManager.LoadScene(1);       
    }
}
