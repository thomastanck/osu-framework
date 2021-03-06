﻿// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using System;
using System.Runtime.InteropServices;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.ES30;

namespace osu.Framework.Graphics.OpenGL.Vertices
{
    [StructLayout(LayoutKind.Sequential)]
    public struct TexturedVertex2D : IEquatable<TexturedVertex2D>, IVertex
    {
        [VertexMember(2, VertexAttribPointerType.Float)]
        public Vector2 Position;
        [VertexMember(4, VertexAttribPointerType.Float)]
        public Color4 Colour;
        [VertexMember(2, VertexAttribPointerType.Float)]
        public Vector2 TexturePosition;
        [VertexMember(4, VertexAttribPointerType.Float)]
        public Vector4 TextureRect;
        [VertexMember(2, VertexAttribPointerType.Float)]
        public Vector2 BlendRange;

        public bool Equals(TexturedVertex2D other)
        {
            return Position.Equals(other.Position)
                   && TexturePosition.Equals(other.TexturePosition)
                   && Colour.Equals(other.Colour)
                   && TextureRect.Equals(other.TextureRect)
                   && BlendRange.Equals(other.BlendRange);
        }
    }
}
