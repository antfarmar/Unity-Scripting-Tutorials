using UnityEngine;

/*
* Events are useful for alerting other classes that something has happened.
* Events function very similar to public multicast delegates.
* Events are just specialized delegates.
* Events are used instead of delegates because they have inherent security.
* Events only allow other classes to Subscribe/Unsubscribe.
* Events also prevent overriding. 
*/
public class EventManager : MonoBehaviour
{
    public delegate void ClickAction();             // the delegate variable Clickaction
    public static event ClickAction OnClicked;      // the static event variable of delegate type ClickAction


    // The GUI Button to invoke the event.
    void OnGUI()
    {
        if(GUI.Button(new Rect(Screen.width / 2 - 50, 5, 100, 30), "Click"))
        {
            if(OnClicked != null)
                OnClicked();
        }
    }
}