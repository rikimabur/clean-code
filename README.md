# Separation of concerns (SoC) Todo

# Don’t repeat yourself (DRY)
The DRY principle advocates the separation of concerns principle and aims to eliminate redundancy.
When we have duplicated logic in your system, encapsulate it and reuse that new encapsulation in multiple places instead. If you find yourself
writing the same or similar code in numerous places, refactor that code into a reusable component instead. Leverage functions, classes, modules, or other abstractions to refactor the code.

# Keep it simple, stupid (KISS) Todo
# You Aren’t Gonna Need It (YAGNI) Todo

# SOLID Principles in .NET

One of the most common acronyms you will come across as a .NET developer is **SOLID**.  
SOLID represents five fundamental object-oriented design principles that help make software more maintainable, scalable, and flexible.

## SOLID stands for:

- **S** – Single Responsibility Principle (SRP)
- **O** – Open/Closed Principle (OCP)
- **L** – Liskov Substitution Principle (LSP)
- **I** – Interface Segregation Principle (ISP)
- **D** – Dependency Inversion Principle (DIP)

---

## Single Responsibility Principle (SRP)

The **Single Responsibility Principle** states that a class should have **only one reason to change**.This means a class should have only one job or responsibility.

## Open/Closed Principle (OCP)

The **Open/Closed Principle** states that software entities like classes and functions should be open for extension but closed for modification. This means that you should be able to add new functionality to an entity without changing its existing code. This principle encourages a more modular and flexible design, which is easier to maintain and extend over time

## Liskov Substitution Principle (LSP)
The LSP states that objects of a superclass should be replaceable with objects of its subclasses without affecting the correctness of the program. That means a subclass should completely adhere to the behavior expected by the superclass. The Liskov Substitution Principle encourages a design where subclasses are substitutable for their base classes.

## Interface Segregation Principle (ISP)
The Interface Segregation Principle (ISP) advises that no client should be forced to depend on methods
it does not use. The ISP promotes the segregation of large interfaces into smaller and more specific
ones so that clients only need to know about the methods that are of interest to them. This approach
leads to a more decoupled and maintainable system.

## Dependency Inversion Principle (DIP)
The Dependency Inversion Principle (DIP) aims to reduce dependencies among high-level modules
and low-level modules by introducing an abstraction layer. Specifically, the DIP states two key things:
- High-level modules should not depend on low-level modules. Both should depend on abstractions.
- Abstractions should not depend upon details. Details should depend upon abstractions.
This principle encourages decoupling in software architecture, which leads to more maintainable
and flexible code.
