﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody), typeof(Animator))]
public class PlayerMovement : ExtendedBehaviour
{
    [Header("Components")]
    private Rigidbody rb;
    private Animator animator;

    [Header("Physics")]
    [Tooltip("Eggy walk speed")]
    [Range(0, 10)]
    public float walkSpeed = 2;


    // Internal variables
    private bool isMoving = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponentInChildren<Rigidbody>();
        animator = this.GetComponentInChildren<Animator>();
    }

    void Update()
    {
#if UNITY_STANDALONE || UNITY_WEBPLAYER
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("walk");

            isMoving = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            animator.SetTrigger("idle");
            isMoving = false;
        }
//#elif UNITY_IOS || UNITY_ANDROID
//        if (Input.touchCount > 0)
//        {
//            animator.SetTrigger("walk");

//            isMoving = true;
//        }
//        if (Input.touchCount == 0)
//        {
//            animator.SetTrigger("idle");
//            isMoving = false;
//        }
#endif
        if (isMoving)
        {
            MoveForward();
        }
    }

    void MoveForward()
    {
        this.transform.Translate(0f, 0f, 1f * walkSpeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            Debug.Log("YOU LOSE! :(");
            animator.SetTrigger("death");
            Wait(2f, () => {
                SceneManager.LoadScene("MainScene");
            });
        }
    }
}
