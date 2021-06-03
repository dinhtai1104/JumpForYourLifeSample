// using System.Collections;
// using System.Collections.Generic;
// using System.Linq;
// using UnityEngine;

// using System;
// public class PlatformType3 : Platform
// {
//     public Transform[] points;
//     private Vector2[] listPos;
//     public override void Start()
//     {
//         spriteRenderer.sprite = sprites[0];

//         listPos = new Vector2[points.Length];
//         // int[] ran = new int[];
//         System.Random random = new System.Random();
        
//         transform.position = new Vector2(-3.7f, transform.position.y);
//         for (int i = 0; i < points.Length; i++) {
//             listPos[i] = points[ran[i]].position;
//         }

//         float y = transform.position.y;
//         ran
//         ran = Enumerable.Range(0, listPos.Length)
//                         .OrderBy(c =>
//                         {
//                             return random.Next();
//                         })
//                         .ToArray();
        
//     }


//     private int index = 0;
//     // Update is called once per frame
//     public override void Update()
//     {
//         transform.position = Vector2.MoveTowards(transform.position,
//             listPos[index], speed * Time.deltaTime
//         );
//         if (Vector2.Distance(transform.position, listPos[index]) < 0.1f) {
//             index++;
//             if (index == 0 || index == listPos.Length)
//                 if (playerOnGround) {
//                     life--;
//                     spriteRenderer.sprite = sprites[1];
//                     if (life <= 0) {
//                         Debug.Log("DIE");
//                         player.parent = null;
//                         Spawner.Instance.InstiateNewGround();
//                         Destroy(gameObject);
//                     }
//                 }
//             index %= listPos.Length;

//         }
//     }
// }
