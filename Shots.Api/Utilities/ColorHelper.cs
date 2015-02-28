﻿using System;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace Shots.Api.Utilities
{
    public static class ColorHelper
    {
        public static SolidColorBrush ToColorBrush(this string hexaColor)
        {
            return new SolidColorBrush(
                Color.FromArgb(
                    255,
                    Convert.ToByte(hexaColor.Substring(1, 2), 16),
                    Convert.ToByte(hexaColor.Substring(3, 2), 16),
                    Convert.ToByte(hexaColor.Substring(5, 2), 16)
                    )
                );
        }
    }
}