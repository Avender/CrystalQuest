using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PressurePlateFire : MonoBehaviour
{
    [SerializeField] private UnityEvent trigger;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Player")
        {
            trigger.Invoke();
        }
    }
}
