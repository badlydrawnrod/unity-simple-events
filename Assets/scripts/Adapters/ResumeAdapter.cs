using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ResumeAdapter : MonoBehaviour
{
    public void ResumeRequested()
    {
        ExecuteEvents.ExecuteHierarchy<IResumeHandler>(gameObject, null, (f, a) => f.OnResume());
    }
}
