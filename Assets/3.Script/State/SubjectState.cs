using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SubjectState : MonoBehaviour
{
    public bool isMove { get; protected set; } = false;
    protected float _moveSpeed = 5f;

    public bool hasLeft = false;
    public bool hasUp = false;
    public bool hasRight = false;
    public bool hasDown = false;



    private IEnumerator Move_co;

    private void Start()
    {
        Debug.Log("Check");
    }

    public abstract void OnEnter();
    public abstract void OnUpdate();
    public abstract void OnFixedUpdate();
    public abstract void OnExit();

    private IEnumerator Move_Co(Vector3 direction)
    {
        isMove = true;
        Vector3 start = transform.position;
        Vector3 end = start + direction;
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

    public void Move(Vector3 end)
    {
        Move_co = Move_Co(end);
        StartCoroutine(Move_co);
    }

}
