using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 当たり判定の解説
// ・必要なもの：Collider,Rigidbody)
// ・isTrigger
public class SphereManager : MonoBehaviour
{
    // ・Collider解説
    // ぶつかった際に実行される(条件：Collider,Rigidbodyが必要)
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("接触しました");
    }
    
    // 接触し始めた場合
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
    }
    
    // 接触し終えた場合
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
    }
}
