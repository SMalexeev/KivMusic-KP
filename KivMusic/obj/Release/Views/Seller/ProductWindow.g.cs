﻿#pragma checksum "..\..\..\..\Views\Seller\ProductWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7B27F3161A875B263333EDE400B1C845FBC82CA16BD43C5BD36FA9220A5C2DEC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using KivMusic.Views.Seller;
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


namespace KivMusic.Views.Seller {
    
    
    /// <summary>
    /// ProductWindow
    /// </summary>
    public partial class ProductWindow : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\Views\Seller\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtProducts;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\Views\Seller\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtProductName;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\Views\Seller\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtProductPrice;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\Views\Seller\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbProductType;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\Views\Seller\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\Views\Seller\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpd;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\Views\Seller\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDel;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\Views\Seller\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\Views\Seller\ProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnProductTypeWin;
        
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
            System.Uri resourceLocater = new System.Uri("/KivMusic;component/views/seller/productwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\Seller\ProductWindow.xaml"
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
            
            #line 9 "..\..\..\..\Views\Seller\ProductWindow.xaml"
            ((KivMusic.Views.Seller.ProductWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dtProducts = ((System.Windows.Controls.DataGrid)(target));
            
            #line 34 "..\..\..\..\Views\Seller\ProductWindow.xaml"
            this.dtProducts.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dtProducts_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtProductName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtProductPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.cmbProductType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\..\Views\Seller\ProductWindow.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnUpd = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\..\Views\Seller\ProductWindow.xaml"
            this.btnUpd.Click += new System.Windows.RoutedEventHandler(this.btnUpd_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnDel = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\..\Views\Seller\ProductWindow.xaml"
            this.btnDel.Click += new System.Windows.RoutedEventHandler(this.btnDel_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\..\Views\Seller\ProductWindow.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnProductTypeWin = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\..\Views\Seller\ProductWindow.xaml"
            this.btnProductTypeWin.Click += new System.Windows.RoutedEventHandler(this.btnProductTypeWin_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

