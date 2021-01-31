using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// 超入門ミニゲーム制作：キーボード操作でオブジェクトに接触したらクリア
// 所要時間：小手調べなので5分
// Collider,Rigidbodyが必要
public class PlayerManager : MonoBehaviour
{
    void Start()
    {
        
    }
    
    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        
        // 横と縦
        transform.position += new Vector3(x, 0, z) * 0.1f;
    }
    
    // あえてここにぶつかったときの処理を書く
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("クリア！");
        SceneManager.LoadScene("MinigameScene2");
    }
}
