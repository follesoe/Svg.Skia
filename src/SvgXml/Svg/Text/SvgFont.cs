﻿using Xml;

namespace Svg
{
    [Element("font")]
    public class SvgFont : SvgElement, ISvgPresentationAttributes, ISvgStylableAttributes, ISvgResourcesAttributes
    {
        public override void Print(string indent)
        {
            base.Print(indent);
            // TODO:
        }
    }
}
