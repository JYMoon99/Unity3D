using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{

    int random;

    void Start()
    {
        random = Random.Range(1, 5); // 1 ~ 5 ������ ���� ��ȯ
        Destroy(gameObject, random);
    }

}
