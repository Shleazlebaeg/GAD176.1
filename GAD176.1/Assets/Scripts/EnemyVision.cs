using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVision : MonoBehaviour
{
    public BaseEnemyStats enemyStats;
    //public EnemyManager enemyManager;
    public PlayerMovement playerMovement;

    public Transform enemy;
    public Transform player;

    public Transform enemyVision;


    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        enemyVision.transform.localScale = enemyStats.enemyRange;
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            enemy.transform.position = Vector2.MoveTowards(enemy.transform.position, player.transform.position, enemyStats.enemySpeed);
        }
   }
}
