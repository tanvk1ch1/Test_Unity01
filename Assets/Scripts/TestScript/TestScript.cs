﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 未経験者教育用に、C#プログラムの基礎テキスト(？)の作成
public class TestScript : MonoBehaviour
{
    // 列挙型
    // 制限を作って使用するもの
    // enum DIRECTION
    // {
    //     STOP,
    //     RIGHT,
    //     LEFT,
    //     TOP,
    //     BOTTOM
    // }
    // [SerializeField]
    // private DIRECTION direction;
    // enum PLAYER_TYPE
    // {
    //     PLAYER,
    //     ENEMY
    // }
    // [SerializeField]
    // private PLAYER_TYPE playerType;
    
    void Start()
    {
        // 変数宣言、if、四則演算子、演算子、比較演算子、論理演算子は基本すぎるのでここでは省略
        
        // while
        // int mp = 10;
        // while (mp > 0)
        // {
        //     mp--;
        //     Debug.Log("Mp消費"); // 10回繰り返す
        // }
        
        
        // for
        // for (int i = 0; i < 5; i++)
        // {
        //     Debug.Log("魔法攻撃" + i); // 5回繰り返す
        // }
        
        
        // break/continue
        // for (int i = 0; i < 5; i++)
        // {
        //     if (i == 3)
        //     {
        //         // break; // 処理を3で止める
        //         continue; // 3で処理を飛ばす
        //     }
        //     Debug.Log("魔法攻撃" + i);
        // }
        
        
        // 列挙型
        // direction = DIRECTION.RIGHT;
        // Debug.Log((int)direction);
        // Debug.Log(direction);
        // 分かりにくい書き方の例
        // int dir = 0; // 0を上、1を下、2を右、3を左
        // switch (dir)
        // {
        //     case 0:
        //         Debug.Log("上に移動");
        //         break;
        //     case 1:
        //         Debug.Log("下に移動");
        //         break;
        //     case 2:
        //         Debug.Log("右に移動");
        //         break;
        //     case 3:
        //         Debug.Log("左に移動");
        //         break;
        //     default:
        //         break;
        // }
        // 少しわかりやすい例
        // switch (direction)
        // {
        //     case DIRECTION.STOP:
        //         Debug.Log("停止");
        //         break;
        //     case DIRECTION.RIGHT:
        //         Debug.Log("右に移動");
        //         break;
        //     case DIRECTION.LEFT:
        //         Debug.Log("左に移動");
        //         break;
        //     case DIRECTION.TOP:
        //         Debug.Log("上に移動");
        //         break;
        //     case DIRECTION.BOTTOM:
        //         Debug.Log("下に移動");
        //         break;
        // }
        
        
        // // 配列の宣言方法
        // int[] a = {10, 2, -2, -34};
        // int[] b = new int[] {10, 2, -2, -34};
        // int[] c = new int[4] {10, 2, -2, -34};
        // // 配列の取得
        // int x = a[0];
        // Debug.Log(x);
        // Debug.Log(a[1]);
        // Debug.Log(b[2]);
        // Debug.Log(c[3]);
        // // 配列の変更
        // a[1] = 7;
        // Debug.Log(a[1]);
        // // 長さ
        // Debug.Log(a.Length);
        // string[] names = {"あいうえお", "かきくけこ", "さしすせそ"};
        // for (int i = 0; i < 3; i++)
        // {
        //     Debug.Log(names[i]);
        // }
        // // 変更のたびにforのupperを変えるのは面倒
        // string[] names2 = {"あいうえお", "かきくけこ", "さしすせそ", "たちつてと"};
        // for (int i = 0; i < names2.Length; i++)
        // {
        //     Debug.Log(names2[i]);
        // }
        
        
        // List型
        // List<int> numberList = new List<int>() {1, 2, 3, 4};
        // List<int> nList = new List<int>() {5,6,7,8};
        // List<string> nameList = new List<string>() {"aaa", "bbb", "ccc"};
        // Debug.Log(numberList[1]);
        // nList[0] = 10;
        // Debug.Log(nList[0]);
        // // 配列のLengthではなく、ListはCount
        // for (int i = 0; i < numberList.Count; i++)
        // {
        //     Debug.Log(numberList[i]);
        // }
        // numberList.Add(5); // 5を追加
        // for (int i = 0; i < numberList.Count; i++)
        // {
        //     Debug.Log(numberList[i]);
        // }
        // nList.RemoveAt(3); // 8が消える
        // for (int i = 0; i < nList.Count; i++)
        // {
        //     Debug.Log(nList[i]);
        // }
        // nameList.Remove(nameList[2]); // 値を削除
        // for (int i = 0; i < nameList.Count; i++)
        // {
        //     Debug.Log(nameList[i]);
        // }
        
        
        // 関数の定義
        // void SayName1()
        // {
        //     Debug.Log("あいうえお");
        // }
        // // 関数の呼び出し
        // SayName1();
        // // 引数あり関数
        // void SayName2(string userName)
        // {
        //     Debug.Log("カキク:" + userName);
        // }
        // SayName2("ケコ"); // ケコが引数で、userNameに入る
        // void SayName3(string userName, int age)
        // {
        //     Debug.Log(userName + "さん、" + age + "歳");
        // }
        // SayName3("太郎", 26);
        
        // 返り値ありの関数
        // string型を返すので、string+関数名
        // string userName = GetSayName1();
        // string GetSayName1()
        // {
        //     return "次郎";
        // }
        // Debug.Log(userName);
        // string userName2 = GetSayName2("三郎", 20);
        // string GetSayName2(string name, int age)
        // {
        //     return "京都" + name + ":" + age + "歳";
        // }
        // Debug.Log(userName2);
        
        
        
    }
}
