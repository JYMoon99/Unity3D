using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioClip[] audioClip; // ���� ���� ���� Ŭ���� ��ƾ� �ϱ⿡ �迭�� ����

    [SerializeField] AudioSource soundSource; // ������ǰ� ȿ������ ���� �����ϱ� ���ؼ� AudioSource 2�� ����
    [SerializeField] AudioSource effectSource; 

    public void SoundCall(int count)
    {

    }
}
