using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BallModel
{
    public BallModel(int health) => Health = health;

    public int Health { get; private set; }

    public event Action HealthChanged;

    public void OnCollideWithBox()
    {
        Health--;
        HealthChanged?.Invoke();
    }
}
