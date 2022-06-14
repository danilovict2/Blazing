﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health3 : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount = 100;

    private void Update()
    {
        if (healthAmount <= 0)
        {

        }

        if (Input.GetMouseButtonUp(0))
        {
            TakeDamage(30);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            Healing(10);
        }
    }

    public void TakeDamage(float Damage)
    {
        healthAmount -= Damage;
        healthBar.fillAmount = healthAmount / 100;
    }

    public void Healing(float healPoints)
    {
        healthAmount += healPoints;
        healthAmount = Mathf.Clamp(healthAmount, 0, 100);

        healthBar.fillAmount = healthAmount / 100;
    }

}