﻿#pragma checksum "..\..\..\Pages\LearningPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "29657886CCC92D6CA86105D673F350E36BA9040A5D63EED14DF7098EBD21BD7B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Exam.LearnGoreignLang.WPF.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Exam.LearnGoreignLang.WPF.Pages {
    
    
    /// <summary>
    /// LearningPage
    /// </summary>
    public partial class LearningPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\Pages\LearningPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowTranslate;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Pages\LearningPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_back;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Pages\LearningPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_next;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\Pages\LearningPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Close;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\Pages\LearningPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame exitFrame;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Exam.LearnGoreignLang.WPF;component/pages/learningpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\LearningPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ShowTranslate = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Pages\LearningPage.xaml"
            this.ShowTranslate.Click += new System.Windows.RoutedEventHandler(this.ShowTranslate_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Button_back = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\Pages\LearningPage.xaml"
            this.Button_back.Click += new System.Windows.RoutedEventHandler(this.Button_back_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Button_next = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\..\Pages\LearningPage.xaml"
            this.Button_next.Click += new System.Windows.RoutedEventHandler(this.Button_next_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Button_Close = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\..\Pages\LearningPage.xaml"
            this.Button_Close.Click += new System.Windows.RoutedEventHandler(this.Button_Close_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.exitFrame = ((System.Windows.Controls.Frame)(target));
            
            #line 123 "..\..\..\Pages\LearningPage.xaml"
            this.exitFrame.Navigated += new System.Windows.Navigation.NavigatedEventHandler(this.exitFrame_Navigated);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

