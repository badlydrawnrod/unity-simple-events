using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;


public class Main : State, IPlayHandler, IHelpHandler
{
    public State playing;
    public State helpAndOptions;
    public GameObject mainMenuPrefab;

    private GameObject mainMenu;

    public override void Enter()
    {
        mainMenu = Instantiate(mainMenuPrefab) as GameObject;
        mainMenu.transform.SetParent(transform, false);
    }

    public override void Exit()
    {
        Destroy(mainMenu);
        mainMenu = null;
    }

    public override void ChildExited()
    {
        mainMenu.SetActive(true);
    }

    public void OnPlay()
    {
        ChangeState(playing);
    }

    public void OnHelp()
    {
        mainMenu.SetActive(false);
        ChangeState(helpAndOptions);
    }
}
