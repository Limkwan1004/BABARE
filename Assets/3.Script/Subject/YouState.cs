using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouState : SubjectState
{
    private Vector3 _moveDirection = Vector3.zero;
    private bool isMove = false;
    [SerializeField] private float _moveTime = 0.5f;

    public override void OnEnter()
    {

    }

    public override void OnExit()
    {

    }

    public override void OnFixedUpdate()
    {

    }

    public override void OnUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (!horizontal.Equals(0) || !vertical.Equals(0))
        {
            _moveDirection = new Vector2(horizontal, vertical);

            if (!isMove)
            {
                Vector3 end = transform.position + _moveDirection;
                StartCoroutine(GridMove(end));
            }
        }
    }

    IEnumerator GridMove(Vector3 end)
    {
        isMove = true;

        float percent = 0;
        float current = 0;
        Vector3 start = transform.position;

        while (percent < 1)
        {
            current += Time.deltaTime;
            percent = current / _moveTime;

            transform.position = Vector3.Lerp(start, end, percent);

            yield return null;
        }

        isMove = false;
    }

}
