using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private Animator _animator;
    private bool _checkpointReached = false;
    private static readonly int Finish1 = Animator.StringToHash("Finish");

    // Start is called before the first frame update
    void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player" && !_checkpointReached)
        {
            _checkpointReached = true;
            _animator.SetTrigger(Finish1);
            Invoke("CompleteLevel", 2f);
        }
    }
    
    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
