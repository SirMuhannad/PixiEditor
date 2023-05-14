﻿using System.Globalization;
using PixiEditor.ChangeableDocument.Enums;
using PixiEditor.Helpers.Extensions;
using PixiEditor.Models.Localization;

namespace PixiEditor.Helpers.Converters;
internal class BlendModeToStringConverter : SingleInstanceConverter<BlendModeToStringConverter>
{
    public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not BlendMode mode)
            return "<null>";
        return new LocalizedString(mode.LocalizedKeys()).Value;
    }

    public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
