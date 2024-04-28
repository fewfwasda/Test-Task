using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletLive = 3f;

    private void Awake()
    {
        Destroy(gameObject, bulletLive);
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
        if (other.gameObject.TryGetComponent<Enemy>(out Enemy enemyComponent))
        {
            enemyComponent.TakeDamage(5);
        }
    }
}