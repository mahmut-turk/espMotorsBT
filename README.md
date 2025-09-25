# ESP32 Motors Controller - C# Windows Forms

This project is a **C# Windows Forms** application that controls an ESP32 via Bluetooth, allowing you to operate an LED, stepper motor, and servo motor.

## Features

- Send commands to ESP32 via Bluetooth:
  - Toggle LED: `L1`
  - Step motor forward: `S+`
  - Step motor backward: `S-`
  - Servo motor 0°: `SV0`
  - Servo motor 90°: `SV90`
- View debug messages on the Serial Monitor
- Simple and user-friendly Windows Forms interface

## Requirements

- Windows operating system
- .NET Framework (WinForms)
- Bluetooth connection with ESP32
- C# Visual Studio (Windows Forms) environment

## Usage

1. Power on the ESP32 and pair it via Bluetooth.
2. Run the C# application.
3. Set the COM port and baud rate to match the ESP32.
4. Use the buttons to control the LED, stepper motor, and servo motor.

## License

This project is licensed under the **MIT License**.
