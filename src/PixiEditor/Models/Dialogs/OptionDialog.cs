﻿using PixiEditor.Models.Enums;
using PixiEditor.Views.Dialogs;

namespace PixiEditor.Models.Dialogs;

internal static class OptionDialog
{
    public static OptionResult Show(string message, string title, string option1Text, string option2Text)
    {
        ConfirmationPopup popup = new ConfirmationPopup
        {
            Title = title,
            Body = message,
            ShowInTaskbar = false,
            FirstOptionText = option1Text,
            SecondOptionText = option2Text,
        };
        if (popup.ShowDialog().GetValueOrDefault())
        {
            return popup.Result ? OptionResult.Option1 : OptionResult.Option2;
        }

        return OptionResult.Canceled;
    }
}

public enum OptionResult
{
    Option1,
    Option2,
    Canceled
}
