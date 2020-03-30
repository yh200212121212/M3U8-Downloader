using System;

namespace M3U8_Downloader
{
    public enum FileType : int
    {
      mp4,
      mkv,
      ts,
      flv
    }
    public partial class Form1
    {
        const string ProgramName = "Tools\\ffmpeg.exe";
        public static FileType GetFileType(string input)
        {
            return (FileType)(Enum.Parse(typeof(FileType), input));
        }
        public void DoSomething(string Text)
        {
            houzhui.Text = Text;
            Command.Text = "-threads 0 -i " + "\"" + textBox_Adress.Text + "\"" + " -c copy -y -bsf:a aac_adtstoasc " + "\"" + textBox_DownloadPath.Text + "\\" + textBox_Name.Text + Text + "\"";
            // 启动进程执行相应命令,此例中以执行ffmpeg.exe为例  
            RealAction(ProgramName, Command.Text);
        }
        public static string GetExtraName(FileType fileType)
        {
            return "." +  fileType.ToString();
        }
        public static string GetItemName(FileType fileType)
        {
            return fileType.ToString().ToUpper();
        }
    }
}
