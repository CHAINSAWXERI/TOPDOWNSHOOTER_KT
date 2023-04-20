using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plcontr : MonoBehaviour
{
    public Animator _animR;
    private float _speed = 5f;
    [SerializeField] Rigidbody2D rb;
    Vector2 move;

    // Update is called once per frame
    void FixedUpdate()
    {
        if ((Input.GetKey("up")) || (Input.GetKey("down")) || (Input.GetKey("right")) || (Input.GetKey("left")) || (Input.GetKey("w")) || (Input.GetKey("a")) || (Input.GetKey("s")) || (Input.GetKey("d")))  
        {
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");
        //_animR.SetBool("stop", false);

        rb.MovePosition(rb.position + move * _speed * Time.fixedDeltaTime);
        }
        /*else 
        {
            _animR.SetBool("stop", true);
        }
        */
    }
}

