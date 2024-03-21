using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float restoreAngle = 73f;
    [SerializeField] float addIntensity = 1.5f;

    // FlashLightSystem flashLightSystem;

    void Start()
    {
        // FindObject를 안써주니 other.해서 하는게 더 효과적일듯
        // flashLightSystem = FindObjectOfType<FlashLightSystem>();
    }

    void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            // flashLightSystem.RestoreLgithAngle(restoreAngle);
            // flashLightSystem.RestoreLightIntensity(restoreIntensity);
            other.GetComponentInChildren<FlashLightSystem>().RestoreLightAngle(restoreAngle);
            other.GetComponentInChildren<FlashLightSystem>().AddLightIntensity(addIntensity);
            Destroy(gameObject);
        }
    }
}
