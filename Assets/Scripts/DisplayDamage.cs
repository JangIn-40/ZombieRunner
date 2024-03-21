using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayDamage : MonoBehaviour
{
    [SerializeField] Canvas hitCanvas;
    [SerializeField] float hitTime = 0.3f;

    void Start() 
    {
        hitCanvas.enabled = false;
    }

    public void ShowDamageImpact()
    {
        StartCoroutine(DisplayHit());
    }
    
    IEnumerator DisplayHit()
    {
        hitCanvas.enabled = true;
        yield return new WaitForSeconds(hitTime);
        hitCanvas.enabled = false;
    }

}
