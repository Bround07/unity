using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool activado = false;

    [SerializeField] private GameObject MiCanvas; 

    [SerializeField] private GameObject Menu; 
    // Start is called before the first frame update
    void Start()
    {
        Menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activarui() {
        Menu.SetActive(true);
        MiCanvas.SetActive(false);
        GameManager.activado = true;
   
    }
}
