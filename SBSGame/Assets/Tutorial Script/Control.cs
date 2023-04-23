using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Control : MonoBehaviour 
{
    // 스크립트가 비활성화된 상태로 게임 오브젝트가 생성되었을 때
    // 단 한번만 호출하는 이벤트 함수입니다.
    private void Awake()
    {
        Debug.Log("Awake");
    }

    // 스크립트가 활성화되었을 때 호출되는 이벤트 함수입니다.
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    // 스크립트가 활성화된 상태로 게임 오브젝트가 생성되었다면
    // 단 한 번만 호출되는 이벤트 함수입니다.
    void Start()
    {
        Debug.Log("Start");
    }

    // 프레임과 상관없이 무조건 시간 기준(TimeStep 0.02초)
    // 으로 호출되는 이벤트 함수입니다.
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    // 게임 오브젝트가 활성화된 상태로 매 프레임마다
    // 호출되는 이벤트 함수입니다.
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            // Vector3.forward(0, 0, 1)
            transform.position = transform.position + Vector3.forward * 2f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            // Vector3.left(-1, 0, 0)
            transform.position = transform.position + Vector3.left * 2f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            // Vector3.forward(1, 0, 0)
            transform.position = transform.position + Vector3.right * 2f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            // Vector3.forward(0, 0, -1)
            transform.position = transform.position + Vector3.back * 2f * Time.deltaTime;
        }


        Debug.Log("Update");
    }

    // 게임 오브젝트가 활성화된 상태로 Update() 함수가
    // 호출되고 나서 마지막에 호출되는 이벤트 함수입니다.
    private void LateUpdate()
    {
        Debug.Log("Late Update");
    }

    // 게임이 종료되었을 때 단 한번만 호출되는
    // 이벤트 함수입니다.
    private void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit");
    }

    // 게임 오브젝트가 비활성화되었을 때 호출되는
    // 이벤트 함수입니다.
    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    // 게임 오브젝트가 활성화된 상태로 게임 오브젝트가
    // 파괴되었을 때 호출되는 이벤트 함수입니다.
    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}
