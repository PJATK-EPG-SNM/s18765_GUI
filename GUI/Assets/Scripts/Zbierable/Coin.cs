using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour{

    private ScoreManager scoreManager;
    private bool collected;
    public int points = 1;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        collected = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !collected)
        {
            collected = true;
            scoreManager.IncrementScore(points);
            Invoke("CollectCoin", 0.5f);
        }
    }

    private void CollectCoin()
    {
        Destroy(gameObject);
    }
}
