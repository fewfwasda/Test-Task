using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Enemy : MonoBehaviour
{
    Animator animator;
    [SerializeField] private int health;
    [SerializeField] private int maxhealt = 10;
    [SerializeField] private HealthBar _healthBar;
    private void Awake()
    {
        _healthBar = GetComponentInChildren<HealthBar>();
        health = maxhealt;
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        _healthBar.UpdateHealthBar(health,maxhealt);
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        _healthBar.UpdateHealthBar(health,maxhealt);
        if (health <= 0)
        {
            animator.SetBool("Death", true);
            Destroy(GetComponent<Rigidbody>());
            Destroy(gameObject,2f);
        }
    }
}
