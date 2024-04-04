using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SubjectState : MonoBehaviour
{
    protected CircleCollider2D _leftCol;
    protected CircleCollider2D _rightCol;
    protected CircleCollider2D _upCol;
    protected CircleCollider2D _downCol;
    Subject _subject;

    private void Awake()
    {
        _subject = GetComponent<Subject>();
        Debug.Log("¹Ù²ñ");
    }

    public abstract void OnEnter();
    public abstract void OnUpdate();
    public abstract void OnFixedUpdate();
    public abstract void OnExit();
}
