using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class temporizador : MonoBehaviour
{
    
    public float seconds;
    private int minutes;
    public TextMeshProUGUI conteo;

   
    public void reset()
    {
        seconds = 0;
        minutes= 0;

    }

    void Start()
    {
        StartCoroutine(Runtimer());
    }


    void Update()
    {
        conteo.text=Mathf.FloorToInt(seconds).ToString("D6");
 
    }
    

      IEnumerator Runtimer()

{
   
    while(true){
        seconds++;
        yield return new WaitForSeconds(1);
    }
}
}


    

