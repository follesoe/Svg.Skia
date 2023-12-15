﻿/*
 * Svg.Skia SVG rendering library.
 * Copyright (C) 2023  Wiesław Šoltés
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Affero General Public License as
 * published by the Free Software Foundation, either version 3 of the
 * License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Affero General Public License for more details.
 *
 * You should have received a copy of the GNU Affero General Public License
 * along with this program.  If not, see <https://www.gnu.org/licenses/>.
 */
using System;

namespace ShimSkiaSharp;

public readonly struct SKColorF
{
    public float Red { get; }
    public float Green { get; }
    public float Blue { get; }
    public float Alpha { get; }

    public static readonly SKColorF Empty = default;

    public SKColorF(float red, float green, float blue, float alpha)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = alpha;
    }

    public static implicit operator SKColor(SKColorF color)
    {
        return new(
            (byte)(color.Red * 255.0f),
            (byte)(color.Green * 255.0f),
            (byte)(color.Blue * 255.0f),
            (byte)(color.Alpha * 255.0f));
    }

    public override string ToString() 
        => FormattableString.Invariant($"{Red}, {Green}, {Blue}, {Alpha}");
}
