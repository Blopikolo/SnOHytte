using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSelect : MonoBehaviour
{
    public string LevelName;


    public void LoadLevel2()
    {
        SceneManager.LoadScene(LevelName);

    }
}