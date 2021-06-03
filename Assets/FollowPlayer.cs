using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    
    public GameObject player;
    public float speed;
    public bool canFollow = false;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!canFollow || GameManager.Instance.isEnd) return;
        Vector3 pos = transform.position;
        pos = Vector3.Lerp(pos, player.transform.position + offset, speed * Time.deltaTime);
        pos.x= 0;
        pos.z = -10;
        transform.position = pos;
    }
}
