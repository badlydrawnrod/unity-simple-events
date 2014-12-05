using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class BackAdapter : MonoBehaviour
{
    public void BackRequested()
    {
        ExecuteEvents.ExecuteHierarchy<IBackHandler>(gameObject, null, (f, a) => f.OnBack());
    }
}
