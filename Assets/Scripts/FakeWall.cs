using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeWall : MonoBehaviour
{
    [SerializeField] private AudioSource _wallAudioSource;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            _wallAudioSource.Play();
            Destroy(gameObject);
        }
    }
}
