using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Settings")]
    public float MoveSpeed;
    public float MaxSpeed;

    [Header("Other")]
    public Rigidbody2D rb;
    private Vector2 Movement;
    public SpriteRenderer sprite;
    public Animator animator;


    void Update() {
        Movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (Movement.x == 0){
            rb.velocity = new Vector2(0f, rb.velocity.y);
        }
        if (Movement.y == 0){
            rb.velocity = new Vector2(rb.velocity.x, 0f);
        }
        

        if(Movement.x == -1) {
            sprite.flipX = true;
        } else if (Movement.x == 1) {
            sprite.flipX = false;
        }

        animator.SetFloat("Horizontal", Movement.x);
        animator.SetFloat("Speed", Movement.sqrMagnitude); 
    }

    void FixedUpdate() {
        rb.AddForce((Movement * MoveSpeed), ForceMode2D.Impulse);
        rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, -MaxSpeed, MaxSpeed), Mathf.Clamp(rb.velocity.y, -MaxSpeed, MaxSpeed));
    }
}