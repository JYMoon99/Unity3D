using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{

    // 1 ~ 5 사이의 값이 반환
    
    void Start()
    {
        int random = Random.Range(1, 5);
        Destroy(gameObject, random);
    }

}
