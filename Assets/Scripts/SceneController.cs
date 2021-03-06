﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private GameController gameController;

    private void Awake()
    {
        // Get instance of Game Controller
        gameController = GameObject.FindGameObjectWithTag("GameCtrl").GetComponent<GameController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If player entered the switch scene trigger
        if(collision.CompareTag("Player"))
        {
            gameController.lastLoadedScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(gameObject.tag);
        }
    }
}
