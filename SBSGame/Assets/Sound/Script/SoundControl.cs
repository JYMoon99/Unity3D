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
        float x = Input.GetAxis("Horizontal"); // A-D, left, right -1 ~ 1 사이의 값을 반환하는 함수
        float z = Input.GetAxis("Vertical"); // W-S, up key, down key -1 ~ 1 사이의 값을 반환하는 함수

        Vector2 direction = new Vector3(x, 0, z).normalized; // 벡터의 정규화

        control.SimpleMove(direction * speed); // SimpleMove : 중력 계산이 되는 함수
    }
}
