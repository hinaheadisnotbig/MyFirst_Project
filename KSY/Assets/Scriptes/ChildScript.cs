using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildScript : MonoBehaviour
{
    public GameObject A;
    void Start()
    {
        Debug.Log(A.transform.parent.name); // ����׷� �θ��� �̸� ���
        Debug.Log(A.transform.parent.transform.position); // ����׷� �θ��� ������ ���
        Debug.Log(A.transform.parent.tag); // ����׷� �θ��� �ױ� ���
    }

}
