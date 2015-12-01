# Unity Scripting Tutorials
_Implementations of select Unity Scripting Tutorials_

[Unity Scripting Tutorials (Videos)](https://unity3d.com/learn/tutorials/topics/scripting)

# Contents

[INTERMEDIATE GAMEPLAY SCRIPTING](#intermediate-gameplay-scripting)

- 11. [Extension Methods](#11-extension-methods)
- 14. [Coroutines](#14-coroutines)
- 16. [Delegates](#16-delegates)
- 18. [Events](#18-events)

[EDITOR SCRIPTING](#editor-scripting)

- 01. [Building A Custom Inspector](#01-building-a-custom-inspector)


## INTERMEDIATE GAMEPLAY SCRIPTING


#### 11. Extension Methods

How to create, implement, and call an extension method.

[Unity](https://unity3d.com/learn/tutorials/modules/intermediate/scripting/extension-methods?playlist=17117) / 
[Youtube](https://www.youtube.com/watch?v=v2ONQAqqLDc)

##### Notes:
* Extension Methods are a way of adding functionality to a type:
	* without having to create a derived type.
	* without changing the original type.
* Perfect for occasions when you cannot edit the original type's source. (e.g. Components)
* Extension methods must be placed in a non-generic `static` class.
* Extension methods are used liked instance methods, but they too are `static`.
* Use of the `this` keyword in the parameters makes the static method an extension method.
  * The variable following `this` denotes which class the method becomes an extension of.
  * e.g. `public static void ResetTransformation(this Transform trans)`



#### 14. Coroutines

How to create coroutines and use them to achieve complex behaviors.

[Unity](https://unity3d.com/learn/tutorials/modules/intermediate/scripting/coroutines?playlist=17117) / 
[Youtube](https://www.youtube.com/watch?v=bM3CXzj5xM4)

##### Notes:
* Coroutines are functions that execute in intervals.



#### 16. Delegates

How to create and use delegates to provide complex and dynamic functionality in your scripts.

[Unity](https://unity3d.com/learn/tutorials/modules/intermediate/scripting/delegates?playlist=17117) / 
[Youtube](https://www.youtube.com/watch?v=RSN-A0NZTO0)

##### Notes:
* Delegates can be thought of simply as containers for/pointers to functions.
* Delegates can be passed around or used like a variable.
* Delegates can have values assigned to them and be changed at runtime.
* Delegates contain functions, just as variables contain data.
* Delegates also have the ability to be ***Multicast:***
	* use a single delegate variable to represent multiple methods at the same time.



#### 18. Events

How to create a dynamic "broadcast"/"messaging" system using C# Publisher/Subscriber Delegate Events.

[Unity](https://unity3d.com/learn/tutorials/modules/intermediate/scripting/events?playlist=17117) / 
[Youtube](https://www.youtube.com/watch?v=6qyR73EO68w)

##### Notes:
* Events are useful for alerting other classes that something has happened.
* Events function very similar to public multicast delegates.
* Events are just specialized delegates.
* Events are used instead of delegates because they have inherent security.
	* Events only allow other classes to Subscribe/Unsubscribe.
	* Events also prevent overriding. 



## EDITOR SCRIPTING


#### 01. Building A Custom Inspector

Custom inspectors allow you to add a lot of power and flexibility to your workflow.
In this video you will learn about the benefits of custom inspectors as well as how to build them.

[Unity](https://unity3d.com/learn/tutorials/modules/intermediate/editor/building-custom-inspector?playlist=17117) / 
[Youtube](https://www.youtube.com/watch?v=GDSw2CB2Zk0)

##### Notes:
* Unity requires that you place custom editor scripts in an "Editor" folder.
* Scripts must import `using UnityEditor;` namespace.
* Class definition must have attribute `[CustomEditor(typeof(YourScript))]`.
* Scripts must implement `public override void OnInspectorGUI()` which is called everytime the Inspector is drawn.