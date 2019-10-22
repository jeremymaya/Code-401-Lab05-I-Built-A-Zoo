# Code-401-Lab05-I-Built-A-Zoo

## I Built a Zoo!

Lab05 - I Built A Zoo

*Author: Kyungrae Kim*

----

## Description
This is a console applocation that simulates a zoo using classes and Object-Oriented Programming (OOP). This lab demonstates all four OOP principlesbasic understanding of C# classes and objects.

---

### Getting Started
Clone this repository to your local machine.

```
$ git clone https://github.com/jeremymaya/Code-401-Lab05-I-Built-A-Zoo.git
```

### To run the program from Visual Studio:
Select ```File``` -> ```Open``` -> ```Code-401-Lab05-I-Built-A-Zoo```

Next navigate to the location you cloned the Repository.

Double click on the ```IBuiltAZoo``` directory.

Then select and open ```IBuiltAZoo.sln```

---

### Interface
An interface contains definitions for a group of related functionalities that a class or a struct can implement. It acts like a contract that specifies if a particular class meets certain expectations so that other classes can rely on it.

This console application has three interfaces:
1. IKeepWarm
    * Implemented in Mammal.cs
    ```C#
    public string KeepWarm(bool fur)
    {
        return "This fur keeps me warm :D";
    }
    ```
2. IRun
    * Implemented in Tiger.cs
    ```C#
    public void Run()
    {
        Console.WriteLine("I run fast and swiftly");
    }
    ```
3. ISwim
    * Implemented in Tiger.cs
    * Implemented in Bear.cs
    ```C#
    public string Swim()
    {
        return "I may be a cat but I swimmm";
    }
    ```

### Visuals


---

### Change Log
1.2: *Lab 06 Completed* - 21 Oct 2019 12:00 PM
1.2: *Lab 06 Started* - 21 Oct 2019 8:50 AM
1.1: *Lab 05 Completed* - 21 Oct 2019 11:55 PM
1.1: *Lab 05 Started* - 21 Oct 2019 8:50 AM
