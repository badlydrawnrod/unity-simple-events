using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class PlayAdapter : MonoBehaviour
{
    public void PlayRequested()
    {
        ExecuteEvents.ExecuteHierarchy<IPlayHandler>(gameObject, null, (f, a) => f.OnPlay());
    }
}
