using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LoadScene : MonoBehaviour
{

    public bool boksskjekk;
    public string LevelName;
    [SerializeField] Text pickUpText;
   
    void Start()
    {
        pickUpText.gameObject.SetActive(false);
        boksskjekk = false;
    }

    // Update is called once per frame 
    void Update()
    {
        if (boksskjekk == true && Input.GetKeyDown(KeyCode.E))
        {
            AudioManager.Play("gunshoot");
            //da skjer det ting
            SceneManager.LoadScene(LevelName); ;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        pickUpText.gameObject.SetActive(true);
        boksskjekk = true;

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        boksskjekk = false;
        pickUpText.gameObject.SetActive(false);
    }








}
