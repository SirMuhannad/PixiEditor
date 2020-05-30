﻿using PixiEditor.ViewModels;
using System.Windows;

namespace PixiEditor.Views
{
    /// <summary>
    /// Interaction logic for SaveFilePopup.xaml
    /// </summary>
    public partial class SaveFilePopup : Window
    {
        SaveFilePopupViewModel dataContext = new SaveFilePopupViewModel();
        public SaveFilePopup()
        {
            InitializeComponent();
            this.DataContext = dataContext;
        }



        public int SaveWidth
        {
            get { return (int)GetValue(SaveWidthProperty); }
            set { SetValue(SaveWidthProperty, value); }
        }



        public int SaveHeight
        {
            get { return (int)GetValue(SaveHeightProperty); }
            set { SetValue(SaveHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SaveHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SaveHeightProperty =
            DependencyProperty.Register("SaveHeight", typeof(int), typeof(SaveFilePopup), new PropertyMetadata(32));



        // Using a DependencyProperty as the backing store for SaveWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SaveWidthProperty =
            DependencyProperty.Register("SaveWidth", typeof(int), typeof(SaveFilePopup), new PropertyMetadata(32));

        public string SavePath
        {
            get { return dataContext.FilePath; }
            set { dataContext.FilePath = value; }
        }
    }
}
