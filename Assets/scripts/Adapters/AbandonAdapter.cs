using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class AbandonAdapter : MonoBehaviour
{
    public void AbandonRequested()
    {
        ExecuteEvents.ExecuteHierarchy<IAbandonHandler>(gameObject, null, (f, a) => f.OnAbandon());
    }
}
