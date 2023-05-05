using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTrap : MonoBehaviour
{
    private Animator _animator;
    private static readonly int Fire = Animator.StringToHash("Fire");
    private static readonly int NotFire = Animator.StringToHash("NotFire");

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void ItsATrap()
    {
        gameObject.tag = "Trap";
    }

    public void ItsNotATrap()
    {
        Invoke(gameObject.tag = "Untagged", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
