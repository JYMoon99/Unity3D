using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioClip[] audioClip; // 여러 개의 사운드 클립을 담아야 하기에 배열로 선언

    [SerializeField] AudioSource soundSource; // 배경음악과 효과음을 따로 설정하기 위해서 AudioSource 2개 선언
    [SerializeField] AudioSource effectSource; 

    public void SoundCall(int count)
    {

    }
}
