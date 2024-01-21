using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elgvelger : MonoBehaviour
{
    
    public GameObject Elg1;
    public GameObject Elg2;
    public GameObject Elg3; 
    public GameObject Elg4;
    private int RadNum;


    // Start is called before the first frame update
    void Start()
    {
        Elg1.gameObject.SetActive(false);
        Elg2.gameObject.SetActive(false);
        Elg3.gameObject.SetActive(false);
        Elg4.gameObject.SetActive(false);
        RadNum = Random.Range(1, 4);
        Debug.Log(RadNum + "Elg Nummer");

        if(RadNum == 1)
        {
            Elg1.gameObject.SetActive(true);
        }

        if (RadNum == 2)
        {
            Elg2.gameObject.SetActive(true);
        }

        if (RadNum == 3)
        {
            Elg3.gameObject.SetActive(true);
        }

        if (RadNum == 4)
        {
            Elg4.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
