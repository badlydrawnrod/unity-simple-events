using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class HelpAdapter : MonoBehaviour
{
    public void HelpRequested()
    {
        ExecuteEvents.ExecuteHierarchy<IHelpHandler>(gameObject, null, (f, a) => f.OnHelp());
    }
}
