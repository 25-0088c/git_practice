## Payroll System Summary

This C# console application is a simple **Payroll System** that calculates an employee’s gross pay, taxes, and net pay based on hours worked and hourly rate.

### Features

* Accepts employee name, hours worked, and hourly rate
* Validates user input to ensure positive numbers only
* Calculates:

  * **Gross Pay**
  * **15% Tax Deduction**
  * **Net Pay**
* Supports **overtime pay** for hours worked beyond 40 hours
* Displays a formatted pay slip

### Functions Used

* `GetValidInput()` – Validates numeric input
* `CalculateGrossPay()` – Computes regular and overtime pay
* `CalculateTaxes()` – Calculates 15% tax deduction
* `PrintPayStub()` – Displays payroll summary

### Technologies

* Language: **C#**
* Platform: **.NET Console Application**

### Sample Output

```text
---------------------------------------
               PAY SLIP
---------------------------------------
Employee name : John
Gross Pay : P5000
Taxes (15%) : P750
Net pay : P4250
```

### Purpose

This project demonstrates the use of:

* Methods/Functions
* Conditional Statements
* Loops
* Input Validation
* Basic Payroll Computation
* Console Output Formatting
