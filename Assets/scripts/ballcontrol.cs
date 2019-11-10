using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcontrol : MonoBehaviour
{
    public float startForce;
    private Rigidbody2D myrigidbody;
    public GameObject paddle1;
    public GameObject paddle2;
    public gamemanger xx;
   
    // Start is called before the first frame update
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
        myrigidbody.velocity = new Vector2(startForce, startForce);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "goalzone")
        {
           if(transform.position.x < 0)
            {
                transform.position = paddle1.transform.position + new Vector3(2f,0,0);
                myrigidbody.velocity = new Vector2(startForce, startForce);
                xx.updatescore(2);
            }
           else
            {
                transform.position = paddle2.transform.position + new Vector3(-1f, 0, 0);
                myrigidbody.velocity = new Vector2(-startForce, -startForce);
                xx.updatescore(1);
            }

        }
    }
}
