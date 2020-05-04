using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    public int levelToLoad;
    private SceneSwitcher sceneSwitcher;

    void Start()
    {
        sceneSwitcher = GameObject.Find("SceneSwitcher").GetComponent<SceneSwitcher>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            sceneSwitcher.LoadLevel(levelToLoad);
        }
    }
}
