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

    public Direction PlayerDirection
    {
        get{
            return playerDirection;
        }
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

    }

    void MovePlayer()
    {
        float translate = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(translate, 0, 0);

        if(translate > 0)
        {
            playerDirection = Direction.RIGHT;

        }else if(translate < 0)
            {
            playerDirection = Direction.LEFT;
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
    }

    void OnCollisionExit2D()
    {
        isOnGround = false;
    }
}
