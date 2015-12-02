# Unity Scripting Tutorials
_Implementations of select Unity Scripting Tutorials, complete with basic Scenes_

[Unity Scripting Tutorials (Videos)](https://unity3d.com/learn/tutorials/topics/scripting)



# Contents


[INTERMEDIATE GAMEPLAY SCRIPTING](#intermediate-gameplay-scripting)

- 11. [Extension Methods](#11-extension-methods)
- 14. [Coroutines](#14-coroutines)
- 16. [Delegates](#16-delegates)
- 17. [Attributes](#17-attributes)
- 18. [Events](#18-events)


[EDITOR SCRIPTING](#editor-scripting)

- 01. [Building A Custom Inspector](#01-building-a-custom-inspector)
- 02. [The DrawDefaultInspector Function](#02-the-drawdefaultinspector-function)
- 03. [Adding Buttons To A Custom Inspector](#03-adding-buttons-to-a-custom-inspector)


[OTHER SCRIPTING](#other-scripting)

- 01. [UnityEvent](#01-unityevent)



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




#### 17. Attributes

Attributes allow you to attach additional behavior to the methods and variables you create.
In this video you will learn the format of attributes as well as how to use the `[Range(min, max)]` and `[ExecuteInEditMode]` attributes.

[Unity](https://unity3d.com/learn/tutorials/modules/intermediate/scripting/attributes?playlist=17117) / 
[Youtube](https://www.youtube.com/watch?v=WG_zoE5sZE4)

##### Notes:
* [RangeAttribute](http://docs.unity3d.com/ScriptReference/RangeAttribute.html)
* [ExecuteInEditMode](http://docs.unity3d.com/ScriptReference/ExecuteInEditMode.html)




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



#### 02. The DrawDefaultInspector Function

The DrawDefaultInspector function allows us to easily recreate the default inspector for a script inside a custom inspector. This is very useful if we only want to add new items to the inspector for a script instead of changing the currently existing items.
In this video you will learn how to use the DrawDefaultInspector function.

[Unity](https://unity3d.com/learn/tutorials/modules/intermediate/editor/drawdefaultinspector-function?playlist=17117) / 
[Youtube](https://www.youtube.com/watch?v=jvczWAPryUg)

##### Notes:
* Useful for only adding new items to the default Inspector view of a script.



#### 03. Adding Buttons To A Custom Inspector

In Unity we can add buttons to editor windows so that we can call our functions from our scripts.
Doing so give us the ability to write scripts specifically to improve our workflow.
In this video you will learn how to create buttons in a custom inspector and how to tie them to functions that exist in our scripts.

[Unity](https://unity3d.com/learn/tutorials/modules/intermediate/editor/adding-buttons-to-inspector?playlist=17117) / 
[Youtube](https://www.youtube.com/watch?v=_fNgn3Arpoog)

##### Notes:
* Useful for improving workflow by automating tedious tasks with a single click of a button.



## OTHER SCRIPTING


#### 01. UnityEvent

UnityEvents are a way of allowing user driven callback to be persisted from edit time to run time without the need for additional programming and script configuration.

[Unity Manual Entry](http://docs.unity3d.com/Manual/UnityEvents.html) / 
[Scripting API Entry for `UnityEvent`](http://docs.unity3d.com/ScriptReference/Events.UnityEvent.html)

##### Notes:
* UnityEvents are a way to hook up function calls between GameObjects in the editor and serialize those calls.
* UnityEvents can be edited in the Inspector, serialized, and be given default values.
* The `UnityEvent` class within `UnityEngine.Events` is the way of exposing callbacks on an object in a way that can be modified through the editor.
* UnityEvents can also do what C# `delegate events` do:
	* Be populated with function calls at run-time via `UnityEvent.AddListener()`.
* UnityEvents are useful for a number of things:
	* Content driven callbacks
	* Decoupling systems
	* Persistent callbacks
	* Preconfigured call events