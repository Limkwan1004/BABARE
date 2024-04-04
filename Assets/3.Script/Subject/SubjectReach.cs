using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]

public class SubjectReach : MonoBehaviour
{
    private CircleCollider2D _circleCol;

    private void Start()
    {
        TryGetComponent(out _circleCol);
    }



}
