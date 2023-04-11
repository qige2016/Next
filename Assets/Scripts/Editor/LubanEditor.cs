using System.Diagnostics;
using System.IO;
using System.Text;
using UnityEditor;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace Editor
{
    public class LubanEditor
    {
        private static bool IsWindows => SystemInfo.operatingSystem.Contains("Win");

        [MenuItem("LubanTools/生成配置表数据及代码")]
        public static void GenerateExcelConfig()
        {
            if (IsWindows)
            {
                DoGenerate_Win("gen_code_json.bat");
            }
            else
            {
                EditorUtility.DisplayDialog("TODO", "TODO:DoGenerate_MacOrLinux", "OK");
                //TODO 还没测
                //DoGenerate_MacOrLinux("gen_code_json.sh");
            }
        }

        [MenuItem("LubanTools/生成配置表测试数据")]
        public static void GenerateTestData()
        {
            if (IsWindows)
            {
                DoGenerate_Win("gen_test_json_data.bat");
            }
            else
            {
                EditorUtility.DisplayDialog("TODO", "TODO:DoGenerate_MacOrLinux", "OK");
                //TODO 还没测
                //DoGenerate_MacOrLinux("gen_test_json_data.sh");
            }
        }

        private static void DoGenerate_Win(string fileName)
        {
            var LogSb = new StringBuilder();
            var ErrorSb = new StringBuilder();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.WorkingDirectory = GetLubanToolPath();
            startInfo.RedirectStandardError = true;
            startInfo.FileName = Path.Combine(GetLubanToolPath(), fileName);
            Process process = Process.Start(startInfo);
            process.OutputDataReceived += (sender, e) => { LogSb.AppendLine(e.Data); };
            process.ErrorDataReceived += (sender, e) => { ErrorSb.AppendLine(e.Data); };
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            process.StandardInput.WriteLine("echo on");
            process.StandardInput.WriteLine(GetLubanToolPath());
            EditorUtility.DisplayProgressBar("Hold on", "Generating config data", 0.5f);
            process.WaitForExit();


            var message = LogSb.ToString();
            Debug.Log(message);

            var errorMessage = ErrorSb.ToString();
            if (!string.IsNullOrWhiteSpace(errorMessage))
                Debug.LogError(errorMessage);
            if (message.Contains("== succ =="))
            {
                EditorUtility.DisplayDialog("提示", "生成成功", "Ok");
            }
            else
            {
                EditorUtility.DisplayDialog("生成失败", "生成配置数据失败！！！\n请查看Console获取详细日志", "Ok");
                Debug.LogError(message);
            }

            EditorUtility.ClearProgressBar();
        }

        private static void DoGenerate_MacOrLinux(string fileName)
        {
            var LogSb = new StringBuilder();
            var ErrorSb = new StringBuilder();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.WorkingDirectory = GetLubanToolPath();
            startInfo.RedirectStandardError = true;
            startInfo.FileName = "/bin/bash";
            startInfo.Arguments = Path.Combine(GetLubanToolPath(), fileName);
            Process process = Process.Start(startInfo);
            process.OutputDataReceived += (sender, e) => { LogSb.AppendLine(e.Data); };
            process.ErrorDataReceived += (sender, e) => { ErrorSb.AppendLine(e.Data); };
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            process.StandardInput.WriteLine("echo on");
            process.StandardInput.WriteLine(GetLubanToolPath());
            EditorUtility.DisplayProgressBar("Hold on", "Generating config data", 0.5f);
            process.WaitForExit();


            var message = LogSb.ToString();
            Debug.Log(message);

            var errorMessage = ErrorSb.ToString();
            if (!string.IsNullOrWhiteSpace(errorMessage))
                Debug.LogError(errorMessage);
            if (message.Contains("== succ =="))
            {
                EditorUtility.DisplayDialog("提示", "生成成功", "Ok");
            }
            else
            {
                EditorUtility.DisplayDialog("生成失败", "生成配置数据失败！！！\n请查看Console获取详细日志", "Ok");
                Debug.LogError(message);
            }

            EditorUtility.ClearProgressBar();
        }

        private static string GetLubanToolPath()
        {
            var rootPath = Directory.GetParent(Application.dataPath).FullName;
            var result = Path.Combine(rootPath, "data");
            return result;
        }
    }
}