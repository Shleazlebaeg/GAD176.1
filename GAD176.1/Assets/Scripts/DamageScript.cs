using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public PlayerStats playerStats;
    public HealthManager healthManager;
    void Start()
    {
        playerStats.playerHealth = playerStats.playerMaxHealth;
        healthManager.SetMaxHealth(playerStats.playerMaxHealth);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(20);
        }
    }
    void TakeDamage(int damage)
    {
        playerStats.playerHealth -= damage;
        healthManager.setHealth(playerStats.playerHealth);
    }
}
