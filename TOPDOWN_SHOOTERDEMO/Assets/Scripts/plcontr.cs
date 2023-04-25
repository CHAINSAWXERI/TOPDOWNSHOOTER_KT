using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plcontr : MonoBehaviour
{
    public float speed;
    [SerializeField] Animator animator;
    private Vector2 direction;
    [SerializeField] Rigidbody2D rb;

    void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() 
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", direction.x);
        animator.SetFloat("Vertical", direction.y);
        //animator.SetFloat("Speed", direction.sqrMagnitude);
        animator.SetTrigger("Move");
    }

    void FixedUpdate() 
    {
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
    }
}

