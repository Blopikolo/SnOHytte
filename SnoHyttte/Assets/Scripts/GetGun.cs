using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GetGun : MonoBehaviour
{

    public bool boksskjekk;
    
    [SerializeField] Text pickUpText;
    public GameObject Bwall;
    public float keys;
    public GameObject Bwall2;
    public GameObject Bwall3;
    public GameObject Bwall4;

    void Start()
    {
        pickUpText.gameObject.SetActive(false);
        boksskjekk = false;
    }

    // Update is called once per frame 
    void Update()
    {
        if (boksskjekk == true && Input.GetKeyDown(KeyCode.E) && keys < 1)
        {
            keys = keys + 1;
            //da skjer det ting
            Bwall.gameObject.SetActive (false);
            boksskjekk = false;
            pickUpText.gameObject.SetActive(false);
            Bwall2.gameObject.SetActive(false);
            Bwall3.gameObject.SetActive(false);
            Bwall4.gameObject.SetActive(false);
            AudioManager.Play("gunget");
        }
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (keys < 1)
        {
            pickUpText.gameObject.SetActive(true);
            boksskjekk = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        boksskjekk = false;
        pickUpText.gameObject.SetActive(false);
    }
}


