﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 未経験者教育用に、問題スクリプトを作成
public class QuestionScript : MonoBehaviour
{
    // 問1
    // TODO:Q1_10~1000をwhileで表示せよ
    // int count = 10;
    // void Start()
    // {
    //     Debug.Log(count);
    //     count = count + 1;
    //     Debug.Log(count);
    //     count = count + 1;
    //     Debug.Log(count);
    //     count = count + 1;
    //     Debug.Log(count);
    //     count = count + 1;
    //     Debug.Log(count);
    //     count = count + 1;
    // }
    
    
    // TODO:1000から2000までの数字を表示し続けて、273の倍数があったらそこで処理を止めたい
    // int n = 1000;
    // void Start()
    // {
    //     while (n <= 2000)
    //     {
    //         Debug.Log(n);
    //         n++;
    //     }
    // }
    
    
    // TODO:「10から1000までの数字を表示」はfor文で
    // int count = 10;
    // void Start()
    // {
    //     while (count <= 1000) {
    //         Debug.Log(count);
    //         count = count + 1;
    //     }
    // }
    
    
    // TODO:「1000から2000までの数字を表示し続けて、273の倍数があったらそこで処理止めたい」をfor文で
    // void Start()
    // {
    //     for (int i=10; i<=1000; i++)
    //     {
    //         Debug.Log(i);
    //     }
    // }
    
    
    // TODO:「0から99までの数字を表示し、3の倍数は表示しない」をfor文で
    // private void Start()
    // {
    //     
    // }
    
    
    // TODO:switch文で書いたコードを列挙型で書いてみる
    // enum Direction
    // {
    //     UP,
    //     DOWN,
    //     RIGHT,
    //     LEFT
    // }
    // private int direction = 0;
    // void Start()
    // {
    //     switch (direction)
    //     {
    //         case 0:
    //             Debug.Log("上");
    //             break;
    //         case 1:
    //             Debug.Log("下");
    //             break;
    //         case 2:
    //             Debug.Log("左");
    //             break;
    //         case 3:
    //             Debug.Log("右");
    //             break;
    //         default:
    //             Debug.Log("その他");
    //             break;
    //     }
    // }
    
    
    // 問2
    // TODO:「10,20,30」の値を持つ配列を作る時のおかしなところはどこか？
    // int[] numbers = 10;
    // int[] numbers = 20;
    // int[] numbers = 30;
    // void Start()
    // {
    // }
    
    
    // TODO:配列の値取得の方法について
    // int[] numbers = { 10, 20, 30 };
    // void Start()
    // {
    //     int x = numbers[1];
    //     Debug.Log(x);
    //     int y = numbers[2];
    //     Debug.Log(y);
    //     int z = numbers[3];
    //     Debug.Log(z);
    // }
    
    
    // TODO:配列の値変更の方法について
    // int[] numbers = { 10, 20, 30 };
    // void Start()
    // {
    //     numbers = 1;
    //     Debug.Log(numbers[1]);
    // }
    
    
    // TODO:配列とfor文の組み合わせについて：値をfor文ですべて表示する
    // int[] numbers = { 10, 20, 30, 1,2,33,-33,44,556,54345,3434 };
    // void Start()
    // {
    //     Debug.Log(numbers[0]);
    //     Debug.Log(numbers[1]);
    //     Debug.Log(numbers[2]);
    //     Debug.Log(numbers[3]);
    //     // ...と続く場合にどうするか？
    // }
    
    
    // TODO:配列とfor文の組み合わせ2：配列が変わってもfor文を変えない方法
    // int[] numbers = { 10, 20, 30, 1, 2, 33, -33, 44, 556, 54345, 3434, -1, 222, 333 };
    // void Start()
    // {
    //     // 3434までしか表示されない
    //     for (int i =0 ; i<11; i++)
    //     {
    //         Debug.Log(numbers[i]);
    //     }
    // }
    
    
    // TODO:配列とfor文の組み合わせ3:配列の値の合計を調べる方法
    // int sum = 0;
    // int[] numbers = { 10, 20, 30, 1, 2, 33, -33, 44, 556, 54345, 3434, -1, 222, 333 };
    // void Start()
    // {
    //     sum += numbers[0];
    //     sum += numbers[1];
    //     sum += numbers[2];
    //     // ここをfor文で計算したい場合にどうするか？
    // }
    
    
    // TODO:List型の宣言方法について
    // string nameList = { "aaa", "bbb", "ccc"};
    // void Start()
    // {
    // }
    
    
    // TODO:List型の値の取得と変更方法
    // List<string> nameList = new List<string>{ "あああ", "いいい", "ううう"};
    // void Start()
    // {
    //     // コンソールに0番目を表示したい
    //     // 0番目の値を"えええ"に変更したい
    //     // コンソールに0番目を表示したい
    // }
    
    
    // TODO:List型とfor文の組み合わせについて：値を全て表示
    // List<string> nameList = new List<string>{ "かかか", "ききき", "くくく"};
    // void Start()
    // {
    //     // for文を使って以下と同じログを表示したい
    //     Debug.Log(nameList[0]);
    //     Debug.Log(nameList[1]);
    //     Debug.Log(nameList[2]);
    // }
    
    
    // TODO:List型の値の追加
    // List<string> nameList = new List<string>{ "さささ", "ししし", "すすす"};
    // void Start()
    // {
    //     // nameListに"せせせ"を追加したい：Addってのを使う
    //     // 追加したあと、全ての値をログに表示して追加されたのを確認したい
    // }
    
    
    // TODO:List型の値の削除
    // List<string> nameList = new List<string>{ "たたた", "ちちち", "つつつ"};
    // void Start()
    // {
    //     // nameListの"ちちち"を消したい
    // }
    
    
    // 問3
    // TODO:関数の定義の方法
    // void Start()
    // {
    // }
    // FirstFunc1
    // {
    // }
    // FirstFunc2()
    // {
    // }
    
    
    // TODO:関数の実行
    // void Start()
    // {
    // }
    // void Sample()
    // {
    //     Debug.Log("京都と表示");
    // }
    
    
    // TODO:変数のスコープ(範囲)：xとyの和を表示
    // void Start()
    // {
    //     int x = 10;
    //     int y = 2;
    //     Sample();
    // }
    // void Sample()
    // {
    //     Debug.Log(x+y);
    // }
    
    
    // TODO:引数ありの関数：引数を使って一つの関数にする、Sample()内での処理は1行だけ
    // int x = 10;
    // int y = 2;
    // int z = -3;
    // void Start()
    // {
    //     Sample1();
    //     Sample2();
    //     Sample3();
    // }
    // void Sample1()
    // {
    //     Debug.Log(x + y);
    // }
    // void Sample2()
    // {
    //     Debug.Log(y + z);
    // }
    // void Sample3()
    // {
    //     Debug.Log(z + x);
    // }
    
    
    // TODO:引数の応用
    //x=0,y>0 => 上
    // x=0,y<0 => 下
    // x>0,y=0 => 右
    // x<0,y=0 => 左
    // x=0,y=0 => 停止
    // それ以外 => その他
    // と表示させる関数を作る
    // void Start()
    // {
    //     Move(0, 19);  // 上
    //     Move(0, -1);  // 下
    //     Move(20, 0);  // 右
    //     Move(-20, 0); // 左
    //     Move(0, 0);   // 停止
    //     Move(-1, -1);   // その他
    // }
    // void Move(int x, int y)
    // {
    //     if (x == 0 && y > 0)
    //     {
    //         Debug.Log("上");
    //     }
    //     Debug.Log("停止");
    // }
    
    
    // TODO:返り値ありの関数：targetはhogeダメージを受けた！、の後に合計いくらダメージを受けたのかを表示する
    // void Start()
    // {
    //     int sum = 0;
    //     Damage("スライム", 100);
    //     Damage("ドラキー", 20);
    //     // sum = 100+20; //100とか20が変わるたびに修正しないといけないのでミスが起こりやすい
    //     Debug.Log("合計" + sum + "のダメージ！");
    // }
    // void Damage(string target, int damage)
    // {
    //     Debug.Log(target + "は" + damage + "ダメージをうけた！");
    // }
    
    
    // TODO:引数あり関数と配列の組み合わせ：配列の中身を確認できる関数を作成する
    // ヒント：関数内でforを1回使う
    // int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    // int[] numbers2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    // void Start()
    // {
    //     for (int i = 0; i < numbers1.Length; i++)
    //     {
    //         Debug.Log(numbers1[i]);
    //     }
    //     for (int i = 0; i < numbers2.Length; i++)
    //     {
    //         Debug.Log(numbers2[i]);
    //     }
    // }
    // void ShowArrayValueLog()
    // {
    // }
    
    
    // TODO:平均の計算：2つの配列の平均を求める関数を作る
    // int[] numbers1 = { 2, 4, 6};
    // int[] numbers2 = { 1, 2, 3};
    // void Start()
    // {
    //     Debug.Log(Mean(numbers1));
    //     Debug.Log(Mean(numbers2));
    // }
    // int Mean(int[] numbers)
    // {
    //     int sum = 0;
    //     int count = numbers.Length;
    //     return sum / count; // 合計/個数
    // }
    
    
    // TODO:intとfloatの計算：1.5と表示させる
    // int[] numbers = { 1, 1, 2, 2 };
    // void Start()
    // {
    //     Debug.Log(Mean(numbers));
    // }
    // int Mean(int[] numbers)
    // {
    //     int sum = 0;
    //     int count = numbers.Length;
    //     for (int i=0; i<count;i++)
    //     {
    //         sum += numbers[i];
    //     }
    //     return sum / count; // 合計/個数
    // }
}
