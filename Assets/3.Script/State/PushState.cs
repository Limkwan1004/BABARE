using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushState : SubjectState
{
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
        if (Input.GetKey(KeyCode.RightArrow) && hasLeft && !isMove)
        {
            Move(Vector3.right);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && hasRight && !isMove)
        {
            Move(Vector3.left);

        }
        if (Input.GetKey(KeyCode.UpArrow) && hasDown && !isMove)
        {
            Move(Vector3.up);

        }
        if (Input.GetKey(KeyCode.DownArrow) && hasUp && !isMove)
        {
            Move(Vector3.down);
        }
    }
}
