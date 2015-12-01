# Unity-Scripting-Tutorials
Implementations of select Unity Scripting Tutorials

[Unity Scripting Video Tutorials](https://unity3d.com/learn/tutorials/topics/scripting)

# Contents

## INTERMEDIATE GAMEPLAY SCRIPTING



#### 16. Delegates

How to create and use delegates to provide complex and dynamic functionality in your scripts.

[Unity](https://unity3d.com/learn/tutorials/modules/intermediate/scripting/delegates?playlist=17117) / 
[Youtube](https://www.youtube.com/watch?v=RSN-A0NZTO0)

##### Notes:
* Delegates can be thought of simply as containers for/pointers to functions.
* Delegates can be passed around or used like a variable.
* Delegates can have values assigned to them and be changed at runtime.
* Delegates contain functions, just as variables contain data.



#### 18. Events

How to create a dynamic "broadcast" system using Delegate Events.

[Unity](https://unity3d.com/learn/tutorials/modules/intermediate/scripting/events?playlist=17117) / 
[Youtube](https://www.youtube.com/watch?v=6qyR73EO68w)

##### Notes:
* Events are useful for alerting other classes that something has happened.
* Events function very similar to public multicast delegates.
* Events are just specialized delegates.
* Events are used instead of delegates because they have inherent security.
	* Events only allow other classes to Subscribe/Unsubscribe.
	* Events also prevent overriding. 