using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class CarSex : MonoBehaviour
{

    public bool boksskjekk;
    public string LevelName;
    [SerializeField] Text pickUpText;
    [SerializeField] Text pickUpText2;

   
    public float yes;
    void Start()
    {
    
        pickUpText2.gameObject.SetActive(false);
        pickUpText.gameObject.SetActive(false);
        boksskjekk = false;
    }

    // Update is called once per frame 
    void Update()
    {
        if (boksskjekk == true && Input.GetKeyDown(KeyCode.E) && yes < 1)
        {
            //da skjer det ting
            pickUpText2.gameObject.SetActive(true);
            yes = yes + 1;
            pickUpText.gameObject.SetActive(false);

        }
        if (boksskjekk == true && Input.GetKeyDown(KeyCode.Y) && yes > 0)
        {
            //da skjer det ting
            pickUpText2.gameObject.SetActive(false);
          
           
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
