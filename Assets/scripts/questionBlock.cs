using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class questionBlock : MonoBehaviour


{

    public GameObject block;
    public GameObject coin;
    public GameObject Hongales;
    public Transform objectspawn;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("player") && collision.contacts[0].normal.y > 0.5f)
        {

            if (Hongales != null)
            {
                Instantiate(Hongales, objectspawn.position, objectspawn.rotation);
            }

                else {
                        Instantiate(coin, objectspawn.position, objectspawn.rotation);

                        Instantiate(block, objectspawn.position, objectspawn.rotation);

                        Destroy(gameObject);
                    }
        }
    }
}
