using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 2;
  
  

    void Start()
    {
        //HealthSlider.instance.getSlider(MaxHealth);
    }
    public void DealDamage(float damage)
    {
        health -= damage;

       // HealthSlider.instance.getSlider(health);

        if (health <= 0)
        {
            Destroy(gameObject);
            BallSpawar.instance.M_DEAD();
        }
    }
}
