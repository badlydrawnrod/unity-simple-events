using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class LifecycleAdapter : MonoBehaviour
{
    public void Activating()
    {
        ExecuteEvents.ExecuteHierarchy<ILifecycleHandler>(gameObject, null, (f, a) => f.OnActivating());
    }

    public void Activated()
    {
        ExecuteEvents.ExecuteHierarchy<ILifecycleHandler>(gameObject, null, (f, a) => f.OnActivated());
    }

    public void Deactivating()
    {
        ExecuteEvents.ExecuteHierarchy<ILifecycleHandler>(gameObject, null, (f, a) => f.OnDeactivating());
    }

    public void Deactivated()
    {
        ExecuteEvents.ExecuteHierarchy<ILifecycleHandler>(gameObject, null, (f, a) => f.OnDeactivated());
    }
}
