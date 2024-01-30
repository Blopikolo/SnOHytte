using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NPC : MonoBehaviour
{
    public GameObject dialougePanel;
    public Text dialougeText;
    public string[] dialouge;
    private int index;

    public GameObject contButton;
    public float wordSpeed;
    public bool playerIsClose;
    
    void Update()
    {

        
        

    }


    public void zeroText()
    {
        dialougeText.text = "";
        index = 0;
        dialougePanel.SetActive(false);
    }


    IEnumerator Typing()
    {

        foreach (char letter in dialouge[index].ToCharArray())
        {
            dialougeText.text += letter;
            yield return new WaitForSeconds(wordSpeed);

        }
        if (dialougeText.text == dialouge[index])
        {
            StartCoroutine (Ventlitt());
        }
    }

    public void NextLine()
    {
        

        contButton.SetActive(false);


        if (index < dialouge.Length - 1)
        {

            index++;
            dialougeText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            zeroText();
        }



    }

    IEnumerator Ventlitt()
    {
        yield return new WaitForSeconds(2);
        NextLine();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
           
            playerIsClose = true;
            if (dialougePanel.activeInHierarchy)
            {
                zeroText();
            }
            else
            {
                dialougePanel.SetActive(true);
                StartCoroutine(Typing());
            }
        }

    }



    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
            zeroText();
        }
    }

}

