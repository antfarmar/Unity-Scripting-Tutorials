using UnityEngine;
using System.Collections;


/*
* Delegates can be thought of simply as containers for/pointers to functions.
* Delegates can be passed around or used like a variable.
* Delegates can have values assigned to them and be changed at runtime.
* Delegates contain functions, just as variables contain data.
*/
public class DelegateScript : MonoBehaviour
{

    delegate void MyDelegate(int num);  // delegate declaration: a method signature
    MyDelegate myDelegate;              // member variable of type MyDelegate


    void Start()
    {
        myDelegate = PrintNum;          // assign the delegate to the method
        myDelegate(50);                 // use the delegate

        myDelegate = DoubleNum;         // re-assign the delegate to the other method
        myDelegate(50);                 // re-use the delegate
    }



    // Methods with the same signature as the delegate MyDelegate.

    void PrintNum(int num)
    {
        print("Print Num: " + num);
    }


    void DoubleNum(int num)
    {
        print("Double Num: " + num * 2);
    }
}