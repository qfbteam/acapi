# 📦 Changelog

Any significant modifications to this project will be recorded here.

---

## [0.4.0-beta] * Presently Stable*

### ✅ Added: `Close` static helper class
  - `Close.Form(Form form)` - Closes a particular Windows Form.
  - `Close.App()` - Ends the application either gently or firmly.
  To close third-party processes (like `"notepad"`), use `CloseProcess.AskToClose(string processName)`.

Integration of `DiscordRichPresence`:
  - `Init(string clientId)`
  - `UpdatePresence(string state, string details)`
  - `Shutdown()`

### 🛠️ Repaired: Safe fallback shutdown techniques are now used for closing methods.
- Using `CloseProcess`, process-closing inconsistencies were fixed.

🔗 **[Get 0.4.0-beta](https://github.com/qfbteam/acapi/releases/tag/AcApiBeta4.0)**

---

## [0.3.2-beta] - *Close Feature Update and Initial Beta Termination*

### ✅ Added: The `Close` class was presented.
  - `Close.Form(Form form)` - Closes particular Windows forms.
  - `Close.App()` - Safely or firmly ends the entire application.
  
> 🧩 Signals the end of the **first beta phase** and the start of more extensive features.

🔗 **[Get 0.3.2-beta](https://github.com/qfbteam/acapi/releases/tag/AcApiBeta3.2)**

---

## [0.1.9-beta] - *First Compiled Version*

### ✅ `Msg.Show(title,text)` was added; it shows a native Windows message box.
- Timer.Wait(seconds)`: This pauses the execution of code for a specified amount of time.

> 📦 The first version to make the compiled DLL available to the general public. The source code was first made available in version `0.0.7-beta`.

🔗 **[Get 0.1.9-beta](https://github.com/qfbteam/acapi/releases/tag/AcApi)**

---

## [0.0.7-beta] *First Source-Only Publication*

### 📄 Metadata Only: The project was published with just a simple {Version` identifier.
- There is currently no working C# codebase.

> 🗑️ Later, during `0.3.2-beta`, the original source was deleted.  
> <0.3.3-beta (fixed invisible)` brought back Codebase.
