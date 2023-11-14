using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respaw : MonoBehaviour
{
    public float threshold;

    // Start is called before the first frame update
    private void FixedUpdate()
    {
        if(transform.position.y < threshold)
        {
            transform.position = new Vector3(-0.09f,0.5f, 0.8800006f);
        }
    }
}
