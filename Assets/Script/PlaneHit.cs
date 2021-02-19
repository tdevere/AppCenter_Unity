using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneHit : MonoBehaviour
{
    bool ObjectHit;
    public Transform targetObject;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("PlaneHit");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //When the Primitive collides with the walls, it will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("PlaneHit_OnTriggerEnter");
    }
}
