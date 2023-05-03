using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTrap : MonoBehaviour
{
    private Animator _animator;
    private static readonly int Fire = Animator.StringToHash("Fire");

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void StartFire()
    {
        _animator.SetTrigger(Fire);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
