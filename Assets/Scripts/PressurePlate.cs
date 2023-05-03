using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    private Animator _animator;
    private Rigidbody2D _rigidbody;
    private static readonly int Step = Animator.StringToHash("Step");

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _rigidbody = GetComponentInChildren<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Player")
        {
            _animator.SetTrigger(Step);
            _rigidbody.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
