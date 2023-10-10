using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_2 : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    public bool groundedPlayer;
    public float gravityValue = -9.81f;
    public float playerSpeed = 2.0f;
    public float horizontal = 1f;

    // Start is called before the first frame update
    void Start()
    {
          controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
                if(GameManager.activado == false) return;

        Vector3 promedio = new Vector3(0,0,0);
        
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {   
            gravityValue = -9.81f;
            playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(0, 0, horizontal*-3);
        controller.Move(move * Time.deltaTime * playerSpeed);

        playerVelocity.y += gravityValue * Time.deltaTime;
        promedio.y = playerVelocity.y + (playerVelocity.y + gravityValue * Time.deltaTime) ;
        
        controller.Move(promedio * Time.deltaTime);
    }

    public void OnControllerColliderHit(ControllerColliderHit hit) {
        Debug.Log("Colosiono");
        if(hit.gameObject.name != "enemigo"){
            horizontal = horizontal*1;
        }
    }
    }

