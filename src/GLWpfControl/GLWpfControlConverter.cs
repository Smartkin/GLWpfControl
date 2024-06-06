using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Windows;

namespace OpenTK.Wpf
{
    internal class GLWpfControlConverter : TypeConverter
    {
        public override Boolean CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(FrameworkElement);
        }

        public override Object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, Object value)
        {
            return value as FrameworkElement;
        }

        public override Boolean CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(FrameworkElement);
        }

        public override Object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, Object value, Type destinationType)
        {
            return value == null ? null : value as FrameworkElement;
        }
    }
}
