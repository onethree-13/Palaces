﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LethalTile : MonoBehaviour
{
    public int damage = 100;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug.Log(collision.name);
        Player player = collision.GetComponent<Player>();
        if (player != null)
        {
            player.Damage(damage);
        }
    }
}
