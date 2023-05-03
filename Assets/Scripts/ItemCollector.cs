using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public int score = 0;

    [SerializeField] public Text ScoreText;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag($"Gem_1"))
        {
            Destroy(col.gameObject);
            score++;
            ScoreText.text = "Score: " + score;
        }
        else if (col.gameObject.CompareTag($"Gem_5"))
        {
            Destroy(col.gameObject);
            score = score + 5;
            ScoreText.text = "Score: " + score;
        }
    }
}
