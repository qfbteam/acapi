## 📢 Message Box

Show a simple message box with text and title:

```csharp
acapi.Msg.Show("Hello!", "My Title");
```

---

## ⏱️ Timer

Pause execution for a number of seconds:

```csharp
acapi.Timer.Wait(5); // Waits 5 seconds
```

---

## ❌ Close

Static helper class for closing forms or the entire application.

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
```

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
* Falls back to `Environment.Exit(0)` and `Process.Kill()` to ensure full termination.
* Leaves no residual processes in memory.

---

### 🧠 Notes

* `Close.Form` is ideal for multi-window apps where only one window needs to close.
* `Close.App` is useful for quick exits, error handling, or "Exit" buttons.

---

## ✖️ Close Process

Tries to find a process by name and asks the user whether to close it:

```csharp
acapi.CloseProcess.AskToClose("notepad"); // tries to find "notepad.exe"
```

---

## 🎮 Discord Rich Presence (RPC)

Easily integrate Discord Rich Presence to show your app’s status on Discord.

### ⚙️ Setup

Make sure you have registered your app on the [Discord Developer Portal](https://discord.com/developers/applications) to get your **Client ID**.

Add the NuGet package `DiscordRPC` to your project.

---

### 🔹 Initialize Discord RPC

```csharp
acapi.DiscordRichPresence.Init("your_client_id_here");
```

---

### 🔸 Update Presence

Set your custom status like "Playing", "Watching", etc.

```csharp
acapi.DiscordRichPresence.UpdatePresence("Playing", "A.C.A.P.I.");
```

---

### 🔹 Shutdown

Call this when closing your app to cleanly disconnect:

```csharp
acapi.DiscordRichPresence.Shutdown();
```

---

### ⚠️ Notes

* Replace `"your_client_id_here"` with your actual Discord App Client ID.
* Customize the large image and text in the DLL code if needed.
* This feature depends on the `DiscordRPC` library, make sure it is installed.

---

**Example usage:**

```csharp

class Program
{
    static void Main()
    {
        acapi.DiscordRichPresence.Init("your_client_id_here");
        acapi.DiscordRichPresence.UpdatePresence("Playing", "A.C.A.P.I.");

        Console.WriteLine("Press ENTER to exit...");
        Console.ReadLine();

        DiscordRichPresence.Shutdown();
    }
}
```

## Github 🐈

Just open official repository

```csharp
acapi.Github.Open()
```

