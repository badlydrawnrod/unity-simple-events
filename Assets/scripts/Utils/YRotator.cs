using UnityEngine;
using System.Collections;

public class YRotator : MonoBehaviour
{
    public float rotationRate;

    void Update()
    {
        transform.Rotate(0, rotationRate * Time.deltaTime, 0);
    }
}
