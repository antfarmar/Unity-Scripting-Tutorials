using UnityEngine;


public class MulticastScript : MonoBehaviour
{
    delegate void MultiDelegate();      // delegate template/signature
    MultiDelegate myMultiDelegate;      // member variable of type MultiDelegate


    void Start()
    {
        myMultiDelegate += PowerUp;     // assign PowerUp method to the delegate
        myMultiDelegate += TurnRed;     // assign TurnRed method to the same delegate

        if(myMultiDelegate != null)     // avoid errors by checking for unassigned delegate
        {
            myMultiDelegate();          // call the multi-delegate
        }

        myMultiDelegate -= PowerUp;     // unassign PowerUp method from delegate
        myMultiDelegate -= TurnRed;     // unassign TurnRed method from delegate
    }


    // Methods with the SAME SIGNATURE as the delegate MyMultiDelegate

    void PowerUp()
    {
        print("Orb is powering up!");
    }


    void TurnRed()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}