using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemyStats : MonoBehaviour
{
    public float enemyHealth = 100f;
    public float enemySpeed = .2f;
    public float enemyDamage = 20f;
    public Vector2 enemyRange = new Vector2(7.5f, 7.5f);
    public bool enemyRanged;

}
