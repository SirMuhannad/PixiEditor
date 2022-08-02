﻿using System.Windows.Input;
using PixiEditor.Models.Commands.Attributes.Commands;
using PixiEditor.Views.UserControls.BrushShapeOverlay;

namespace PixiEditor.ViewModels.SubViewModels.Tools.Tools;

[Command.Tool(Key = Key.G)]
internal class FloodFillToolViewModel : ToolViewModel
{
    private SKPaint fillPaint = new SKPaint() { BlendMode = SKBlendMode.Src };

    public override BrushShape BrushShape => BrushShape.Pixel;

    public FloodFillToolViewModel()
    {
        ActionDisplay = "Press on an area to fill it.";
    }

    public override string Tooltip => $"Fills area with color. ({Shortcut})";
}
