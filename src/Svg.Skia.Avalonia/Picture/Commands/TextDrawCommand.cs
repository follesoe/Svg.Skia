﻿using A = Avalonia;
using AM = Avalonia.Media;

namespace Svg.Picture.Avalonia
{
    public sealed class TextDrawCommand : DrawCommand
    {
        public readonly AM.IBrush? Brush;
        public readonly A.Point Origin;
        public readonly AM.FormattedText? FormattedText;

        public TextDrawCommand(AM.IBrush? brush, A.Point origin, AM.FormattedText? formattedText)
        {
            Brush = brush;
            Origin = origin;
            FormattedText = formattedText;
        }
    }
}
