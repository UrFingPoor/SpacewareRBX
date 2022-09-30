using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace SpacewareRBX
{
    public class DownloadHandler
    {
        public static void InitializeDownloadHandler()
        {
            try
            {
                var task = Task.Run(() => MakeRequest(new Uri($"{Config.Host}software/exploitapi/latestdata.json"))); task.Wait();
                dynamic apiresp = JObject.Parse(task.Result);
                Config.Injector = apiresp["qdRFzx_exe"]; //injector download
                Config.DependencyDLL = apiresp["injDep"]; // injector dependency
                Config.ExecutorDLL = apiresp["exploit-module"].download; //Lua interpreter\Executor
                Config.Version = apiresp["exploit-module"].version; //epxloit version
                Config.Patched = apiresp["exploit-module"].patched; //patched check
            }
            catch (NullReferenceException Error)
            {
                MessageBox.Show(Error.StackTrace, "Oh Shit!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public static async void Download_Injector()
        {
            await DownloadFile(Config.Injector, $"{AppDomain.CurrentDomain.BaseDirectory}\\finj.exe");
            await DownloadFile(Config.DependencyDLL, $"{AppDomain.CurrentDomain.BaseDirectory}\\kernel64.sys.dll");
            await DownloadFile(Config.ExecutorDLL, $"{AppDomain.CurrentDomain.BaseDirectory}\\exploit-main.dll");
            Task.WaitAll();

            Process.Start(AppDomain.CurrentDomain.BaseDirectory + "finj.exe");
            MessageBox.Show(
                $"[Info] Injection Process, Started!",
                "Alert",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

        }
        public static void CleanUp()
        {
            string[] FileNames =
            {
                "exploit-main.dll",
                "kernel64.sys.dll",
                "finj.exe"
            };

            for (int i = 0; i < FileNames.Length; i++)
            {
                if (i == FileNames.Length)
                    break;
                if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory + FileNames[i]}"))
                {
                    File.Delete($"{AppDomain.CurrentDomain.BaseDirectory + FileNames[i]}");
                    MessageBox.Show(
                        $"[Info] Removed {AppDomain.CurrentDomain.BaseDirectory + FileNames[i]}, Done!",
                        "Alert",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
        }
        //Makes a get request to api to obtain response.
        private static async Task<string> MakeRequest(Uri u)
        {
            var response = string.Empty;
            using (var client = new HttpClient())
            {
                HttpResponseMessage result = await client.GetAsync(u);
                if (result.IsSuccessStatusCode)
                    response = await result.Content.ReadAsStringAsync();
            }
            return response;
        }

        private static async Task DownloadFile(string Url, string pathToSave)
        {
            using (var client = new HttpClient())
            using (var res = await client.GetAsync(Url))
            using (var resStream = await res.Content.ReadAsStreamAsync())
            using (var fileStream = File.Create(pathToSave))
                resStream.CopyTo(fileStream);
        }
    }
}
