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
                var request = Task.Run(() => MakeRequest(new Uri($"{Config.Host}software/exploitapi/latestdata.json"))); request.Wait();
                dynamic apiresp = JObject.Parse(request.Result);
                Config.Injector = apiresp["qdRFzx_exe"]; //injector download
                Config.DependencyDLL = apiresp["injDep"]; // injector dependency
                Config.ExecutorDLL = apiresp["exploit-module"].download; //Lua interpreter\Executor
                Config.Version = apiresp["exploit-module"].version; //epxloit version
                Config.Patched = apiresp["exploit-module"].patched; //patched check
                Config.BasePath = Environment.CurrentDirectory;
            }
            catch (NullReferenceException Error)
            {
                MessageBox.Show(Error.StackTrace, "Oh Shit!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public static async void Download_Injector()
        {
            await DownloadFile(Config.Injector, $"{Config.BasePath}\\finj.exe");
            await DownloadFile(Config.DependencyDLL, $"{Config.BasePath}\\kernel64.sys.dll");
            await DownloadFile(Config.ExecutorDLL, $"{Config.BasePath}\\exploit-main.dll");
            Task.WaitAll();
            Process.Start(AppDomain.CurrentDomain.BaseDirectory + "finj.exe");
            MessageBox.Show($"[Info] Injection Process, Started!", "Alert",MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (i == FileNames.Length) break;
                if (File.Exists($"{Config.BasePath + FileNames[i]}"))
                {
                    File.Delete($"{Config.BasePath + FileNames[i]}");
                    MessageBox.Show($"[Info] Removed {Config.BasePath + FileNames[i]}, Done!","Alert",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }
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
