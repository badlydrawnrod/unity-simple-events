using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public interface ILifecycleHandler : IEventSystemHandler
{
    void OnActivating();
    void OnDeactivating();
    void OnActivated();
    void OnDeactivated();
}
