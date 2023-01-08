using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed;
    public Rigidbody2D playerRB;
    public SpriteRenderer spriteRenderer;

    private Vector2 moveInput;
    private Animator myAnimator;

    bool isFacingRight = true;

    private void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        moveInput.Normalize();

        playerRB.velocity = moveInput * MoveSpeed;

        myAnimator.SetFloat("Speed", moveInput.magnitude);

        if (moveInput.x < 0 && isFacingRight || moveInput.x > 0 && !isFacingRight)
        {
            Flip();
        }

    }

    void Flip()
    {
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        isFacingRight = !isFacingRight;
    }

}