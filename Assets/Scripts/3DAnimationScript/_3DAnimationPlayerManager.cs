using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// アニメーション
// ・設定方法
// 　・Animator Controller：アニメーション全体を管理
// 　・Animation Clip：1つ1つのモーション
// ・切り替え方法
// 　AnimatorControllerを作る
// 　作成したAnimation ClipをD&D
// 　Option or AltでAnimator内の移動ができる
// 　Set αs Layer Default Styleでデフォルト設定ができる

// 　矢印をつなげる(Make Transition)
// 　遷移条件を作る(パラメータの用意,50以下で切り替えなど)
// 　　条件がないなら、時間で遷移される
// 　ParametersからTriggerを作る(AttackTrigger)
// 　矢印をクリックして、ConditionsにAttackTriggerを登録する
// 　戻すために、矢印を元のIdleにつなげる

// 　Parameters作成、floatで「MoveSpeed」
// 　MakeTransitionで矢印をIdleからWalkにつなげる
// 　ConditionでMoveSpeedを登録し、Greaterが「0.01」より大きい場合にWalkにClip遷移するよう設定
// 　Greaterを「0」でIdleに戻すために、MakeTransitionでIdleにつなげる
// 　Idleに戻る矢印を選択して、less設定で「MoveSpeed」が「0.01」より小さい場合にIdleにClip遷移するよう設定
// 　HasExitTimeはアニメーションをすぐ切り替えるかどうかの設定。
// 　　チェックが入っていると、モーションが終わってから遷移。外れていると、すぐに遷移する。


// 　コードからAnimationを変更する
// 　Animatorコンポーネントのついているオブジェクトに、スクリプトをアタッチする


// ・アニメーションの途中でメソッド実行する方法
// 　AnimationClipのEventを活用する
// 　Animationウィンドウから、「Attack01」を選択する
// 　「Add Event」を選択し、所定の位置にEventのバーを移動させる
// 　メソッドを作成し、EventのFunctionに呼びたいメソッドを登録する
public class _3DAnimationPlayerManager : MonoBehaviour
{
    private Animator _animator;
    private void Start()
    {
        // 同じオブジェクトにアタッチしているAnimatorコンポーネントを取得する
        _animator = GetComponent<Animator>();
    }
    private void Update()
    {
        // Spaceキーが押されたら、AttackTriggerをオンにしたい
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetTrigger("AttackTrigger");
        }
        // 歩く場合
        if (Input.GetKeyDown(KeyCode.M))
        {
            _animator.SetFloat("MoveSpeed", 1.0f);
        }
        // 戻す場合
        if (Input.GetKeyDown(KeyCode.N))
        {
            _animator.SetFloat("MoveSpeed", 0f);
            // 以下はboolでParameter設定した場合に使う
            // _animator.SetBool();
        }
    }
    
    public void HitLog()
    {
        Debug.Log("Hit!");
    }
}
