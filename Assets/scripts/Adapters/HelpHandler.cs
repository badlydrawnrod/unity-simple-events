using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public interface IHelpHandler : IEventSystemHandler
{
    void OnHelp();
}
