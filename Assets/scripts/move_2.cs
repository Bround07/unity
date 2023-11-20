using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
        //if(GameManager.activado == false) return;



        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            gravityValue = -9.81f;
            playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(0,0, horizontal);
        controller.Move(move * Time.deltaTime * playerSpeed);

        playerVelocity.y += gravityValue * Time.deltaTime;
      
        
       
    }

    public void OnControllerColliderHit(ControllerColliderHit hit) {
        if (hit.gameObject.tag != "isGround")
        {
            Debug.Log("colisiomo");

            horizontal = horizontal * -1;
        }
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "player")
        {
            float yOffset = 0.6f;
            if (transform.position.y + yOffset < collision.transform.position.y)
            {
                Destroy(gameObject);
            }
        }
    }
    }

