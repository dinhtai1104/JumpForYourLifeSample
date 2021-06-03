using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDisapear : Platform
{
    private float timeD = 3;
    private bool zero = true;
    public override void Start()
    {
        base.Start();
    }

    public override void Update()
    {
        base.Update();
        Color c = spriteRenderer.color;
        float a = c.a;
        if (zero) {
            a = Mathf.Lerp(a, 0, timeD * Time.deltaTime);
            if (a < 0.05f) {
                zero = false;
            }
        } else {
            a = Mathf.Lerp(a, 1, timeD * Time.deltaTime);
            if (1- a < 0.05f) {
                zero = true;
            }
        }
        c.a = a;
        spriteRenderer.color = c;
    }
}
