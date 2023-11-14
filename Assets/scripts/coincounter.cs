using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coincounter : MonoBehaviour
{
    public static coincounter instance;

    public TMP_Text cointext;
    public int currentCoin = 0;


    private void Awake()
    {
        instance = this; 
    }
    // Start is called before the first frame update
    void Start()
    {
        cointext.text = "x: " + currentCoin.ToString();
    }

  public void IncreaseCoins(int v)
    {
        currentCoin += v;
        cointext.text = "x:" + currentCoin.ToString();
    }
}
