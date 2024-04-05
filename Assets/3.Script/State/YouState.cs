using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class YouState : SubjectState
{
    private bool isMove = false;
    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private Tilemap _tileMap;

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
        if (Input.GetKey(KeyCode.RightArrow) && !isMove)
        {
            Vector3 end = transform.position + Vector3.right;
            StartCoroutine(Move(end));
        }
        if (Input.GetKey(KeyCode.LeftArrow) && !isMove)
        {
            Vector3 end = transform.position + Vector3.left;
            StartCoroutine(Move(end));

        }
        if (Input.GetKey(KeyCode.UpArrow) && !isMove)
        {
            Vector3 end = transform.position + Vector3.up;
            StartCoroutine(Move(end));

        }
        if (Input.GetKey(KeyCode.DownArrow) && !isMove)
        {
            Vector3 end = transform.position + Vector3.down;
            StartCoroutine(Move(end));
        }
    }

    IEnumerator Move(Vector3 end)
    {
        isMove = true;
        Vector3 start = transform.position;

        float percent = 0;
        float current = 0;

        while (percent < 1)
        {
            current += Time.deltaTime;
            percent = current * _moveSpeed;

            transform.position = Vector3.Lerp(start, end, percent);

            yield return null;
        }

        isMove = false;
        yield return null;
    }
}
