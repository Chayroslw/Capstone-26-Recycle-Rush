using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;

   
    private float moveSpeed;
    public float normalSpeed;
    public float speedWhenFreeze;
    float move;

    void Start()
    {
      animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        move = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(move, 0, 0) * Time.deltaTime * moveSpeed;

        animator.SetFloat("Speed", Mathf.Abs(move));

        if (!Mathf.Approximately(0, move))
        {
            transform.rotation = -move > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }

        if (Time.timeScale == 1.0)
        {
            moveSpeed = normalSpeed;
        }
        else if (Time.timeScale != 1.0)
        {
            moveSpeed = speedWhenFreeze;
        }
    }

    
}
