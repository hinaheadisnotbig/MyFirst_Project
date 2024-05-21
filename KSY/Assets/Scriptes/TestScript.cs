using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public GameObject A;
    void Start()
    {
        //Debug.Log(A.transform.parent.name); // 디버그로 부모의 이름 출력
        //Debug.Log(A.transform.parent.transform.position); // 디버그로 부모의 포지션 출력
        //Debug.Log(A.transform.parent.tag); // 디버그로 부모의 테그 출력

        int cnt = A.transform.childCount; // 자식의 수 받아와 정수 cnt에 값 할당
                                          // 맨위에 자식부터 0으로 시작

        for (int i = 0; i < cnt; i++) {  // 자식의 수 cnt만큼 반복문 실행
            Debug.Log(A.transform.GetChild(i).name); // 디버그로 각 자식의 이름 출력
            Debug.Log(A.transform.GetChild(i).position); // 디버그로 각 자식의 포지션 출력
            Debug.Log(A.transform.GetChild(i).tag); // 디버그로 각 자식의 테그 출력
        }
    }
}
