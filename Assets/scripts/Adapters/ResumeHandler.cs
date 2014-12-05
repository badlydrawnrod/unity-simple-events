using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public interface IResumeHandler : IEventSystemHandler
{
    void OnResume();
}
