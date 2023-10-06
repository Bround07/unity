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
        activado = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            Menu.SetActive(true);
            activado = false;
    }
    }

    public void activarui() {
        Menu.SetActive(true);
        MiCanvas.SetActive(false);
        GameManager.activado = true;
   
    }
}
