using UnityEngine;


public class TurnColorScript : MonoBehaviour
{
    // Subscribe when enabled.
    void OnEnable()
    {
        EventManager.OnClicked += TurnColor;
    }


    // Unsubscribe when disabled. Prevents memory leaks & errors.
    void OnDisable()
    {
        EventManager.OnClicked -= TurnColor;
    }


    // The method with the same signature as the delegate ClickAction().
    void TurnColor()
    {
        Color col = new Color(Random.value, Random.value, Random.value);
        GetComponent<Renderer>().material.color = col;
    }
}