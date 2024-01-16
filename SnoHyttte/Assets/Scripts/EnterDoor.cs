using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wiining : MonoBehaviour
{
    public string sound;
    public string LevelName;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //AudioManager.Play(sound);
        SceneManager.LoadScene(LevelName);
    }

}