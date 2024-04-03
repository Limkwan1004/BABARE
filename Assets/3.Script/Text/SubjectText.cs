using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubjectText : MonoBehaviour
{
    [SerializeField] private string _tag = string.Empty;

    public void WAN() // 메서드명 바꿔야함
    {
        GameObject[] gameobjects = GameObject.FindGameObjectsWithTag(_tag);
        SubjectActive(gameobjects);
    }

    private void SubjectActive(GameObject[] objs)
    {
        for (int i = 0; i < objs.Length; i++)
        {
            // TODO 투명도 하기

        }
    }

}
