using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StateType
{
    None = 0,
    YOU = 1,
    MOVE = 2,
    DEFATE = 3,
    WIN = 4,
    PUSH = 5,
}


public class Subject : MonoBehaviour
{
    private SubjectState _SubjectState;

    public StateType _StateType;

    Dictionary<StateType, SubjectState> _states = new Dictionary<StateType, SubjectState>();

    private void Awake()
    {
    }

    private void Start()
    {

    }

    private void Update()
    {
        _SubjectState.OnUpdate();
    }

    private void FixedUpdate()
    {
        _SubjectState.OnFixedUpdate();
    }

    public void ChangeState(StateType stateType)
    {
        if (_StateType.Equals(stateType)) return;

        _states[_StateType].OnExit();
        _StateType = stateType;
        _states[_StateType].OnEnter();
    }





}
