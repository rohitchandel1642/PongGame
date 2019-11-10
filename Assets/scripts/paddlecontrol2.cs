using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class paddlecontrol2 : MonoBehaviour
{
    public float speed;
    public float direction;
    public float adjuster;
    public Transform upper;
    public Transform lower;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {

    }




    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, ball.transform.position.y * 0.8f, transform.position.y);

        

    }
    void OnCollisionExit2D(Collision2D other)
    {
        other.rigidbody.velocity = new Vector2(other.rigidbody.velocity.x * 1.1f, other.rigidbody.velocity.y + direction * adjuster);
    }
}
