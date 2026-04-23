# CSharp Order Event System

##  Project Overview
This is a console-based Order Processing System built using C#.  
The system processes orders and triggers multiple notifications such as Email, SMS, and Logging using event-driven programming.

---

##  Features
- Order processing system
- Delegate and Multicast Delegate implementation
- Event-based notification system
- Publisher-Subscriber model
- Dynamic subscription and unsubscription
- Loose coupling between components

---

##  Concepts Used
- Delegates
- Multicast Delegates
- Events
- Publisher-Subscriber Model
- Object-Oriented Programming (OOP)

---

##  How It Works
1. An order is created
2. OrderProcessor processes the order
3. Event is triggered
4. Multiple services (Email, SMS, Logger) receive notification
5. Each service performs its own task

---

Project structure 
OrderApp
┣ Program.cs
┣ Order.cs
┣ OrderProcessor.cs
┗ Services
┣ EmailService.cs
┣ SMSService.cs
┗ LoggerService.cs
