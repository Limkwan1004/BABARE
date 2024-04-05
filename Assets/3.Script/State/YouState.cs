using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class YouState : SubjectState
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
        if (Input.GetKey(KeyCode.RightArrow) && !isMove)
        {
            Move(Vector3.right);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && !isMove)
        {
            Move(Vector3.left);

        }
        if (Input.GetKey(KeyCode.UpArrow) && !isMove)
        {
            Move(Vector3.up);

        }
        if (Input.GetKey(KeyCode.DownArrow) && !isMove)
        {
            Move(Vector3.down);
        }
    }


}
