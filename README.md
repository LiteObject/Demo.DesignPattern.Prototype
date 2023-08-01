# Prototype Design Pattern

The Prototype design pattern is a creational design pattern that provides a 
way to create new objects by copying existing ones, rather than creating new 
objects from scratch.

 It allows you to create new objects by cloning an existing object that serves 
 as a prototype.

 This pattern is useful when creating new objects is expensive in terms of 
 time and resources, and when the initialization process is complex or requires 
 external dependencies.

## Shallow Copy & Deep Copy

In programming, a copy of an object can be created using either a shallow copy 
or a deep copy method. The difference between the two methods lies in how they 
duplicate the original object.

The key difference between shallow copy and deep copy is that a shallow copy 
creates a new object that points to the same memory location as the original 
object, while a deep copy creates a new object with new memory that is an exact 
replica of the original object.

