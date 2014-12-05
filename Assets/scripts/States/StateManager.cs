using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;


public class StateManager : MonoBehaviour
{
    public State initialState;
    private State currentState;

    void Start()
    {
        ChangeState(initialState);
    }

    public void ChangeState(State targetState)
    {
        State commonSuperState = FindCommonSuperState(targetState);
        
        // Exit the states from the current state up to the common super state.
        for (State state = currentState; state != null && state != commonSuperState;)
        {
            state.Exit();
            state = state.Parent;
            if (state != null)
            {
                state.ChildExited();
            }
        }

        // Build a path from the target state up to the common super state.
        Stack<State> entrances = new Stack<State>();
        for (State target = targetState; target != null && target != commonSuperState; target = target.Parent)
        {
            entrances.Push(target);
        }

        // Traverse the path in reverse order to enter the states from the common super state to the target.
        while (entrances.Count > 0)
        {
            State state = entrances.Pop();

            // Tell the state that we're entering it.
            state.Enter();
        }
        
        // We've made it to the target state.
        currentState = targetState;
    }

    private State FindCommonSuperState(State targetState)
    {
        for (State s = currentState; s != null; s = s.Parent)
        {
            for (State t = targetState; t != null; t = t.Parent)
            {
                if (s == t)
                {
                    return s;
                }
            }
        }
        return null;
    }
}
