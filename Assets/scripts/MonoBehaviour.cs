using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class move2 : MonoBehaviour
{
  
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    public float playerSpeed = 2.0f;
    public float jumpHeight = 6.0f;
    private float gravityValue = -9.81f;
    public float velocidadcaidarapida;

    private AudioSource Sonidodesalto;
    // Start is called before the first frame update
    void Start()
    {
       controller = this.GetComponent<CharacterController>();
        Sonidodesalto = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
         if(GameManager.activado == false) return;
          groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            gravityValue= -9.81f; 
            playerVelocity.y = 0f;
            velocidadcaidarapida = 1;
        }

        Vector3 move = new Vector3(0, 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        // Changes the height position of the player..
        if (Input.GetButton("Jump") && groundedPlayer)
        {
           
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }
    if(Input.GetButtonUp("Jump")){
        velocidadcaidarapida=2;
        gravityValue=gravityValue*velocidadcaidarapida;
        Sonidodesalto.Play();

    }
        playerVelocity.y += gravityValue *velocidadcaidarapida* Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }
    
}
