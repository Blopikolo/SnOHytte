using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Sign : MonoBehaviour
{

    public bool boksskjekk;
   
    [SerializeField] Text pickUpText;

    void Start()
    {
        pickUpText.gameObject.SetActive(false);
        boksskjekk = false;
    }

    // Update is called once per frame 
    void Update()
    {

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
