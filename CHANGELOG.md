## [0.4.0-beta] - *Current Stable*

### ✅ Added
- `Close` static helper class:
  - `Close.Form(Form form)` – Closes a specific Windows Form.
  - `Close.App()` – Gracefully or forcefully terminates the entire application.
  - `CloseProcess.AskToClose(string processName)` – Finds and prompts to close external processes (e.g., "notepad").

- `DiscordRichPresence` integration:
  - `Init(string clientId)` – Initializes Discord RPC.
  - `UpdatePresence(string state, string details)` – Updates status on user's Discord.
  - `Shutdown()` – Cleanly disconnects the RPC client.
  - Requires `DiscordRPC` NuGet package and valid Discord Application ID.

---

### 🛠️ Fixed
- Closing behavior:
  - Ensured `Close.App()` uses fallback (`Environment.Exit()` and `Process.Kill()`) when `Application.Exit()` fails.
  - Prevented residual processes from remaining after closing.
  - Improved reliability when attempting to close third-party processes (`CloseProcess.AskToClose`).

---

### 📘 Notes
- `Close.App()` is useful for full shutdowns via menu/exit buttons.
- Discord RPC support is optional and depends on the `DiscordRPC.dll` being present.
