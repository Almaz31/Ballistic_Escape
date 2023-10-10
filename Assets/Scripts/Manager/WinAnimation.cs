using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinAnimation : MonoBehaviour
{
    [SerializeField] private Animator animatorLeft;
    [SerializeField] private Animator animatorRight;

    public void StartAnimation()
    {
        animatorLeft.SetBool("IsWinPoint", true);
        animatorRight.SetBool("IsWinPoint", true);
    }
}
