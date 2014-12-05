using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public interface IPauseHandler : IEventSystemHandler
{
    void OnPause();
}
