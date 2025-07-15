# 📦 Changelog

Here you’ll find all the important updates and changes made to this project.

---

## \[0.4.5-Leaked] — *Latest Update*

### ✅ What’s New:

* Added new features and improvements to enhance stability and performance.
* Improved integration with `DiscordRichPresence` for smoother status updates.
* Enhanced the `Close` class with better handling for edge cases when closing forms and applications.
* Updated internal timers and message display utilities for more accurate timing and clearer notifications.

### 🛠️ Fixes:

* Fixed several bugs related to process termination and resource cleanup.
* Resolved minor UI glitches in message boxes.
* Improved error handling in shutdown sequences to prevent unexpected crashes.

🔗 **[Download 0.4.5-Leaked here](https://github.com/qfbteam/acapi/releases/tag/AcApiBeta4.5Leaked)**


## \[0.4.0-beta] — *Currently Stable*

### ✅ What’s New:

* Added a static helper class called `Close` to make closing things easier:

  * `Close.Form(Form form)` closes a specific Windows Form.
  * `Close.App()` safely or forcefully closes the application.
  * To close third-party processes (like `"notepad"`), use `CloseProcess.AskToClose(string processName)`.

* Integrated `DiscordRichPresence` with these methods:

  * `Init(string clientId)` — starts the Discord presence.
  * `UpdatePresence(string state, string details)` — updates the status.
  * `Shutdown()` — stops the integration.

### 🛠️ Fixes:

* Improved shutdown methods to use safer, more reliable techniques.
* Fixed issues when closing processes via `CloseProcess`.

🔗 **[Download 0.4.0-beta here](https://github.com/qfbteam/acapi/releases/tag/AcApiBeta4.0)**

---

## \[0.3.2-beta] — *Close Feature Added & End of First Beta*

### ✅ What’s New:

* Introduced the `Close` class to help close forms and apps:

  * `Close.Form(Form form)` closes specific Windows Forms.
  * `Close.App()` safely or forcefully closes the app.

> This version marks the end of the **first beta phase** and the start of bigger features.

🔗 **[Download 0.3.2-beta here](https://github.com/qfbteam/acapi/releases/tag/AcApiBeta3.2)**

---

## \[0.1.9-beta] — *First Compiled Release*

### ✅ What’s New:

* Added `Msg.Show(title, text)` to display native Windows message boxes.
* Added `Timer.Wait(seconds)` to pause code execution for a set time.

> This was the first release to make the compiled DLL publicly available.
> Source code became available starting from version `0.0.7-beta`.

🔗 **[Download 0.1.9-beta here](https://github.com/qfbteam/acapi/releases/tag/AcApi)**

---

## \[0.0.7-beta] — *Initial Source-Only Release*

### 📄 Metadata only:

The project was published with just a simple version identifier—no working C# code yet.

> Later, in `0.3.2-beta`, the original source was deleted.
> It was restored in `<0.3.3-beta (fixed invisible)`.
