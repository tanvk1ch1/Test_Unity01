using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 　各種アニメーション毎にコードを分けて実行させる
// 　AnimatorのAttack01ノードをクリックし、「AddBehavior」を選択してスクリプトを作成
// 　「StateMachineBehavior」
// 　※コンポーネント取得方法
// 　transformとかはできない。Animatorを頭に使うことで取得できる。
// 　Animationの「はじめ」「途中」「終わり」に分けて、処理ができる(剣を振ってぶつかる時だけ当たり判定を持たせる)
public class DogAttackBehavior : StateMachineBehaviour
{
    // 攻撃が終わったら元の場所に戻す
    private Vector3 currentpos;
    
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // 最初に現在の座標を取得して保存しておく
        currentpos = animator.transform.position;
        Debug.Log("OnStateEnter");
        // 例えば、攻撃中に移動しないようにするなら、OnStateEnterで移動速度をゼロにする、といったことができる
        animator.GetComponent<_3DAnimationPlayerManager>();
        // animator.transform.position~でできる。
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("OnStateUpdate");
        // 例：攻撃中は位置が上昇する
        animator.transform.position += new Vector3(0, 0.01f, 0);
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("OnStateExit");
        // アニメーションが終わったら、元の座標に戻す
        animator.transform.position = currentpos;
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // Implement code that processes and affects root motion
        Debug.Log("OnState");
    }

    // OnStateIK is called right after Animator.OnAnimatorIK()
    override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // Implement code that sets up animation IK (inverse kinematics)
        Debug.Log("OnState");
    }
}
