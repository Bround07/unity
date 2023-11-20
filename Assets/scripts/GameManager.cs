using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool activado = false;

    public float threshold;

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
        /* este if asgina con el boton escape al menu*/
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
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
  
}
