using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventAnimation : MonoBehaviour
{
    public void Active() {
        transform.parent.gameObject.SetActive(false);
    }
}
