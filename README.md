# acapi
C# DLL for helpers 😄

A.C.A.P.I. = Advanced C# API for Productivity and Integration

---

## License 📜

License: https://github.com/qfbteam/acapi/blob/main/LICENSE.md

---

## 💻 Current Version


| Component          | Version       | Status          | Notes                        |
|--------------------|---------------|-----------------|------------------------------|
| DLL Release        | `0.3.2-beta`  | Latest Stable   | Available for download        |
| Source Code        | `0.1.9-beta`  | In Development  | Actively updated in repository|
| Planned DLL Update  | `0.4.0-beta`  | Upcoming        | New features & improvements   |
| How to Use (Docs)  | `0.4.0-beta`  | Latest Updated  | Documentation for new features|


---

## 💡 Tip

To simplify usage, add this at the top of your file:

```csharp
using acapi;
```

Then you can just call:

```csharp
Msg.Show("Done waiting!", "Timer");
```

---

## ✅ How to Use

### 📦 Add Reference

1. Download the DLL.
2. In your C# project:
   - Right-click **References** → **Add Reference** → Browse for your dll `acapi.dll`.

---

## 📢 Message Box

Show a simple message box with text and title:

```csharp
acapi.Msg.Show("Hello!", "My Title");
````

---

## ⏱️ Timer

Pause execution for a number of seconds:

```csharp
acapi.Timer.Wait(5); // Waits 5 seconds
```

---

## ❌ Close

Static helper class for closing forms or the entire application.

---

### 🔹 Close.Form

Closes a specific `Form` instance.

```csharp
using acapi;
using System.Windows.Forms;

public partial class Form1 : Form
{
    private void button1_Click(object sender, EventArgs e)
    {
        Close.Form(this); // Closes only this form
    }
}
````

**Parameters:**

* `Form form` – The Windows Form you want to close.

---

### 🔸 Close.App

Closes the entire application (forcefully if needed).

```csharp
using acapi;

private void button2_Click(object sender, EventArgs e)
{
    Close.App(); // Closes everything immediately
}
```

**Behavior:**

* Attempts graceful shutdown via `Application.Exit()`.
* Fallback to `Environment.Exit(0)` and `Process.Kill()` to ensure full termination.
* Leaves no residual processes in memory.

---

### 🧠 Notes

* `Close.Form` is ideal for multi-window apps where only one window needs to close.
* `Close.App` is useful for quick exits, error handling, or "Exit" buttons.

---

## ✖️ Close Process

It's try to find an process and ask to close:

```csharp
acapi.CloseProcess.AskToClose("notepad"); // try to found "notepad.exe"
```
--- 

Made with 💙 for fun projects.
