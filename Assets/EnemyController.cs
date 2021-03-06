﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int maxHealth = 10;
    int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if(currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy died!");
        //play die animation
        //animator.SetBool("IsDead", true);

        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
