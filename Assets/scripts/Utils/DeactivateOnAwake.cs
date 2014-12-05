using UnityEngine;

public class DeactivateOnAwake : MonoBehaviour
{
    void Awake()
    {
        gameObject.SetActive(false);
    }
}
