using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using DiscordRPC;
using DiscordRPC.Logging;
using System.Windows.Forms;

namespace acapi
{
    public static class Msg
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern int MessageBoxW(
            IntPtr hWnd,
            string text,
            string caption,
            uint type);

        public static void Show(string text, string title)
        {
            MessageBoxW(IntPtr.Zero, text, title, 0x0);
        }
    }

    public static class Timer
    {
        public static void Wait(int seconds)
        {
            if (seconds <= 0)
                return;

            Thread.Sleep(seconds * 1000);
        }
    }

    public static class Close
    {
        /// <summary>
        /// Fecha um formulário específico.
        /// </summary>
        /// <param name="form">A instância do Form que será fechada.</param>
        public static void Form(Form form)
        {
            if (form != null && !form.IsDisposed)
            {
                form.Close();
            }
        }

        /// <summary>
        /// Encerra completamente a aplicação.
        /// </summary>
        public static void App()
        {
            // Tenta encerrar processos filhos e o próprio app
            try
            {
                // Fecha o app "limpo"
                Application.Exit();

                // Fecha qualquer coisa que restar
                Environment.Exit(0);
            }
            catch
            {
                // Caso ocorra algum erro, força encerramento
                Process.GetCurrentProcess().Kill();
            }
        }
    }

    public static class CloseProcess
    {
        /// <summary>
        /// Busca processos pelo nome e avisa o usuário, permitindo fechar ou deixar aberto.
        /// </summary>
        /// <param name="processName">Nome do processo (sem extensão ".exe")</param>
        public static void AskToClose(string processName)
        {
            var processes = Process.GetProcessesByName(processName);

            if (processes.Length == 0)  
            {
                MessageBox.Show($"Process '{processName}' not found.", "Process Checker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var proc in processes)
            {
                var msg = $"Process '{processName}' (ID: {proc.Id}) is running.\nDo you want to close it?";
                var result = MessageBox.Show(msg, "Process Checker", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        proc.Kill();
                        proc.WaitForExit(1000); // espera até 3 segundos para fechar
                        MessageBox.Show($"Process '{processName}' (ID: {proc.Id}) closed successfully.", "Process Checker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to close process '{processName}' (ID: {proc.Id}).\nError: {ex.Message}", "Process Checker", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Process '{processName}' (ID: {proc.Id}) left running.", "Process Checker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }

    public static class DiscordRichPresence
    {
        private static DiscordRpcClient client;

        /// <summary>
        /// Inicializa a conexão com o Discord RPC usando o Client ID da sua aplicação.
        /// </summary>
        /// <param name="clientId">Client ID do app Discord.</param>
        public static void Init(string clientId)
        {
            if (client != null)
                client.Dispose();

            client = new DiscordRpcClient(clientId);
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.Initialize();
        }

        /// <summary>
        /// Atualiza o status de presença do Discord.
        /// </summary>
        /// <param name="state">Estado da atividade (ex: "Playing", "Watching", etc).</param>
        /// <param name="details">Descrição da atividade.</param>
        public static void UpdatePresence(string state, string details)
        {
            if (client == null)
                throw new InvalidOperationException("Discord RPC não inicializado. Chame Init() antes.");

            client.SetPresence(new RichPresence
            {
                Details = details,
                State = state,
                Timestamps = Timestamps.Now,
                Assets = new Assets
                {
                    LargeImageKey = "default",
                    LargeImageText = "A.C.A.P.I."
                }
            });
        }

        /// <summary>
        /// Encerra a conexão com o Discord RPC.
        /// </summary>
        public static void Shutdown()
        {
            client?.Dispose();
            client = null;
        }
    }



}
