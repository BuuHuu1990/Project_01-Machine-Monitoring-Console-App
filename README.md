# Machine Monitoring Console App

Small C# console application demonstrating object-oriented programming and interface-based design.

The application simulates a simple machine monitoring system where machines can change status and raise alarms.

---

## Technologies

- C#
- .NET
- Object-Oriented Programming
- Interfaces
- Console Application

---

## Features

- Create and manage machines
- Change machine status (Start / Stop / Error)
- Generate machine alarms
- Display machine overview
- Notification system using interfaces

---

## Architecture

The project follows a simple layered structure.

Models  
- Machine  
- Alarm  
- MachineStatus  
- AlarmSeverity  

Managers  
- MachineManager (business logic)

Services  
- INotificationService  
- ConsoleNotificationService  

Program  
- Application entry point

---

## Learning Goals

This project focuses on practicing:

- Object-Oriented Programming
- Encapsulation
- Domain modeling
- Interface-based design
- Separation of responsibilities

---

## Example Output

Example console output when running the application:

Machine 1 | Mixer | Running  
Machine 2 | Filler | Error  

Alarm: Temperature limit exceeded

---

## How to Run

Clone the repository and run the project:
