using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    public float speed = 5.0f;
    private CharacterController control;

    void Start()
    {
        control = GetComponent<CharacterController>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // A-D, left, right -1 ~ 1 ������ ���� ��ȯ�ϴ� �Լ�
        float z = Input.GetAxis("Vertical"); // W-S, up key, down key -1 ~ 1 ������ ���� ��ȯ�ϴ� �Լ�

        Vector2 direction = new Vector3(x, 0, z).normalized; // ������ ����ȭ

        control.SimpleMove(direction * speed); // SimpleMove : �߷� ����� �Ǵ� �Լ�
    }
}
