using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static Spawner Instance;
    public Transform startPos;
    public Platform[] prefabs;
    public GameObject current;
    public int number = 5;

    public float offset;
    // Start is called before the first frame update
    void Start()
    {



        
        Instance = this;
        Vector3 lastPos = startPos.position;
        for (int i = 0; i < number; i++) {
            Vector3 pos = lastPos;
            pos.x = Random.Range(-3, 3);    
            if (i != 0)
                pos += Vector3.down * offset;
            current = Instantiate(prefabs[Random.Range(0, prefabs.Length)], pos, Quaternion.identity).gameObject;
            lastPos = pos;
        }
    }

    public void InstiateNewGround() {
        Vector3 pos = current.transform.position;
        pos.x = Random.Range(-3, 3);
        pos += Vector3.down * offset;
        current = Instantiate(prefabs[Random.Range(0, prefabs.Length)] , pos, Quaternion.identity).gameObject;
    }
}
