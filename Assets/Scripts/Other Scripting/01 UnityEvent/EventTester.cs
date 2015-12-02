using UnityEngine;
using UnityEngine.Events;

public class EventTester : MonoBehaviour
{

    public UnityEvent[] events;     // To be populated in the Inspector.


    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha0))
            TriggerEvent(0);
        else if(Input.GetKeyDown(KeyCode.Alpha1))
            TriggerEvent(1);
        else if(Input.GetKeyDown(KeyCode.Alpha2))
            TriggerEvent(2);
    }


    public void TriggerEvent(int index)
    {
        if(index >= 0 && index < events.Length)
            events[index].Invoke();
    }
}