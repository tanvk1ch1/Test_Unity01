using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerScript : MonoBehaviour
{
    // 問1解答
    // TODO:Q1_10~1000をwhileで表示せよ
    // private int _cnt = 10;
    // private void Start()
    // {
    //     while(_cnt <= 1000)
    //     {
    //         Debug.Log(_cnt);
    //         _cnt = _cnt + 1;
    //     }
    // }
    
    
    // TODO:1000から2000までの数字を表示し続けて、273の倍数があったらそこで処理を止めたい
    // int n = 1000;
    // void Start()
    // {
    //     while (n <= 2000)
    //     {
    //         Debug.Log(n);
    //         if (n % 273 == 0)
    //         {
    //             break;
    //         }
    //         n++;
    //     }
    // }
    
    
    // TODO:「10から1000までの数字を表示」はfor文で
    // void Start()
    // {
    //     for (int i = 10; i <= 1000; i++)
    //     {
    //         Debug.Log(i);
    //     }
    // }
    
    
    // TODO:「1000から2000までの数字を表示し続けて、273の倍数があったらそこで処理止めたい」をfor文で
    // void Start()
    // {
    //     for (int i=10; i<=1000; i++)
    //     {
    //         if (i % 273 == 0)
    //         {
    //             break;
    //         }
    //         Debug.Log(i);
    //     }
    // }
    
    
    // TODO:「0から99までの数字を表示し、3の倍数は表示しない」をfor文で
    // private void Start()
    // {
    //     for (int i = 0; i <= 99; i++)
    //     {
    //         if (i % 3 == 0)
    //         {
    //             continue;
    //         }
    //         Debug.Log(i);
    //     }
    // }
    
    
    // TODO:switch文で書いたコードを列挙型で書いてみる
    // enum DIRECTION
    // {
    //     UP,
    //     DOWN,
    //     RIGHT,
    //     LEFT
    // }
    // private DIRECTION direction = DIRECTION.UP;
    // void Start()
    // {
    //     switch (direction)
    //     {
    //         case DIRECTION.UP:
    //             Debug.Log("上");
    //             break;
    //         case DIRECTION.DOWN:
    //             Debug.Log("下");
    //             break;
    //         case DIRECTION.LEFT:
    //             Debug.Log("左");
    //             break;
    //         case DIRECTION.RIGHT:
    //             Debug.Log("右");
    //             break;
    //         default:
    //             Debug.Log("その他");
    //             break;
    //     }
    // }
    
    
    // 問2解答
    // TODO:「10,20,30」の値を持つ配列を作る時のおかしなところはどこか？
    // int[] numbers = new int []{10, 20, 30};
    // void Start()
    // {
    //     Debug.Log(numbers[0]); // 表示確認用
    // }
    
    
    // TODO:配列の値取得の方法について
    // int[] numbers = { 10, 20, 30 };
    // void Start()
    // {
    //     Debug.Log(numbers[0]);
    //     Debug.Log(numbers[1]);
    //     Debug.Log(numbers[2]);
    //     // or
    //     int x = numbers[0];
    //     Debug.Log(x);
    //     int y = numbers[1];
    //     Debug.Log(y);
    //     int z = numbers[2];
    //     Debug.Log(z);
    // }
    
    
    // TODO:配列の値変更の方法について
    // int[] numbers = { 10, 20, 30 };
    // void Start()
    // {
    //     numbers[1] = 1;
    //     Debug.Log(numbers[1]);
    // }
    
    
    // TODO:配列とfor文の組み合わせについて、値をfor文ですべて表示する
    // int[] numbers = { 10, 20, 30, 1,2,33,-33,44,556,54345,3434 };
    // void Start()
    // {
    //     for (int i = 0; i < 11; i++)
    //     {
    //         Debug.Log(numbers[i]);
    //     }
    //     // or
    //     foreach (var n in numbers) // i不要のパターン
    //     {
    //         Debug.Log(n);
    //     }
    // }
    
    
    // TODO:配列とfor文の組み合わせ2：配列が変わってもfor文を変えない方法
    // int[] numbers = { 10, 20, 30, 1, 2, 33, -33, 44, 556, 54345, 3434, -1, 222, 333 };
    // void Start()
    // {
    //     // 3434までしか表示されない
    //     for (int i = 0 ; i < numbers.Length; i++)
    //     {
    //         Debug.Log(numbers[i]);
    //     }
    // }
    
    
    // TODO:配列とfor文の組み合わせ3:配列の値の合計を調べる方法
    // int sum = 0;
    // int[] numbers = { 10, 20, 30, 1, 2, 33, -33, 44, 556, 54345, 3434, -1, 222, 333 };
    // void Start()
    // {
    //     for (int i = 0; i < numbers.Length; i++)
    //     {
    //         sum += numbers.Length;
    //     }
    //     Debug.Log(sum);
    // }
    
    
    // TODO:List型の宣言方法について
    // List<string> nameList = new List<string>(){ "aaa", "bbb", "ccc"};
    // void Start()
    // {
    //     Debug.Log(nameList[0]); // 確認用
    // }
    
    
    // TODO:List型の値の取得と変更方法
    // List<string> nameList = new List<string>{ "あああ", "いいい", "ううう"};
    // void Start()
    // {
    //     Debug.Log(nameList[0]);
    //     nameList[0] = "えええ";
    //     Debug.Log(nameList[0]);
    // }
    
    
    // TODO:List型とfor文の組み合わせについて：値を全て表示
    // // List型では、LengthではなくCountを使う
    // List<string> nameList = new List<string>{ "かかか", "ききき", "くくく"};
    // void Start()
    // {
    //     for (int i = 0; i < nameList.Count; i++)
    //     {
    //         Debug.Log(nameList[i]);
    //     }
    // }
    
    
    // TODO:List型の値の追加
    // List<string> nameList = new List<string>{ "さささ", "ししし", "すすす"};
    // void Start()
    // {
    //     nameList.Add("せせせ"); // 直接stringの「"せせせ"」を追加できる
    //     for (int i = 0; i < nameList.Count; i++)
    //     {
    //         Debug.Log(nameList[i]);
    //     }
    // }
    
    
    // TODO:List型の値の削除
    // List<string> nameList = new List<string>{ "たたた", "ちちち", "つつつ"};
    // void Start()
    // {
    //     nameList.Remove("ちちち");
    //     // or
    //     // nameList.RemoveAt(1);
    //     for (int i = 0; i < nameList.Count; i++)
    //     {
    //         Debug.Log(nameList[i]);
    //     }
    // }
    
    
    // 問3
    // TODO:関数の定義の方法
    // void Start()
    // {
    // }
    // void FirstFunc1()
    // {
    // }
    // void FirstFunc2()
    // {
    // }
    
    
    // TODO:関数の実行
    // void Start() // Unityのイベント関数
    // {
    //     Sample();
    // }
    // void Sample()
    // {
    //     Debug.Log("京都と表示");
    // }
    
    
    // TODO:変数のスコープ(範囲)：xとyの和を表示
    // int x = 10;
    // int y = 2;
    // void Start()
    // {
    //     // ローカル変数ではない状態にする
    //     Sample();
    // }
    // void Sample()
    // {
    //     Debug.Log(x + y);
    // }
    
    
    // TODO:引数ありの関数：引数を使って一つの関数にする、Sample()内での処理は1行だけ
    // int x = 10;
    // int y = 2;
    // int z = -3;
    // void Start()
    // {
    //     Sample(x,y);
    //     Sample(y,z);
    //     Sample(z,x);
    // }
    // void Sample(int a, int b)
    // {
    //     Debug.Log(a+b);
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
    //     else if (x == 0 && y < 0)
    //     {
    //         Debug.Log("下");
    //     }
    //     else if (x > 0 && y == 0)
    //     {
    //         Debug.Log("右");
    //     }
    //     else if (x < 0 && y == 0)
    //     {
    //         Debug.Log("左");
    //     }
    //     else if (x == 0 && y == 0)
    //     {
    //         Debug.Log("停止");
    //     }
    //     else
    //     {
    //         Debug.Log("その他");
    //     }
    // }
    
    
    // TODO:返り値ありの関数：targetはダメージを受けました、の後に合計いくらダメージを受けたのかを表示する
    // void Start()
    // {
    //     int sum = 0;
    //     sum += Damage("スライム", 100);
    //     sum += Damage("ドラキー", 20);
    //     // sum = 100+20; //100とか20が変わるたびに修正しないといけないのでミスが起こりやすい
    //     Debug.Log("合計" + sum + "のダメージ！");
    // }
    // int Damage(string target, int damage)
    // {
    //     Debug.Log(target + "は" + damage + "ダメージをうけた！");
    //     return damage;
    // }
    
    
    // TODO:引数あり関数と配列の組み合わせ：配列の中身を確認できる関数を作成する
    // ヒント：関数内でforを1回使う
    // int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    // int[] numbers2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    // void Start()
    // {
    //     ShowArrayValueLog(numbers1);
    //     ShowArrayValueLog(numbers2);
    // }
    // void ShowArrayValueLog(int[] numbers)
    // {
    //     for (int i = 0; i < numbers1.Length; i++)
    //     {
    //         Debug.Log(numbers[i]);
    //     }
    // }
    
    
    // TODO:平均の計算：2つの配列の平均を求める関数を作る
    // int[] numbers1 = { 2, 4, 6};
    // int[] numbers2 = { 1, 2, 3};
    // void Start()
    // {
    //     Debug.Log("numbers1の平均値は:" + Mean(numbers1));
    //     Debug.Log("numbers2の平均値は:" + Mean(numbers2));
    // }
    // int Mean(int[] numbers)
    // {
    //     int sum = 0;
    //     int count = numbers.Length;
    //     for (int i = 0; i < numbers.Length; i++)
    //     {
    //         sum += numbers[i];
    //     }
    //     return sum / count; // 合計/個数
    // }
    
    
    // TODO:intとfloatの計算：1.5と表示させる
    // int[] numbers = { 1, 1, 2, 2 };
    // void Start()
    // {
    //     Debug.Log(Mean(numbers));
    // }
    // float Mean(int[] numbers)
    // {
    //     float sum = 0;
    //     int count = numbers.Length;
    //     for (int i = 0; i < count; i++)
    //     {
    //         sum += numbers[i];
    //     }
    //     return sum / count; // 合計/個数
    // }
    
    
    // TODO:QuestionClass1ScriptのAttackを呼ぶにはどうするか
    // Question1ClassScriptをInspector上でアタッチする
    // public QuestionClass1Script question1ClassScript;
    // void Start()
    // {
    //     //ここでQuestionClass1ScriptのAttack関数を実行したい
    //     question1ClassScript.Attack();
    // }
    
    
    // TODO:public関数：QuestionClass1ScriptのDamageを呼ぶにはどうするか
    // public QuestionClass1Script question1ClassScript;
    // void Start()
    // {
    //     question1ClassScript.Attack();
    //     question1ClassScript.Damage(10);
    // }
    
    
    // TODO:public関数：QuestionClass1Scriptのint hpを使うにはどうするか
    // public QuestionClass1Script question1ClassScript;
    // void Start()
    // {
    //     int hp = question1ClassScript.hp;
    //     Debug.Log(hp);
    // }
}
