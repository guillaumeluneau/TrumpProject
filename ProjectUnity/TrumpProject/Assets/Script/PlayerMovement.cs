﻿using UnityEngine;
using System.Collections;

public enum Direction { LEFT, RIGHT};
public class PlayerMovement : MonoBehaviour {
    public float speed = 5.0f;
    public bool isOnGround = false;
    public float jumpPower = 7.0f;

    private Transform _transform;
    private Rigidbody2D _rigidbody;
    private Direction playerDirection = Direction.RIGHT;
    private Animator m_Anim;
    private LayerMask m_WhatIsGround;

    public Direction PlayerDirection
    {
        get{
            return playerDirection;
        }
    }

    private void Awake()
    {
        m_Anim = GetComponent<Animator>();
    }



    // Use this for initialization
    void Start () {
        _transform = GetComponent(typeof (Transform)) as Transform;
        _rigidbody = GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;
    }
	
	// Update is called once per frame
	void Update () {
        MovePlayer();
        Jump();
        m_Anim.SetFloat("vSpeed", _rigidbody.velocity.y);
        Collider2D[] colliders = Physics2D.OverlapCircleAll(_transform.position, 0.2f, m_WhatIsGround);
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject != gameObject)
                isOnGround = true;
        }
    }

    void MovePlayer()
    {
        float translate = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(translate, 0, 0);

        m_Anim.SetFloat("Speed", Mathf.Abs(speed));

        if (translate > 0 && playerDirection == Direction.LEFT)
        {
            playerDirection = Direction.RIGHT;
            Flip();

        }
        else if(translate < 0 && playerDirection == Direction.RIGHT)
            {
            playerDirection = Direction.LEFT;
            Flip();
        }
        else
        {

        }
    }

    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space)&& isOnGround)
        {
            _rigidbody.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D()
    {
        isOnGround = true;
        m_Anim.SetBool("Ground", isOnGround);
    }

    void OnCollisionExit2D()
    {
        isOnGround = false;
    }

    private void Flip()
    {

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
