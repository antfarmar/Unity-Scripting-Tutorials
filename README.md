# Unity Scripting Tutorials
_Implementations of select Unity Scripting Tutorials_

[Unity Scripting Tutorials (Videos)](https://unity3d.com/learn/tutorials/topics/scripting)

# Contents

[INTERMEDIATE GAMEPLAY SCRIPTING](#intermediate-gameplay-scripting)

- 14. [Coroutines](#14-coroutines)
- 16. [Delegates](#16-delegates)
- 18. [Events](#18-events)


## INTERMEDIATE GAMEPLAY SCRIPTING


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