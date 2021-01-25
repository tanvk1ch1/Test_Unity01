using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerScript : MonoBehaviour
{
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
}
