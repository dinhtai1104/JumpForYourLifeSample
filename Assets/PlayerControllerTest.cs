using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTest : MonoBehaviour
{

    public Animator animator;
   
    private bool isGrounded = false;

    // Update is called once per frame
    void Update()
    {
        UpdateAnimation();
    }

    private void UpdateAnimation() {
        if (Input.GetMouseButtonDown(0) && isGrounded) {
            Debug.Log("Jump");
            isGrounded = false;
            animator.SetBool("isGrounded", false);
        }
        if (Input.GetMouseButtonUp(0) && !isGrounded) {
            Debug.Log("Idle");
            isGrounded = true;
            animator.SetBool("isGrounded", true);
        }
    }
}
