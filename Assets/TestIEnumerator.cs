using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestIEnumerator : MonoBehaviour
{
    // Singleton
    public static TestIEnumerator Instance;
    public LineRenderer lineRenderer;

    void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
    /*
        Player 1 Danh => StartCoroutine Player 1 => Switch Player 2 => Dung Coroutine player 1
        Player 2 Danh => StartCoroutine Player 2 => Switch Player 1 => Dung Coroutine player 2



    */
    private IEnumerator test() { // Update song song
        while(true) {
            Debug.Log("Hello World");

            yield return new WaitForSeconds(1);
            //
        }
    }
    private bool isDrag = false;
    void Update()
    {
        // Handle input
        // Call 1 lan/1 frame

        if (Input.GetMouseButton(0)) {
            isDrag = true;

        } 
        if (Input.GetMouseButtonUp(0)) {
            isDrag = false;
        }
    }

    void FixedUpdate()
    {
        // Time.fixedDeltaTime
    }

    void LateUpdate()
    {
        if (!isDrag) return; 
        Vector3 pos = Input.mousePosition;
        pos = Camera.main.ScreenToWorldPoint(pos);
        pos.z = 0;

        lineRenderer.SetPosition(1, pos);
    }
    
    void OnEnable()
    {
        
    }
    void OnDisable()
    {
        
    }

    void OnDestroy()
    {
        
    }


}
