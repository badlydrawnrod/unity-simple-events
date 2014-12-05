using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public interface IBackHandler : IEventSystemHandler
{
    void OnBack();
}
