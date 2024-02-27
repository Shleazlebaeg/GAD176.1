using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public PlayerStats playerStats;

    public Slider slider;
    public Image healthBarFill;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    public void setHealth(int health)
    {
        slider.value = health;
    }

    public void Update()
    {
        if (slider.value <= 100 && slider.value >= 51)
        {
            healthBarFill.color = Color.green;
        }
        if (slider.value <= 50 && slider.value >= 21)
        {
            healthBarFill.color = Color.yellow;
        }
        if (slider.value <= 20)
        {
            healthBarFill.color = Color.red;
        }
    }
}
