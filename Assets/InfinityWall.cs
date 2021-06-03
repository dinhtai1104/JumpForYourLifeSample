using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinityWall : MonoBehaviour
{

    public SpriteRenderer[] spriteRenderers;
    private float offset;

    private int index = 0;
    private int length = 0;
    private Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
        length = spriteRenderers.Length;
        offset = spriteRenderers[0].bounds.size.y / 2;

    }

    // Update is called once per frame
    void Update()
    {
        if (camera.transform.position.y < spriteRenderers[(index + 1) % length].transform.position.y) {
            spriteRenderers[index].transform.position = spriteRenderers[(index+2)%length].transform.position + Vector3.down * 9.5f;
            index++;
            index %= length;
        }
    }
}
