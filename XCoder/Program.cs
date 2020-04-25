﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using NewLife;
using NewLife.Log;
using NewLife.Net;
using NewLife.Threading;
using NewLife.Xml;
using XCode.DataAccessLayer;

namespace XCoder
{
    static class Program
    {
        /// <summary>应用程序的主入口点。</summary>
        [STAThread]
        static void Main()
        {
#if NC30
            XTrace2.UseWinForm();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
#else
            XTrace.UseWinForm();
#endif

            StringHelper.EnableSpeechTip = XConfig.Current.SpeechTip;

            if (XConfig.Current.IsNew) "学无先后达者为师，欢迎使用新生命码神工具！".SpeechTip();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMDI());
        }
    }
}