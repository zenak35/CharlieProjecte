﻿#pragma checksum "C:\Users\eMobilis\documents\visual studio 2010\Projects\Charlieproject\Charlieproject\NewNotePage1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "48C88D21AD87EF1EADD2C20B07D344E6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Charlieproject {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock HomescreenTitle;
        
        internal System.Windows.Controls.TextBlock HomescreenStatus;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.ListBox MainListBox;
        
        internal System.Windows.Shapes.Rectangle InputContainer;
        
        internal System.Windows.Controls.TextBlock InputTitle;
        
        internal System.Windows.Controls.TextBlock InputDescription;
        
        internal System.Windows.Controls.TextBox InputBox;
        
        internal System.Windows.Controls.Button CreateNote;
        
        internal System.Windows.Controls.Button CancelCreate;
        
        internal System.Windows.Controls.Button NewNote;
        
        internal System.Windows.Shapes.Rectangle HeaderContentSeparator;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Charlieproject;component/NewNotePage1.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.HomescreenTitle = ((System.Windows.Controls.TextBlock)(this.FindName("HomescreenTitle")));
            this.HomescreenStatus = ((System.Windows.Controls.TextBlock)(this.FindName("HomescreenStatus")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.MainListBox = ((System.Windows.Controls.ListBox)(this.FindName("MainListBox")));
            this.InputContainer = ((System.Windows.Shapes.Rectangle)(this.FindName("InputContainer")));
            this.InputTitle = ((System.Windows.Controls.TextBlock)(this.FindName("InputTitle")));
            this.InputDescription = ((System.Windows.Controls.TextBlock)(this.FindName("InputDescription")));
            this.InputBox = ((System.Windows.Controls.TextBox)(this.FindName("InputBox")));
            this.CreateNote = ((System.Windows.Controls.Button)(this.FindName("CreateNote")));
            this.CancelCreate = ((System.Windows.Controls.Button)(this.FindName("CancelCreate")));
            this.NewNote = ((System.Windows.Controls.Button)(this.FindName("NewNote")));
            this.HeaderContentSeparator = ((System.Windows.Shapes.Rectangle)(this.FindName("HeaderContentSeparator")));
        }
    }
}

