using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public interface IPlayHandler : IEventSystemHandler
{
    void OnPlay();
}
