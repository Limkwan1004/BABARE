using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]

public class SubjectReach : MonoBehaviour
{
    public SubjectState _subjectState;
    private Subject _subject;
    private void Start()
    {
        _subjectState = transform.parent.GetComponent<Subject>()._SubjectState;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("REACH"))
        {
            _subject = collision.transform.parent.GetComponent<Subject>();
            if (_subject._StateType.Equals(StateType.YOU))
            {
                _subjectState.hasLeft = true;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (_subject != null)
        {
            _subject = null;
            _subjectState.hasLeft = false;
        }
    }



}
