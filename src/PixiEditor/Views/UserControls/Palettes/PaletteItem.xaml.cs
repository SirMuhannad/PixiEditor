﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using PixiEditor.Models.DataHolders.Palettes;

namespace PixiEditor.Views.UserControls.Palettes;

internal partial class PaletteItem : UserControl
{
    public Palette Palette
    {
        get { return (Palette)GetValue(PaletteProperty); }
        set { SetValue(PaletteProperty, value); }
    }

    public static readonly DependencyProperty PaletteProperty =
        DependencyProperty.Register(nameof(Palette), typeof(Palette), typeof(PaletteItem));

    public ICommand ImportPaletteCommand
    {
        get { return (ICommand)GetValue(ImportPaletteCommandProperty); }
        set { SetValue(ImportPaletteCommandProperty, value); }
    }

    public static readonly DependencyProperty ImportPaletteCommandProperty =
        DependencyProperty.Register(nameof(ImportPaletteCommand), typeof(ICommand), typeof(PaletteItem));

    public ICommand DeletePaletteCommand
    {
        get { return (ICommand)GetValue(DeletePaletteCommandProperty); }
        set { SetValue(DeletePaletteCommandProperty, value); }
    }

    public static readonly DependencyProperty DeletePaletteCommandProperty =
        DependencyProperty.Register(nameof(DeletePaletteCommand), typeof(ICommand), typeof(PaletteItem));

    public static readonly DependencyProperty ToggleFavouriteCommandProperty = DependencyProperty.Register(
        nameof(ToggleFavouriteCommand), typeof(ICommand), typeof(PaletteItem), new PropertyMetadata(default(ICommand)));

    public ICommand ToggleFavouriteCommand
    {
        get { return (ICommand)GetValue(ToggleFavouriteCommandProperty); }
        set { SetValue(ToggleFavouriteCommandProperty, value); }
    }

    public event EventHandler<EditableTextBlock.TextChangedEventArgs> OnRename;


    public PaletteItem()
    {
        InitializeComponent();
    }

    private void EditableTextBlock_OnSubmit(object sender, EditableTextBlock.TextChangedEventArgs e)
    {
        OnRename?.Invoke(this, e);
    }

    private void RenameButton_Click(object sender, RoutedEventArgs e)
    {
        titleTextBlock.IsEditing = true;
    }
}
