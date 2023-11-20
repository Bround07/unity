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
         transform.position = new Vector3(player.transform.position.x +13, player.transform.position.y+4, player.transform.position.z+3 );

    }
}
