using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Mapster.Editor
{
    [CreateAssetMenu(fileName = "Mapster", menuName = "Mapster/ExportConfig")]
    public class MapsterExport : ScriptableObject
    {
        #region 必要参数

        [Required]
        [LabelText("Mapster.Tool Dll")]
        [FilePath(Extensions = "dll", RequireExistingPath = true)]
        [BoxGroup("必要参数")]
        public string which_dll;

        [Required]
        [Command("-a", false)]
        [LabelText("输入程序集")]
        [FilePath(Extensions = "dll", RequireExistingPath = true)]
        [BoxGroup("必要参数")]
        public string assembly_path;

        [Required] [Command("-o")] [LabelText("输出目录")] [FolderPath(RequireExistingPath = true)] [BoxGroup("必要参数")]
        public string output_dir;

        #endregion

        [TextArea(5, 15)] [LabelText("预览命令")] [ShowInInspector] [NonSerialized]
        public string preview_command;

        [Button("生成")]
        public void Gen()
        {
            GenUtils.Gen(_GetCommand());
        }

        [Button("预览")]
        public void Preview()
        {
            preview_command = $"{GenUtils._DOTNET} {_GetCommand()}";
        }

        private string _GetCommand()
        {
            string line_end = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? " ^" : " \\";

            StringBuilder sb = new StringBuilder();

            var fields = GetType().GetFields();

            sb.Append(which_dll);

            foreach (var field_info in fields)
            {
                var command = field_info.GetCustomAttribute<CommandAttribute>();

                if (command is null)
                {
                    continue;
                }

                var value = field_info.GetValue(this)?.ToString();

                // 当前值为空 或者 False, 或者 None(Enum 默认值)
                // 则继续循环
                if (string.IsNullOrEmpty(value) || string.Equals(value, "False") || string.Equals(value, "None"))
                {
                    continue;
                }

                if (string.Equals(value, "True"))
                {
                    value = string.Empty;
                }

                value = value.Replace(", ", ",");

                sb.Append($" {command.option} {value} ");

                if (command.new_line)
                {
                    sb.Append($"{line_end} \n");
                }
            }

            return sb.ToString();
        }
    }
}