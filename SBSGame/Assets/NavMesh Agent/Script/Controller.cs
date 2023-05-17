using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Controller : MonoBehaviour
{
    public int count;
    public Transform[] point;
    public NavMeshAgent navMeshAgent;

    private void Start()
    {
        InvokeRepeating("Move", 1, 5f);
        // "Move" : ������ �Լ��� �̸�
        // 1 : �� �� �ڿ� ������ �ð�
        // 5 : �� �� ���� ������ �ð�
    }

    public void Move()
    {
        if(navMeshAgent.velocity == Vector3.zero)
        {
            if(point.Length <= count)
            {
                count = 0;
            }

            // SetDestination : �̵��ϰ��� �ϴ� ��ġ

            navMeshAgent.SetDestination(point[count++].position);
        }
    }
}