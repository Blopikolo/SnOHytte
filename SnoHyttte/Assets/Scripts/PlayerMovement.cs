using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public Animator animator;
    public float baseSpeed;
    public float moveSpeed;

    float vertical;
    float horizontal;
    public Rigidbody2D rb;
    public bool facingRight;


    // Start is called before the first frame update
    void Start()
    {
        baseSpeed = moveSpeed;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        PlayerRun();
        
        Jump();
    }

    void PlayerRun()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horizontal * moveSpeed, 0);
        //animator.SetFloat("Speed", Mathf.Abs(horizontal));
    }
    void Jump()
    {
        vertical = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector3(horizontal * moveSpeed, vertical * moveSpeed, 0);
    }

    public void UpdateSpeed(float newSpeed)
    {
        moveSpeed = newSpeed;
    }

    public void ResetSpeed()
    {
        moveSpeed = baseSpeed;
    }
}
