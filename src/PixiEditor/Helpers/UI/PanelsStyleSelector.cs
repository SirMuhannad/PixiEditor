﻿using System.Windows;
using System.Windows.Controls;
using PixiEditor.Models.DataHolders;
using PixiEditor.ViewModels.SubViewModels.Document;

namespace PixiEditor.Helpers.UI;

internal class PanelsStyleSelector : StyleSelector
{
    public Style DocumentTabStyle { get; set; }

    public override Style SelectStyle(object item, DependencyObject container)
    {
        if (item is DocumentViewModel)
        {
            return DocumentTabStyle;
        }
        return base.SelectStyle(item, container);
    }
}
