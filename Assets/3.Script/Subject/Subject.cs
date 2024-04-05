using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum StateType
{
    NONE = 0,
    YOU = 1,
    DEFEAT = 2,
    WIN = 3,
    PUSH = 4,
    STOP = 5,
}

[RequireComponent(typeof(YouState))]
[RequireComponent(typeof(DefeatState))]
[RequireComponent(typeof(WinState))]
[RequireComponent(typeof(StopState))]
[RequireComponent(typeof(PushState))]


public class Subject : MonoBehaviour
{
    public SubjectState _SubjectState { get; private set; }
    [SerializeField] SubjectState[] _Subject;
    public StateType _StateType = StateType.NONE;

    Dictionary<StateType, SubjectState> _states = new Dictionary<StateType, SubjectState>();

    public bool canMove = false;

    private void Awake()
    {
        _Subject = new SubjectState[System.Enum.GetValues(typeof(StateType)).Length - 1];
        _Subject[0] = GetComponent<YouState>();
        _Subject[1] = GetComponent<DefeatState>();
        _Subject[2] = GetComponent<WinState>();
        _Subject[3] = GetComponent<PushState>();
        _Subject[4] = GetComponent<StopState>();
        StateDefaultSetting();
    }

    private void Start()
    {

    }

    private void Update()
    {
        if (_StateType.Equals(StateType.NONE)) return;

        if (Input.GetKeyDown(KeyCode.K))
        {
            ChangeState(StateType.DEFEAT);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            ChangeState(StateType.WIN);
        }

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
        for (int i = 0; i < System.Enum.GetValues(typeof(StateType)).Length - 1; i++)
        {
            AddState((StateType)i + 1, _Subject[i]);
        }

        if (!_StateType.Equals(StateType.NONE)) _SubjectState = _states[_StateType];
    }

    private void AddState(StateType stateType, SubjectState subjectState)
    {
        if (!_states.ContainsKey(stateType)) _states.Add(stateType, subjectState);
    }



}
