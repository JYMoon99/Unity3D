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

    [SerializeField] AudioClip[] audioClip; // ���� ���� ���� Ŭ���� ��ƾ� �ϱ⿡ �迭�� ����

    [SerializeField] AudioSource soundSource; // ������ǰ� ȿ������ ���� �����ϱ� ���ؼ� AudioSource 2�� ����
    [SerializeField] AudioSource effectSource; 

    public void SoundCall(int count)
    {
        effectSource.PlayOneShot(audioClip[count]); // �����ʸ� ������ ���ÿ� ȣ���ϰ� ���� ���� PlayOneShot
    }

    public void Volume(float volume)
    {

        soundSource.volume = volume;
    }
}
