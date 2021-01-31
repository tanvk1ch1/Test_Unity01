using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereManager2 : MonoBehaviour
{
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    private void Update()
    {
        // 力
        rb.AddForce(new Vector3(1,0,0));
    }
    
    // ColliderのisTriggerにチェックを入れる
}
