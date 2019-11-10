using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class paddlecontrol : MonoBehaviour
{
    public float speed;
    public float direction;
    public float adjuster;
    public Transform upper;
    public Transform lower;
    public bool isAI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    

    // Update is called once per frame
    void Update()
    {
   
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + (speed * Time.deltaTime), transform.position.z);
            direction = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - (speed * Time.deltaTime), transform.position.z);
            direction = -1;
        }
        else
        {
            direction = 0;
        };
        if (transform.position.y > upper.position.y)
        {
            transform.position = new Vector3(transform.position.x, upper.position.y, transform.position.z);
        } 
        else if(transform.position.y < lower.position.y)
        {
            transform.position = new Vector3(transform.position.x, lower.position.y, transform.position.z);
        }
        

    }
    void OnCollisionExit2D(Collision2D other)
    {
        other.rigidbody.velocity = new Vector2(other.rigidbody.velocity.x*1.1f, other.rigidbody.velocity.y + direction*adjuster);
    }
}
