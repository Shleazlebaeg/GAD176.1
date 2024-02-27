using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private int enemyType;

    private void Awake()
    {
        enemyType = Random.Range(1, 3);
        //1 = Melee
        //2 = Ranged

        //Enemy type 1.1 is Base Enemy (1x Health, 1x Damage, 1x Speed)
        //Enemy type 1.2 is Tank Enemy (2x Health, 1.5x Damage, 0.5x Speed)
        //Enemy type 1.3 is Fast Enemy (.75x Health, .5x Damage, 1.5x Speed)

        //Enemy type 2.1 is Base Ranged Enemy (.75x Health, 1x Damage, 1x Speed, 1x Range)
        //Enemy type 2.2 is Sniper Enemy (.75x Health, 3x Damage, 1x speed, 3x Range)
        //Enemy type 2.3 is SMG Enemy (.5x Health, .25x Damage, 1.25x Speed, .75x Range)
    }
    void Start()
    {
        
    }
}
