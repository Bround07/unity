using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hongales : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2f;
    public bool moveleft;
    public bool born;
    private Animator animator;
    public BoxCollider bc;



    private GameObject Player;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("player");
        animator = GetComponentInChildren<Animator>();
        bc.enabled = false;
   
        born = true;

        
        StartCoroutine(Move());
   
    }

    // Update is called once per frame
    void Update()

    {

        if(born)
        {
            animator.SetBool("born", born);
            speed = 0;
        }
        if (moveleft)
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);

        }
        else
        {
            transform.Translate( 2 * Time.deltaTime * speed, 0, 0);
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag== "player")
        {
            Destroy(gameObject);
            move1.GrowUp = true;
        }
    }
    private IEnumerator Move()
    {
        yield return new WaitForSeconds(1f);
        born= false;
        animator.SetBool("born", born);
        bc.enabled = true;
        speed = 1.5f;
     
        StopAllCoroutines();
    }
}
