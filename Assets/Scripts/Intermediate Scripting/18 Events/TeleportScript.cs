using UnityEngine;


public class TeleportScript : MonoBehaviour
{
    // Subscribe when enabled.
    void OnEnable()
    {
        EventManager.OnClicked += Teleport;     // subscribe to the event
    }


    // Unsubscribe when disabled. Prevents memory leaks & errors.
    void OnDisable()
    {
        EventManager.OnClicked -= Teleport;     // unsubscribe to the event
    }


    // The method with the same signature as the delegate ClickAction().
    void Teleport()
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(-1.0f, 1.0f);
        transform.position = pos;
    }
}