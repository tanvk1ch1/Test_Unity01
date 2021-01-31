using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

// 目標：キーボード入力を行って、consoleにログを表示させる
// ・方向キーの入力
// ・ボタンの入力
public class MinigameScript : MonoBehaviour
{
    private void Update()
    {
        // // キーボードの横方向の入力を-1〜1で受け付ける
        // float x = Input.GetAxis("Horizontal");
        // Debug.Log("x:" + x);
        // // キーボードの縦方向の入力を-1〜1で受け付ける
        // float z = Input.GetAxis("Vertical");
        // Debug.Log("z:" + z);
        
        // おまけ：rawは-1,0,1の整数値しか取らない場合に使う
        // float raxX = Input.GetAxisRaw("Horizontal");
        // Debug.Log("rawX:" + raxX);
        // // キーボードの縦方向の入力を-1〜1で受け付ける
        // float rawZ = Input.GetAxisRaw("Vertical");
        // Debug.Log("rawZ:" + rawZ);
        
        // 下のように書くと、consoleにログが常に出続けることが無くなる
        // float rawX = Input.GetAxisRaw("Horizontal");
        // if (rawX > 0)
        // {
        //     Debug.Log("rawX:" + rawX);
        // }
        // // キーボードの縦方向の入力を-1〜1で受け付ける
        // float rawZ = Input.GetAxisRaw("Vertical");
        // if (rawZ < 0)
        // {
        //     Debug.Log("rawZ:" + rawZ);
        // }
        
        
        // ・ボタン入力
        // if (Input.GetButton("Jump"))
        // {
        //     Debug.Log("Space(Jump)を押している");
        // }
        // キーを押し込んだ時だけ入力を受け付ける
        // if (Input.GetButtonDown("Jump"))
        // {
        //     Debug.Log("Space(Jump)を押した");
        // }
        // Button以外にも、Keyでキー指定もできる
        // if (Input.GetKeyDown(KeyCode.J))
        // {
        //     Debug.Log("Jキーを押した");
        // }
    }
}
