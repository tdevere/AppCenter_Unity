using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.AppCenter.Unity.Analytics;

public class SphereHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("SphereHit");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //When the Primitive collides with the walls, it will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("SphereHit_OnTriggerEnter");
        Analytics.TrackEvent("SphereHit_OnTriggerEnter");
    }
}
