using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public enum soundName
    {
        Siren,
        Explosion,
        Magic
    }

    [SerializeField] AudioClip[] audioClip; // 여러 개의 사운드 클립을 담아야 하기에 배열로 선언

    [SerializeField] AudioSource soundSource; // 배경음악과 효과음을 따로 설정하기 위해서 AudioSource 2개 선언
    [SerializeField] AudioSource effectSource; 

    public void SoundCall(int count)
    {
        effectSource.PlayOneShot(audioClip[count]); // 리스너를 여러개 동시에 호출하고 싶을 때는 PlayOneShot
    }

    public void Volume(float volume)
    {

        soundSource.volume = volume;
    }
}
