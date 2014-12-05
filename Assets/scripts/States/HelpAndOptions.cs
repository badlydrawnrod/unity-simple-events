using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;


public class HelpAndOptions : State, IBackHandler
{
    public GameObject helpAndOptionsPrefab;

    private GameObject helpAndOptions;

    public override void Enter()
    {
        helpAndOptions = Instantiate(helpAndOptionsPrefab) as GameObject;
        helpAndOptions.transform.SetParent(transform, false);
    }

    public override void Exit()
    {
        Destroy(helpAndOptions);
        helpAndOptions = null;
    }

    public void OnBack()
    {
        ChangeState(Parent);
    }
}
