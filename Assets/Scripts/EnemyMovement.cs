using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : ExtendedBehaviour
{
    [Header("Components")]
    private Rigidbody rb;
    private Animator animator;

    [Header("Physics")]
    [Tooltip("Enemy Eggy walk speed")]
    [Range(0, 10)]
    public float walkSpeed = 5;
    

    // Internal variables
    private bool isMoving = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponentInChildren<Rigidbody>();
        animator = this.GetComponentInChildren<Animator>();
        animator.SetTrigger("walk");
    }

    void Update()
    {
        
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
            isMoving = false;
            animator.SetTrigger("death");

            GameplayManager.Instance.DestroyEnemy(this.gameObject);
            
        }
    }
}