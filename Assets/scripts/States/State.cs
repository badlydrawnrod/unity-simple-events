using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;


public abstract class State : MonoBehaviour
{
    public virtual void Enter() { }
    public virtual void Exit() { }
    public virtual void ChildExited() { }
    public State Parent { get { return transform.parent.GetComponent<State>(); } }

    private StateManager stateManager;

    void Awake()
    {
        // Go up the transform hierarchy until we find a state manager.
        for (Transform t = transform.parent; t != null; t = t.parent)
        {
            stateManager = t.GetComponent<StateManager>();
            if (stateManager != null)
            {
                break;
            }
        }
    }

    protected void ChangeState(State target)
    {
        stateManager.ChangeState(target);
    }
}
