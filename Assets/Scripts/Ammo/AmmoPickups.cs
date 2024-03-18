using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickups : MonoBehaviour
{
    [SerializeField] int ammoAmount = 3;
    [SerializeField] AmmoType ammoType;

    Ammo ammo;

    void Start()
    {
        ammo = FindObjectOfType<Ammo>();
    }

    void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            ammo.AddCurrentAmmo(ammoType, ammoAmount);
            Destroy(gameObject);
        }
    }
}
