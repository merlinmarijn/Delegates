using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class Player : MonoBehaviour
{
    public int Health;
    public event Action<int> HealthChanged;
    public event Action Died;
    public event Action Pickup;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            TakeDamage(5);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            Heal(20);
        }
        if (Health <= 0)
        {
            Died();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Pickup();
        }
    }

    public void TakeDamage(int dmg)
    {
        Health -= dmg;
        HealthChanged(Health);
    }

    public void Heal(int healing)
    {
        Health += healing;
        HealthChanged(Health);
    }
}
