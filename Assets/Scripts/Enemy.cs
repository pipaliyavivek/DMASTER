using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    [SerializeField] float damage = 50f;
    private void OnTriggerEnter(Collider other)
    {
        // Debug.Log("KILL Success");
        //Debug.Log(gameObject.name);
        var health = other.GetComponent<Health>();
        health.DealDamage(damage);
    }
}
