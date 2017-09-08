// Copyright (c) The Avalonia Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using System;
using System.Globalization;
using Avalonia.Input;

namespace Avalonia.Markup.Xaml.Converters
{
	using System.ComponentModel;

    public class CursorTypeConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            var cursor = (StandardCursorType)Enum.Parse(typeof(StandardCursorType), ((string)value).Trim(), true);
            return new Cursor(cursor);
        }
    }
}