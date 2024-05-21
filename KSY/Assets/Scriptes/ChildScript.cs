using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildScript : MonoBehaviour
{
    public GameObject A;
    void Start()
    {
        Debug.Log(A.transform.parent.name); // 디버그로 부모의 이름 출력
        Debug.Log(A.transform.parent.transform.position); // 디버그로 부모의 포지션 출력
        Debug.Log(A.transform.parent.tag); // 디버그로 부모의 테그 출력
    }

}
