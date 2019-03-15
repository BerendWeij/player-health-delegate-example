using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int _health = 100;

    public Action<int> HealthChanged;

    public void TakeDamage(int damage)
    {
        _health -= damage;

        if (HealthChanged != null)
        {
            HealthChanged(_health);            
        }
    }
}