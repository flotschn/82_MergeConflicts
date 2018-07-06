﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace RxDatabase.Database_functions
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The InsertAge recording.
    /// </summary>
    [TestModule("03670c42-b72a-4bec-819b-51f09b02ca67", ModuleType.Recording, 1)]
    public partial class InsertAge : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RxDatabase.RxDatabaseRepository repository.
        /// </summary>
        public static RxDatabase.RxDatabaseRepository repo = RxDatabase.RxDatabaseRepository.Instance;

        static InsertAge instance = new InsertAge();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InsertAge()
        {
            Age = "48";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InsertAge Instance
        {
            get { return instance; }
        }

#region Variables

        string _Age;

        /// <summary>
        /// Gets or sets the value of variable Age.
        /// </summary>
        [TestVariable("8cfa192a-0d0e-41a2-8ef8-ced430c42710")]
        public string Age
        {
            get { return _Age; }
            set { _Age = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DemoApplication.DatabaseTab.Age' at 52;8.", repo.DemoApplication.DatabaseTab.AgeInfo, new RecordItemIndex(0));
            repo.DemoApplication.DatabaseTab.Age.Click("52;8");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'DemoApplication.DatabaseTab.Age'.", repo.DemoApplication.DatabaseTab.AgeInfo, new RecordItemIndex(1));
            repo.DemoApplication.DatabaseTab.Age.PressKeys("{Back}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Age' with focus on 'DemoApplication.DatabaseTab.Age'.", repo.DemoApplication.DatabaseTab.AgeInfo, new RecordItemIndex(2));
            repo.DemoApplication.DatabaseTab.Age.PressKeys(Age);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
