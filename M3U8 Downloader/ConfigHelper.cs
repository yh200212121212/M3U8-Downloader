using System;
using System.IO;
using System.Text;
using System.Xml;

namespace M3U8_Downloader
{
    internal class ConfigHelper
    {

        const string SettingsFile = @"Tools\Settings.xml";

        public ConfigHelper(Form1 form)
        {
            _form = form;
        }

        Form1 _form = null;

        public void SaveSettings()
        {
            string ExtendName = "";
            FileType fileType = Form1.GetFileType(_form.选择后缀名.Text.ToLower());
            switch (fileType)
            {
                case FileType.mp4:
                    ExtendName = Form1.GetItemName(fileType);
                    break;
                case FileType.mkv:
                    ExtendName = Form1.GetItemName(fileType);
                    break;
                case FileType.ts:
                    ExtendName = Form1.GetItemName(fileType);
                    break;
                case FileType.flv:
                    ExtendName = Form1.GetItemName(fileType);
                    break;
                default:
                    break;
            }

            XmlTextWriter xml = new XmlTextWriter(SettingsFile, Encoding.UTF8)
            {
                Formatting = Formatting.Indented
            };
            xml.WriteStartDocument();
            xml.WriteStartElement("Settings");

            { xml.WriteStartElement("Skin"); xml.WriteCData(_form.SkinId.ToString()); xml.WriteEndElement(); }
            { xml.WriteStartElement("DownPath"); xml.WriteCData(_form.textBox_DownloadPath.Text); xml.WriteEndElement(); }
            { xml.WriteStartElement("ExtendName"); xml.WriteCData(ExtendName); xml.WriteEndElement(); }

            xml.WriteEndElement();
            xml.WriteEndDocument();
            xml.Flush();
            xml.Close();
        }

        void GetSettings()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(SettingsFile);    //加载Xml文件  
            XmlNodeList topM = doc.SelectNodes("Settings");
            foreach (XmlElement element in topM)
            {
                if (element.GetElementsByTagName("Skin")[0].InnerText == "1") { _form.SkinId = 0; }
                if (element.GetElementsByTagName("Skin")[0].InnerText == "0") { _form.SkinId = 1; }
                _form.Skin();
                _form.textBox_DownloadPath.Text = element.GetElementsByTagName("DownPath")[0].InnerText;
                if (element.GetElementsByTagName("ExtendName")[0].InnerText == "MP4") { _form.选择后缀名.SelectedItem = _form.选择后缀名.Items[0]; }
                if (element.GetElementsByTagName("ExtendName")[0].InnerText == "MKV") { _form.选择后缀名.SelectedItem = _form.选择后缀名.Items[1]; }
                if (element.GetElementsByTagName("ExtendName")[0].InnerText == "TS") { _form.选择后缀名.SelectedItem = _form.选择后缀名.Items[2]; }
                if (element.GetElementsByTagName("ExtendName")[0].InnerText == "FLV") { _form.选择后缀名.SelectedItem = _form.选择后缀名.Items[3]; }
            }
        }

        public void ApplySettings()
        {
            if (File.Exists(@"Tools\Settings.xml"))  //判断程序目录有无配置文件，并读取文件
            {
                GetSettings();
            }
            else  //若无配置文件，获取当前程序运行路径，即为默认下载路径
            {
                string Path = Environment.CurrentDirectory + "Download";

                if (!Directory.Exists(Path))
                {
                    Directory.CreateDirectory(Path);
                }

                _form.textBox_DownloadPath.Text = Path;
            }
        }

    }
}