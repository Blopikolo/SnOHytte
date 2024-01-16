using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingScripty : MonoBehaviour
{
    //public Animator animator;
    public float runspeed;
    public float jumpSpeed;

    float vertical;
    float horizontal;
    public Rigidbody2D rb;
    public bool facingRight;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerRun();
        FlipCheck();
        Jump();
    }

    void PlayerRun()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horizontal * runspeed, 0);
        //animator.SetFloat("Speed", Mathf.Abs(horizontal));
    }
    void Jump()
    {
        vertical = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector3(horizontal * runspeed, vertical * jumpSpeed, 0);
    }
    void FlipCheck()
    {
        if (horizontal < 0 && !facingRight)
        {
            Flip();
        }
        else if (horizontal > 0 && facingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
