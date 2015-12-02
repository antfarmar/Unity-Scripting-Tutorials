using UnityEngine;
using UnityEngine.Events;

public class EventTester : MonoBehaviour
{

    // Generic UnityEvents: Up to 4 arguments. This class definition has 1 int.
    [System.Serializable]
    public class IntegerEvent : UnityEvent<int> { }
    public IntegerEvent MyIntegerEvent;     // Invoke will take an int parameter.


    // An array of events. Serialized in the Inspector.
    public UnityEvent[] MyEvents;       // To be populated in the Inspector. Will be serialized.

    // A single event to be populated at runtme.
    private UnityEvent MyRuntimeEvent;  // Listener hooked up at runtime. Won't be serialized.


    void Start()
    {
        if(MyRuntimeEvent == null)
            MyRuntimeEvent = new UnityEvent();

        MyRuntimeEvent.AddListener(GetComponent<SphereBehaviours>().RandomPosition);
    }


    public void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space) && MyRuntimeEvent != null)
            MyRuntimeEvent.Invoke();

        if(Input.GetKeyDown(KeyCode.Return) && MyIntegerEvent != null)
            MyIntegerEvent.Invoke(8);

        if(Input.GetKeyDown(KeyCode.Alpha0))
            TriggerEvent(0);
        else if(Input.GetKeyDown(KeyCode.Alpha1))
            TriggerEvent(1);
        else if(Input.GetKeyDown(KeyCode.Alpha2))
            TriggerEvent(2);

    }


    public void TriggerEvent(int index)
    {
        if(index >= 0 && index < MyEvents.Length)
            MyEvents[index].Invoke();
    }
}