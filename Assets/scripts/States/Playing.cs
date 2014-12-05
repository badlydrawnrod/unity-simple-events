using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;


public class Playing : State, IPauseHandler
{
    public State main;
    public State paused;
    public GameObject playingPrefab;

    private GameObject playing;

    public override void Enter()
    {
        playing = Instantiate(playingPrefab) as GameObject;
        playing.transform.SetParent(transform, false);
    }

    public override void Exit()
    {
        Destroy(playing);
        playing = null;
    }

    public override void ChildExited()
    {
        playing.SetActive(true);
    }

    public void OnPause()
    {
        playing.SetActive(false);
        ChangeState(paused);
    }
}
