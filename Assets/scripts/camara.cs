using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    // Start is called before the first frame update
     public GameObject player;

    void Start()
    {
         player = GameObject.Find("player");

    }

    // Update is called once per frame
    void Update()
    {
         transform.position = new Vector3(player.transform.position.x -7, player.transform.position.y, player.transform.position.z );

    }
}
