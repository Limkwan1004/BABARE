using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubjectText : MonoBehaviour
{
    [SerializeField] private string _tag = string.Empty;

    public void WAN() // �޼���� �ٲ����
    {
        GameObject[] gameobjects = GameObject.FindGameObjectsWithTag(_tag);
        SubjectActive(gameobjects);
    }

    private void SubjectActive(GameObject[] objs)
    {
        for (int i = 0; i < objs.Length; i++)
        {
            // TODO ���� �ϱ�

        }
    }

}
