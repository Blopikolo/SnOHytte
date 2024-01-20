using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class skjekkescript : MonoBehaviour
{

    public bool boksskjekk;

    // Start is called before the first frame update
    void Start()
    {
        boksskjekk = false;
    }

    // Update is called once per frame 
    void Update()
    {
        if (boksskjekk == true && Input.GetButtonDown("Fire1"))
        {
            //da skjer det ting
            Debug.Log("Amongus");
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
        
        boksskjekk = true;
    
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        boksskjekk = false;
    }

    


   



}
