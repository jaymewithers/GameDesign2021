using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehaviour : MonoBehaviour
{
    public UnityEvent startEvent, onTriggerEnterEvent;
    private void Start()
    {
        startEvent.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        onTriggerEnterEvent.Invoke();
    }
}