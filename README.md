# Prototype Design Pattern in C#

## Overview

This project demonstrates the implementation of the **Prototype Design Pattern** in C#. The pattern is used to create copies of objects without knowing their specific types. The project is set in the context of a game where various characters (Champions and Destroyers) equipped with weapons (Swords and Staffs) compete in different game maps. The main idea is to allow the creation of new instances of characters and weapons by cloning existing ones, while slightly modifying their attributes.

### What is the Prototype Pattern?

The **Prototype Design Pattern** is a creational design pattern that enables object creation by cloning an existing object, known as the prototype. This pattern is particularly useful when creating new instances of a class is costly or complex, and the new objects are similar but not identical to existing ones. 

In the Prototype Pattern:
- **Prototype**: The existing object to be cloned.
- **Client**: The code that creates new objects by asking the prototype to clone itself.
- **Shallow Copy vs. Deep Copy**: The cloning process can be either shallow (where only the top-level structure is duplicated, and references to other objects remain the same) or deep (where all levels of the object are duplicated).

This pattern helps reduce the need for creating instances from scratch, improving performance and flexibility. It is especially useful in scenarios where the cost of initializing a class is high or when there are many possible configurations of an object.

### Key Concepts:

- **Shallow Copying**: This project uses shallow copying to create a duplicate of the object with the same values for its fields. However, reference types like objects inside the prototype are not deeply copied, leading to shared references between the original and the clone.
- **Game Simulation**: The project simulates a simple game where characters with specific elements and weapons compete on various maps. The outcome is influenced by their health, hit points, weapon attributes, and the element of the map.

## Design

### Class Structure

1. **InGameCharacterPrototype** (Abstract Class):
   - An abstract class that defines common properties like `Name`, `Element`, `HealthPoints`, `HitPoints`, and `Weapon`.
   - Provides a method for shallow copying and declares an abstract `Clone()` method to be implemented by concrete subclasses.

2. **Champion** and **Destroyer** (Concrete Classes):
   - Derived from `InGameCharacterPrototype`, these classes implement the `Clone()` method.
   - In the `Clone()` method, additional logic is added to slightly modify the `HitPoints` and `HealthPoints` of the cloned object and clone the `Weapon`.

3. **WeaponPrototype** (Abstract Class):
   - An abstract class defining properties like `Name`, `AttackPower`, and `Cost`.
   - Provides a method for shallow copying and declares an abstract `Clone()` method.

4. **Sword** and **Staff** (Concrete Classes):
   - Derived from `WeaponPrototype`, these classes implement the `Clone()` method.
   - In the `Clone()` method, slight modifications are made to the `AttackPower` and `Cost` of the cloned weapon.

5. **GameMap** (Class):
   - A simple class that represents a map in the game, with properties `MapName` and `ElementOfPower`.

6. **GamePlay** (Class):
   - Manages the gameplay by holding references to two characters (`InGameWarrior` and `InGameDestroyer`), the map on which they are competing, and a list of available maps.
   - Contains the `Winner()` method, which determines the winner based on the characters' attributes and the map's element.

7. **Program** (Class):
   - The entry point of the application, where instances of characters and weapons are created, cloned, and passed to the `GamePlay` class to simulate battles on different maps.

## Design Diagram

The design is represented using a UML Class Diagram, which illustrates the relationships between the classes:
![ClassDiagram_Prototype](https://github.com/user-attachments/assets/6cd8cee8-0c60-4e85-9b88-f83339777c08)

- **Inheritance**: The `Champion` and `Destroyer` classes inherit from the `InGameCharacterPrototype` class, while the `Sword` and `Staff` classes inherit from the `WeaponPrototype` class.
- **Composition**: The `InGameCharacterPrototype` class has a `WeaponPrototype` object, allowing each character to be equipped with a weapon.
- **Associations**: The `GamePlay` class uses instances of `InGameCharacterPrototype` and `GameMap` to simulate the game.


## Environment

This project was created and tested with Visual Studio Community 2022 
