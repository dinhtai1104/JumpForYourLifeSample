using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    private Animator animator;

    public Transform groundCheck;
    public bool isGrounded = false;
    public Rigidbody2D rigidbody2D;
    public float forceJump;
    public LayerMask groundLayer;

    public FollowPlayer camera;


    private SpriteRenderer spriteRenderer;
    public DATABASE data;

    // Start is called before the first frame update
    void Start()
    {

        spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.sprite = data.characters[PlayerPrefs.GetInt("Data")].charater;

        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (GameManager.Instance.isEnd) return;
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject()) {
            if (isGrounded) {
                // Check player on ground
                isGrounded = false;
                camera.canFollow = false;
                rigidbody2D.AddForce(Vector3.up * forceJump, ForceMode2D.Impulse);
            }
        }
        CheckGround();
    }

    private void CheckGround() {
        // if (Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer)) {
        //     isGrounded = true;
        // } else {
        //     isGrounded = false;
        // }
        animator.SetBool("isGrounded", isGrounded);
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Perfect") {
            Platform platform = other.transform.GetComponentInParent<Platform>();
            platform.SetPerfect();
        }
        if (other.tag == "Platform") {
            camera.canFollow = true;
            isGrounded = true;
            GameManager.Instance.SCORE++;
        } else if (other.tag == "BotDie") {
            Debug.Log("Game Over");
            GameManager.Instance.SetGameOver();
        }
    }

   
}
