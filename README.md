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