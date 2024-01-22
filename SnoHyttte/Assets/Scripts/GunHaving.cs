using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public float coins;
    
    public void GetMonei(float CoinWorth)
    {
      
        coins += CoinWorth;
    }
    void Update()
    {
    
    }
}
