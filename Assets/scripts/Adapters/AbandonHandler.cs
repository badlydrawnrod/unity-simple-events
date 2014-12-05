using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public interface IAbandonHandler : IEventSystemHandler
{
    void OnAbandon();
}
