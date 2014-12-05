using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class PauseAdapter : MonoBehaviour
{
    public void PauseRequested()
    {
        ExecuteEvents.ExecuteHierarchy<IPauseHandler>(gameObject, null, (f, a) => f.OnPause());
    }
}
