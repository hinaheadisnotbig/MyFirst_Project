using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public GameObject A;
    void Start()
    {
        //Debug.Log(A.transform.parent.name); // ����׷� �θ��� �̸� ���
        //Debug.Log(A.transform.parent.transform.position); // ����׷� �θ��� ������ ���
        //Debug.Log(A.transform.parent.tag); // ����׷� �θ��� �ױ� ���

        int cnt = A.transform.childCount; // �ڽ��� �� �޾ƿ� ���� cnt�� �� �Ҵ�
                                          // ������ �ڽĺ��� 0���� ����

        for (int i = 0; i < cnt; i++) {  // �ڽ��� �� cnt��ŭ �ݺ��� ����
            Debug.Log(A.transform.GetChild(i).name); // ����׷� �� �ڽ��� �̸� ���
            Debug.Log(A.transform.GetChild(i).position); // ����׷� �� �ڽ��� ������ ���
            Debug.Log(A.transform.GetChild(i).tag); // ����׷� �� �ڽ��� �ױ� ���
        }
    }
}
