using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public static int score = 0;

    [SerializeField] public Text ScoreText;
    [SerializeField] private AudioSource _collectAudioSource;


    private void Start()
    {
        ScoreText.text = "Score: " + score;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag($"Gem_1"))
        {
            Destroy(col.gameObject);
            _collectAudioSource.Play();
            score++;
            ScoreText.text = "Score: " + score;
        }
        else if (col.gameObject.CompareTag($"Gem_5"))
        {
            Destroy(col.gameObject);
            _collectAudioSource.Play();
            score += 5;
            ScoreText.text = "Score: " + score;
        }
    }
}
