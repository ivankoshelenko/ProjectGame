using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 1f;

    public Rigidbody2D rb;
    public Animator animator;
    public float horizontalDir = 0f;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        Vector2 theScale = transform.localScale;

        if (!DialogueManager.GetInstance().dialogueIsPlaying)
        {
            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Speed", movement.sqrMagnitude);
            if (Input.GetAxisRaw("Horizontal") == -1 && theScale.x != -1)
                theScale.x = -1;
            if (Input.GetAxisRaw("Horizontal") != -1 && theScale.x == -1)
                theScale.x = 1;

            transform.localScale = theScale;
        }
        else
        {
            animator.SetFloat("Horizontal", 0);
            animator.SetFloat("Vertical", 0);
            animator.SetFloat("Speed", 0);
        }
        if(ComputerTrigger.deskTopActive)
        {
            animator.SetFloat("Horizontal", 0);
            animator.SetFloat("Vertical", 0);
            animator.SetFloat("Speed", 0);
        }
    }

    void FixedUpdate()
    {
        if (DialogueManager.GetInstance().dialogueIsPlaying || ComputerTrigger.deskTopActive || VirusComputerTrigger.deskTopActive)
            moveSpeed = 0;
        else
            moveSpeed = 1;
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);     
    }
}
