using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;


public class Paused : State, IAbandonHandler, IResumeHandler, IHelpHandler
{
    public State main;
    public State playing;
    public State helpAndOptions;
    public GameObject pausedPrefab;

    private GameObject paused;
    private float timeScale;

    public override void Enter()
    {
        paused = Instantiate(pausedPrefab) as GameObject;
        paused.transform.SetParent(transform, false);
        timeScale = Time.timeScale;
        Time.timeScale = 0;
    }

    public override void Exit()
    {
        Time.timeScale = timeScale;
        Destroy(paused);
        paused = null;
    }

    public override void ChildExited()
    {
        paused.SetActive(true);
    }

    public void OnAbandon()
    {
        ChangeState(main);
    }

    public void OnResume()
    {
        ChangeState(playing);
    }

    public void OnHelp()
    {
        paused.SetActive(false);
        ChangeState(helpAndOptions);
    }
}
