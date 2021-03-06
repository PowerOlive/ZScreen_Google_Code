﻿using System;
using System.Windows.Forms;
using ZScreenLib;

namespace ZScreenTesterGUI
{
    public class Tester
    {
        private static string TestFilePicture = @"..\..\..\test.jpg";
        private static string TestFileText = @"..\..\..\test.txt";
        private static string TestFileBinary = @"..\..\..\test.exe";

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Engine.TurnOn();
            Engine.LoadSettingsLatest();

            TesterGUI testerGUI = new TesterGUI
            {
                TestFilePath = TestFileBinary,
                TestImageFilePath = TestFilePicture,
                TestText = TestFileText
            };

            Application.Run(testerGUI);

            Engine.TurnOff();
        }
    }
}