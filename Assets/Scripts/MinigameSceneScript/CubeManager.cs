using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// キーボードでオブジェクトを動かして、ゴールに着いたら終了するゲームにする
// ・キーボードからの入力
// ・移動方法：Transform, Rigidbody
// ・当たり判定：Collider, Trigger
// ・シーン切り替え：SceneManager


// ・Transformコンポーネントの解説
// ・位置、回転、倍率、Objectの親子関係
// ・GameObjectには、必ず必要になる


// Rigidbodyコンポーネントの解説
// ・物理演算を与えるもの
// ・重力、速度、力、移動量の制御、摩擦/慣性
// ・Use Gravity
// ・Mass：重さ
// ・Drag：粘り気のようなもの(水の中とかのイメージ)
// ・Andular Drag：回転、空気抵抗
// ・isKinematic：物理演算しない
// ・当たり判定の際に必要になる
public class CubeManager : MonoBehaviour
{
    // void Start()
    // {
    //     // コンポーネントの取得方法
    //     // Transform tf = GetComponent<Transform>();
    // }
    
    // 約0.02秒に1回実行される
    // transformの機能を軽く触れる
    // private void Update()
    // {
    //     // 移動
    //     // X軸方向に動きを与える
    //     // transform.position += new Vector3(0.1f, 0, 0);
    //     // 現在の位置から、X軸方向に対して動きを与える
    //     // transform.Translate(new Vector3(0.1f, 0,0));
    //     
    //     // 回転
    //     // transform.Rotate(new Vector3(0.1f,0,0));
    // }
    
    
    // ・Rigidbody解説
    // private Rigidbody rb;
    // void Start()
    // {
    //     rb = GetComponent<Rigidbody>();
    //     // x方向に速度1
    //     rb.velocity = new Vector3(1, 0, 0);
    // }
    //
    // private void Update()
    // {
    //     // 力
    //     rb.AddForce(new Vector3(1,0,0));
    // }
    // ・RigidbodyコンポーネントのConstraints
    // 位置を固定・制御ができる
}
