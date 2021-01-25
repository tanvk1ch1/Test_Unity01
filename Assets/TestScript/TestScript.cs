using System.Collections;
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
    }
}
