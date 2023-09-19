using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mimovimiento : MonoBehaviour
{

    CharacterController controller;
    
    public bool isGrounded;
    public Vector3 gravity = new Vector3(0f,-9.8f,0f);
    public Vector3 vo= new Vector3(0f,0f,0f);
    public Vector3 vf= new Vector3(0f,0f,0f);
    public Vector3 vp= new Vector3(0f,0f,0f);
    public bool saltar= false;
    // Start is called before the first frame update
    void Start()
    {
      controller = this.GetComponent<CharacterController>();
      gravity = gravity/8;
    }

    // Update is called once per frame
    void Update()
    {  
      //se saca la velocidad promedio
        vp= (vo+vf)/2;
        controller.Move(vp * Time.deltaTime);
        
      //  
        isGrounded= controller.isGrounded;
        if(!isGrounded){//se comprueba si esta en el aire
          vf= vo+gravity*Time.deltaTime; // calculamos la velocidad final
          vo = vo + gravity; //sumando gravedad
        }
        // si esta en suelo
        else
        {
          vf = new Vector3(0f, 0f, 0f); //
          vp = new Vector3(0f, 0f, 0f); //
        }
           
        if(saltar && vf.y <=0){ // si estaba en suelo al presionar espacio
          vo= vo + new Vector3(0f,30f,0f);
          saltar = false; //cuando el objeto deja de saltar
        } 

        if(Input.GetKey(KeyCode.Space)){
          saltar = controller.isGrounded; //comprobar si está en el suelo
        }
    }
}
