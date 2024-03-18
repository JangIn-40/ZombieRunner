using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float playerHealth = 100f;

    DeathHandler deathHandler;

    void Start()
    {
        deathHandler = GetComponent<DeathHandler>();
    }

    public void ReducePlayerHealth(float damage)
    {
        playerHealth -= damage;
        if(playerHealth <= 0)
        {
            deathHandler.HandleDeath();
        }
    }



}
