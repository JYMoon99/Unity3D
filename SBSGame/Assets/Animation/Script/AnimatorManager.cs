using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] AnimationClip[] animationClip;
    void Start()
    {
        for(int i = 0; i < animationClip.Length; i++)
        {
            var data = AnimationUtility.GetAnimationClipSettings(animationClip[i]);

            data.loopTime = false;

            AnimationUtility.SetAnimationClipSettings(animationClip[i], data);
        }
    }

    // Update is called once per frame
    void Update()
    {

        // 현재 애니메이터에 있는 애니메이션의 이름이 "Close"일 때,
        if(animator.GetCurrentAnimatorStateInfo(0).IsName("Close"))
        {
            // 현재 애니메이션의 진행도가 1f보다 크거나 같을 때, ( ==를 안 쓰고, >= 로 비교하는 이유는 float과 float을 비교 연산하면
            //                                                     부동소수점 오차 때문에 값이 이상하게 저장될 수 있다.)
            if(animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1f)
            {
                // 애니메이터가 있는 게임 오브젝트를 비활성화한다.
                animator.gameObject.SetActive(false);
            }
        }
    }

    public void Open()
    {
        animator.gameObject.SetActive(true);
    }

    public void Close()
    {
        animator.SetTrigger("Close");
    }
}
