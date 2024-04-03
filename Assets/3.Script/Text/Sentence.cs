using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sentence : MonoBehaviour
{
    [SerializeField] private CircleCollider2D _rightCol;
    [SerializeField] private CircleCollider2D _leftCol;
    [SerializeField] private CircleCollider2D _upCol;
    [SerializeField] private CircleCollider2D _downCol;

    private void FixedUpdate()
    {
        if (_rightCol != null && _leftCol)
        {
            SubjectText subjectText = _leftCol.gameObject.GetComponent<SubjectText>();

        }

        if (_upCol != null && _downCol)
        {

        }
    }
}
