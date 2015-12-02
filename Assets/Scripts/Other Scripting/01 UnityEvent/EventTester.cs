using UnityEngine;
using UnityEngine.Events;

public class EventTester : MonoBehaviour
{

    public UnityEvent[] MyEvents;       // To be populated in the Inspector. Will be serialized.

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