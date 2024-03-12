using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float zoomedOutFOV = 40f;
    [SerializeField] float zoomedInFOV = 20f;

    bool zoomedInToggle = false;

    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(zoomedInToggle == false)
            {
                fpsCamera.fieldOfView = zoomedInFOV;
                zoomedInToggle = true;
            }
            else
            {
                fpsCamera.fieldOfView = zoomedOutFOV;
                zoomedInToggle = false;
            }
            
        }


    }

}
