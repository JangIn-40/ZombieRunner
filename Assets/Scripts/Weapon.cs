using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera FPSCamera;
    [SerializeField] float range = 100f;
    [SerializeField] float damage = 30f;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(FPSCamera.transform.position, FPSCamera.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            //ToDo : 
            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
            if(target == null)  { return; }
            target.TakeDamage(damage);
        }
        else
        {
            return;
        }

        
    }
}
