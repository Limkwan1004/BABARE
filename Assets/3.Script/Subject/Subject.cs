using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StateType
{
    NONE = 0,
    YOU = 1,
    DEFEAT = 2,
    WIN = 3,
    PUSH = 4,
    STOP = 5,
    MOVE = 6,
}

public class Subject : MonoBehaviour
{
    private SubjectState _SubjectState;

    public StateType _StateType = StateType.NONE;

    Dictionary<StateType, SubjectState> _states = new Dictionary<StateType, SubjectState>();

    private void Start()
    {
        StateDefaultSetting();

    }

    private void Update()
    {
        if (_StateType.Equals(StateType.NONE)) return;

        _SubjectState.OnUpdate();
    }

    private void FixedUpdate()
    {
        if (_StateType.Equals(StateType.NONE)) return;

        _SubjectState.OnFixedUpdate();
    }

    public void ChangeState(StateType stateType)
    {
        if (_StateType.Equals(stateType)) return;

        _states[_StateType].OnExit();
        _StateType = stateType;
        _states[_StateType].OnEnter();
    }

    private void StateDefaultSetting()
    {
        for (int i = 0; i < System.Enum.GetValues(typeof(StateType)).Length; i++)
        {
            AddState((StateType)i, SubjectManager.Instance._SubjectStates[i]);
        }

        _SubjectState = _states[_StateType];
    }

    private void AddState(StateType stateType, SubjectState subjectState)
    {
        if (!_states.ContainsKey(stateType)) _states.Add(stateType, subjectState);
    }



}
