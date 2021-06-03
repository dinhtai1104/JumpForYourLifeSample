using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;

    public int life = 2;
    public Sprite[] sprites;

    protected Transform player;
    protected bool playerOnGround = false;
    
    protected int direction = 1;

    public float speed;

    private Vector2 p1, p2;

    public GameObject canvas;
    public void SetPerfect() {
        canvas.SetActive(true);
    }

    public virtual void Start()
    {
        spriteRenderer.sprite = sprites[0];
        if (Random.value < 0.5f) {
            direction = -1;
        }
        p1 = transform.position;
        p1.x = -3.6f;
        p2 = transform.position;
        p2.x = 3.6f;
    }


    public virtual void Update()
    {
        if (GameManager.Instance.isEnd && GetComponent<Collider2D>().enabled) {
            GetComponent<Collider2D>().enabled = false;
            return;
        }
        transform.position = Vector2.MoveTowards(transform.position, direction == 1 ? p2 : p1, speed * Time.deltaTime);
        
        if (Vector2.Distance(transform.position, direction == 1 ? p2 : p1) < 0.03f) {
            direction *= -1;
            if (playerOnGround) {
                life--;
                spriteRenderer.sprite = sprites[1];
                if (life <= 0) {
                    Debug.Log("DIE");
                    player.parent = null;
                    Spawner.Instance.InstiateNewGround();
                    Destroy(gameObject);
                }
            }
        }
        
        if (transform.position.y - Camera.main.transform.position.y > 15) {
            Spawner.Instance.InstiateNewGround();
            Destroy(gameObject);
        }
    }

   

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        
        if (collisionInfo.gameObject.tag == "Player") {
            playerOnGround = true;
            collisionInfo.transform.parent = transform;
            player = collisionInfo.transform;
        } 
         
    }

    void OnCollisionExit2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Player") {
            collisionInfo.transform.parent = null;
            playerOnGround = false;
            GetComponent<Collider2D>().enabled = false;
        }
    }
}
