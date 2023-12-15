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
using System.IO;
using Svg.Skia.UnitTests.Common;
using Xunit;

namespace Svg.Skia.UnitTests;

public class W3CTestSuiteTests
{
    private string GetSvgPath(string name) 
        => Path.Combine("..", "..", "..", "..", "..", "externals", "SVG", "Tests", "W3CTestSuite", "svg", name);

    private string GetExpectedPngPath(string name) 
        => Path.Combine("..", "..", "..", "..", "..", "externals", "SVG", "Tests", "W3CTestSuite", "png", name);

    private string GetActualPngPath(string name)
        => Path.Combine("..", "..", "..", "..", "Tests", name);

    private void TestImpl(string name, double errorThreshold, float scaleX = 1.0f, float scaleY = 1.0f)
    {
        var svgPath = GetSvgPath($"{name}.svg");
        var expectedPng = GetExpectedPngPath($"{name}.png");
        var actualPng = GetActualPngPath($"{name} (Actual).png");

        var svg = new SKSvg();
        using var _ = svg.Load(svgPath);
        svg.Save(actualPng, SkiaSharp.SKColors.Transparent, scaleX: scaleX, scaleY: scaleY);

        ImageHelper.CompareImages(name, actualPng, expectedPng, errorThreshold);

        if (File.Exists(actualPng))
        {
            File.Delete(actualPng);
        }
    }

    // TODO:
    // [InlineData("__AJ_Digital_Camera", 0.022)]
    // [InlineData("__issue-015-01", 0.022)]
    // [InlineData("__issue-016-01", 0.022)]
    // [InlineData("__issue-034-02", 0.022)]
    // [InlineData("__issue-036-01", 0.022)]
    // [InlineData("__issue-064-01", 0.022)]
    // [InlineData("__issue-064-02", 0.022)]
    // [InlineData("__issue-074-01", 0.022)]
    // [InlineData("__issue-082-01", 0.022)]
    // [InlineData("__issue-083-01", 0.022)]
    // [InlineData("__issue-084-01", 0.022)]
    // [InlineData("__issue-084-02", 0.022)]
    // [InlineData("__issue-109-01", 0.022)]
    // [InlineData("__issue-114-01", 0.022)]
    // [InlineData("__issue-116-01", 0.022)]
    // [InlineData("__issue-123-01", 0.022)]
    // [InlineData("__issue-127-01", 0.022)]
    // [InlineData("__issue-129-01", 0.022)]
    // [InlineData("__issue-131-01", 0.022)]
    // [InlineData("__issue-134-01", 0.022)]
    // [InlineData("__issue-143-01", 0.022)]
    // [InlineData("__issue-166-01", 0.022)]
    // [InlineData("__issue-191-01", 0.022)]
    // [InlineData("__issue-202-01", 0.022)]
    // [InlineData("__issue-214-01", 0.022)]
    // [InlineData("__issue-215-01", 0.022)]
    // [InlineData("__issue-223-01", 0.022)]
    // [InlineData("__issue-223-02", 0.022)]
    // [InlineData("__issue-224-01", 0.022)]
    // [InlineData("__issue-227-01", 0.022)]
    // [InlineData("__issue-227-02", 0.022)]
    // [InlineData("__issue-239-01", 0.022)]
    // [InlineData("__issue-242-01", 0.022)]
    // [InlineData("__issue-244-01", 0.022)]
    // [InlineData("__issue-247-01", 0.022)]
    // [InlineData("__issue-247-02", 0.022)]
    // [InlineData("__issue-252-01", 0.022)]
    // [InlineData("__issue-263-01", 0.022)]
    // [InlineData("__issue-279-01", 0.022)]
    // [InlineData("__issue-280-01", 0.022)]
    // [InlineData("__issue-280-02", 0.022)]
    // [InlineData("__issue-315-01", 0.022)]
    // [InlineData("__issue-318-01", 0.022)]
    // [InlineData("__issue-323-01", 0.022)]
    // [InlineData("__issue-323-02", 0.022)]
    // [InlineData("__issue-323-03", 0.022)]
    // [InlineData("__issue-329-01", 0.022)]
    // [InlineData("__issue-338-01_stroke_width", 0.022)]
    // [InlineData("__issue-342-01", 0.022)]
    // [InlineData("__issue-345-01", 0.022)]
    // [InlineData("__issue-345-02", 0.022)]
    // [InlineData("__issue-354-01", 0.022)]
    // [InlineData("__issue-362-01", 0.022)]
    // [InlineData("__issue-363-01", 0.022)]
    // [InlineData("__issue-385-01_Test_text-anchor-middle", 0.022)]
    // [InlineData("__issue-391-01", 0.022)]
    // [InlineData("__issue-398-01", 0.022)]
    // [InlineData("__issue-419-01", 0.022)]
    // [InlineData("__issue-436-01", 0.022)]
    // [InlineData("__issue-437-01", 0.022)]
    // [InlineData("__issue-437-02", 0.022)]
    // [InlineData("__issue-437-03", 0.022)]
    // [InlineData("__issue-460-01", 0.022)]
    // [InlineData("__issue-479-01", 0.022)]
    // [InlineData("__issue-488-01", 0.022)]
    // [InlineData("__issue-508-01", 0.022)]
    // [InlineData("__issue-541-01", 0.022)]
    // [InlineData("__issue-554-01", 0.022)]
    // [InlineData("__issue-554-02", 0.022)]
    // [InlineData("__issue-578-01", 0.022)]
    // [InlineData("__issue-592-01", 0.022)]
    // [InlineData("__issue-592-02", 0.022)]
    // [InlineData("__issue-622-01", 0.022)]
    // [InlineData("__issue-626-01", 0.022)]
    // [InlineData("__issue-634-01", 0.022)]
    // [InlineData("__issue-664-01", 0.022)]
    // [InlineData("__issue-675-01", 0.022)]
    // [InlineData("__issue-732-01", 0.022)]
    // [InlineData("__issue-744-01", 0.022)]
    // [InlineData("__issue-747-01", 0.022)]
    // [InlineData("__issue-755-01", 0.022)]
    // [InlineData("__issue-758-01", 0.022)]
    // [InlineData("__issue-769-01", 0.022)]
    // [InlineData("__issue-785-01", 0.022)]
    // [InlineData("__issue-789-01", 0.022)]
    // [InlineData("__issue-789-02", 0.022)]
    // [InlineData("__issue-789-03", 0.022)]
    // [InlineData("__issue-830-01", 0.022)]
    // [InlineData("__issue-863-01", 0.022)]
    // [InlineData("__issue-886-01", 0.022)]
    // [InlineData("__issue-888-01", 0.022)]
    // [InlineData("__issue-917-01", 0.022)]
    // [InlineData("__issue-917-02", 0.022)]
    // [InlineData("__issue-941-01", 0.022)]
    // [InlineData("__issue-960-01", 0.022)]
    // [InlineData("__issue-966-01", 0.022)]
    // [InlineData("__issue-966-02", 0.022)]
    // [InlineData("__issue-989-01", 0.022)]
    // [InlineData("__pull_request-373-01", 0.022)]
    // [InlineData("__pull_request-374-01", 0.022)]
    // [InlineData("__pull_request-414-01", 0.022)]
    // [InlineData("__pull_request-433-01", 0.022)]
    // [InlineData("__pull_request-444-01", 0.022)]
    // [InlineData("__pull_request-462-01", 0.022)]
    // [InlineData("__pull_request-471-01", 0.022)]
    // [InlineData("__pull_request-492-01", 0.022)]
    // [InlineData("__pull_request-500-01", 0.022)]
    // [InlineData("__pull_request-500-02", 0.022)]
    // [InlineData("__pull_request-504-01", 0.022)]
    // [InlineData("__pull_request-537-01", 0.022)]
    // [InlineData("__pull_request-537-02", 0.022)]
    // [InlineData("__pull_request-551-01", 0.022)]
    // [InlineData("__pull_request-564-01", 0.022)]
    // [InlineData("__pull_request-564-02", 0.022)]
    // [InlineData("__pull_request-575-01", 0.022)]
    // [InlineData("__pull_request-640-01", 0.022)]
    // [InlineData("__pull_request-640-02", 0.022)]
    // [InlineData("__pull_request-642-01", 0.022)]
    // [InlineData("__pull_request-656-01", 0.022)]
    // [InlineData("__pull_request-656-02", 0.022)]
    // [InlineData("__pull_request-658-01", 0.022)]
    // [InlineData("__pull_request-659-01", 0.022)]
    // [InlineData("__pull_request-686-01", 0.022)]
    // [InlineData("__pull_request-690-01", 0.022)]
    // [InlineData("__pull_request-706-01", 0.022)]
    // [InlineData("__pull_request-727-01", 0.022)]
    // [InlineData("__pull_request-873-01", 0.022)]
    // [InlineData("__pull_request-873-02", 0.022)]
    // [InlineData("__pull_request-925-01", 0.022)]
    // [InlineData("__pull_request-925-02", 0.022)]
    // [InlineData("__pull_request-925-03", 0.022)]
    // [InlineData("__pull_request-925-04", 0.022)]
    // [InlineData("__pull_request-925-05", 0.022)]
    // [InlineData("__pull_request-961-01", 0.022)]
    // [InlineData("__pull_request-963-01", 0.022)]
    // [InlineData("__Telefunken_FuBK_test_pattern", 0.022)]
    // [InlineData("__tiger", 0.022)]
    // [InlineData("__title", 0.022)]
    // [InlineData("animate-dom-01-f", 0.022)]
    // [InlineData("animate-dom-02-f", 0.022)]
    // [InlineData("animate-elem-02-t", 0.022)]
    // [InlineData("animate-elem-03-t", 0.022)]
    // [InlineData("animate-elem-04-t", 0.022)]
    // [InlineData("animate-elem-05-t", 0.022)]
    // [InlineData("animate-elem-06-t", 0.022)]
    // [InlineData("animate-elem-07-t", 0.022)]
    // [InlineData("animate-elem-08-t", 0.022)]
    // [InlineData("animate-elem-09-t", 0.022)]
    // [InlineData("animate-elem-10-t", 0.022)]
    // [InlineData("animate-elem-11-t", 0.022)]
    // [InlineData("animate-elem-12-t", 0.022)]
    // [InlineData("animate-elem-13-t", 0.022)]
    // [InlineData("animate-elem-14-t", 0.022)]
    // [InlineData("animate-elem-15-t", 0.022)]
    // [InlineData("animate-elem-17-t", 0.022)]
    // [InlineData("animate-elem-19-t", 0.022)]
    // [InlineData("animate-elem-20-t", 0.022)]
    // [InlineData("animate-elem-21-t", 0.022)]
    // [InlineData("animate-elem-22-b", 0.022)]
    // [InlineData("animate-elem-23-t", 0.022)]
    // [InlineData("animate-elem-24-t", 0.022)]
    // [InlineData("animate-elem-25-t", 0.022)]
    // [InlineData("animate-elem-26-t", 0.022)]
    // [InlineData("animate-elem-27-t", 0.022)]
    // [InlineData("animate-elem-28-t", 0.022)]
    // [InlineData("animate-elem-29-b", 0.022)]
    // [InlineData("animate-elem-30-t", 0.022)]
    // [InlineData("animate-elem-31-t", 0.022)]
    // [InlineData("animate-elem-32-t", 0.022)]
    // [InlineData("animate-elem-33-t", 0.022)]
    // [InlineData("animate-elem-34-t", 0.022)]
    // [InlineData("animate-elem-35-t", 0.022)]
    // [InlineData("animate-elem-36-t", 0.022)]
    // [InlineData("animate-elem-37-t", 0.022)]
    // [InlineData("animate-elem-38-t", 0.022)]
    // [InlineData("animate-elem-39-t", 0.022)]
    // [InlineData("animate-elem-40-t", 0.022)]
    // [InlineData("animate-elem-41-t", 0.022)]
    // [InlineData("animate-elem-44-t", 0.022)]
    // [InlineData("animate-elem-46-t", 0.022)]
    // [InlineData("animate-elem-52-t", 0.022)]
    // [InlineData("animate-elem-53-t", 0.022)]
    // [InlineData("animate-elem-60-t", 0.022)]
    // [InlineData("animate-elem-61-t", 0.022)]
    // [InlineData("animate-elem-62-t", 0.022)]
    // [InlineData("animate-elem-63-t", 0.022)]
    // [InlineData("animate-elem-64-t", 0.022)]
    // [InlineData("animate-elem-65-t", 0.022)]
    // [InlineData("animate-elem-66-t", 0.022)]
    // [InlineData("animate-elem-67-t", 0.022)]
    // [InlineData("animate-elem-68-t", 0.022)]
    // [InlineData("animate-elem-69-t", 0.022)]
    // [InlineData("animate-elem-70-t", 0.022)]
    // [InlineData("animate-elem-77-t", 0.022)]
    // [InlineData("animate-elem-78-t", 0.022)]
    // [InlineData("animate-elem-80-t", 0.022)]
    // [InlineData("animate-elem-81-t", 0.022)]
    // [InlineData("animate-elem-82-t", 0.022)]
    // [InlineData("animate-elem-83-t", 0.022)]
    // [InlineData("animate-elem-84-t", 0.022)]
    // [InlineData("animate-elem-85-t", 0.022)]
    // [InlineData("animate-elem-86-t", 0.022)]
    // [InlineData("animate-elem-87-t", 0.022)]
    // [InlineData("animate-elem-88-t", 0.022)]
    // [InlineData("animate-elem-89-t", 0.022)]
    // [InlineData("animate-elem-90-b", 0.022)]
    // [InlineData("animate-elem-91-t", 0.022)]
    // [InlineData("animate-elem-92-t", 0.022)]
    // [InlineData("animate-interact-events-01-t", 0.022)]
    // [InlineData("animate-interact-pevents-01-t", 0.022)]
    // [InlineData("animate-interact-pevents-02-t", 0.022)]
    // [InlineData("animate-interact-pevents-03-t", 0.022)]
    // [InlineData("animate-interact-pevents-04-t", 0.022)]
    // [InlineData("animate-pservers-grad-01-b", 0.022)]
    // [InlineData("animate-script-elem-01-b", 0.022)]
    // [InlineData("animate-struct-dom-01-b", 0.022)]
    // [InlineData("color-prof-01-f", 0.022)]
    // [InlineData("color-prop-01-b", 0.022)]
    // [InlineData("color-prop-02-f", 0.022)]
    // [InlineData("color-prop-03-t", 0.022)]
    // [InlineData("color-prop-04-t", 0.022)]
    // [InlineData("color-prop-05-t", 0.022)]
    // [InlineData("conform-viewers-02-f", 0.022)]
    // [InlineData("conform-viewers-03-f", 0.022)]
    // [InlineData("coords-coord-01-t", 0.022)]
    // [InlineData("coords-coord-02-t", 0.022)]
    // [InlineData("coords-dom-01-f", 0.022)]
    // [InlineData("coords-dom-02-f", 0.022)]
    // [InlineData("coords-dom-03-f", 0.022)]
    // [InlineData("coords-dom-04-f", 0.022)]
    // [InlineData("coords-trans-01-b", 0.022)]
    // [InlineData("coords-trans-02-t", 0.022)]
    // [InlineData("coords-trans-03-t", 0.022)]
    // [InlineData("coords-trans-04-t", 0.022)]
    // [InlineData("coords-trans-05-t", 0.022)]
    // [InlineData("coords-trans-06-t", 0.022)]
    // [InlineData("coords-trans-07-t", 0.022)]
    // [InlineData("coords-trans-08-t", 0.022)]
    // [InlineData("coords-trans-09-t", 0.022)]
    // [InlineData("coords-trans-10-f", 0.022)]
    // [InlineData("coords-trans-11-f", 0.022)]
    // [InlineData("coords-trans-12-f", 0.022)]
    // [InlineData("coords-trans-13-f", 0.022)]
    // [InlineData("coords-trans-14-f", 0.022)]
    // [InlineData("coords-transformattr-01-f", 0.022)]
    // [InlineData("coords-transformattr-02-f", 0.022)]
    // [InlineData("coords-transformattr-03-f", 0.022)]
    // [InlineData("coords-transformattr-04-f", 0.022)]
    // [InlineData("coords-transformattr-05-f", 0.022)]
    // [InlineData("coords-units-01-b", 0.022)]
    // [InlineData("coords-units-02-b", 0.022)]
    // [InlineData("coords-units-03-b", 0.022)]
    // [InlineData("coords-viewattr-01-b", 0.022)]
    // [InlineData("coords-viewattr-02-b", 0.022)]
    // [InlineData("coords-viewattr-03-b", 0.022)]
    // [InlineData("coords-viewattr-04-f", 0.022)]
    // [InlineData("extend-namespace-01-f", 0.022)]
    // [InlineData("filters-background-01-f", 0.022)]
    // [InlineData("filters-blend-01-b", 0.022)]
    // [InlineData("filters-color-01-b", 0.022)]
    // [InlineData("filters-color-02-b", 0.022)]
    // [InlineData("filters-composite-02-b", 0.022)]
    // [InlineData("filters-composite-03-f", 0.022)]
    // [InlineData("filters-composite-04-f", 0.022)]
    // [InlineData("filters-composite-05-f", 0.022)]
    // [InlineData("filters-comptran-01-b", 0.022)]
    // [InlineData("filters-conv-01-f", 0.022)]
    // [InlineData("filters-conv-02-f", 0.022)]
    // [InlineData("filters-conv-03-f", 0.022)]
    // [InlineData("filters-conv-04-f", 0.022)]
    // [InlineData("filters-conv-05-f", 0.022)]
    // [InlineData("filters-diffuse-01-f", 0.022)]
    // [InlineData("filters-displace-01-f", 0.022)]
    // [InlineData("filters-displace-02-f", 0.022)]
    // [InlineData("filters-example-01-b", 0.022)]
    // [InlineData("filters-felem-01-b", 0.022)]
    // [InlineData("filters-felem-02-f", 0.022)]
    // [InlineData("filters-gauss-01-b", 0.022)]
    // [InlineData("filters-gauss-02-f", 0.022)]
    // [InlineData("filters-gauss-03-f", 0.022)]
    // [InlineData("filters-image-01-b", 0.022)]
    // [InlineData("filters-image-02-b", 0.022)]
    // [InlineData("filters-image-03-f", 0.022)]
    // [InlineData("filters-image-04-f", 0.022)]
    // [InlineData("filters-image-05-f", 0.022)]
    // [InlineData("filters-light-01-f", 0.022)]
    // [InlineData("filters-light-02-f", 0.022)]
    // [InlineData("filters-light-03-f", 0.022)]
    // [InlineData("filters-light-04-f", 0.022)]
    // [InlineData("filters-light-05-f", 0.022)]
    // [InlineData("filters-morph-01-f", 0.022)]
    // [InlineData("filters-offset-01-b", 0.022)]
    // [InlineData("filters-offset-02-b", 0.022)]
    // [InlineData("filters-overview-01-b", 0.022)]
    // [InlineData("filters-overview-02-b", 0.022)]
    // [InlineData("filters-overview-03-b", 0.022)]
    // [InlineData("filters-specular-01-f", 0.022)]
    // [InlineData("filters-tile-01-b", 0.022)]
    // [InlineData("filters-turb-01-f", 0.022)]
    // [InlineData("filters-turb-02-f", 0.022)]
    // [InlineData("fonts-desc-01-t", 0.022)]
    // [InlineData("fonts-desc-02-t", 0.022)]
    // [InlineData("fonts-desc-03-t", 0.022)]
    // [InlineData("fonts-desc-04-t", 0.022)]
    // [InlineData("fonts-desc-05-t", 0.022)]
    // [InlineData("fonts-elem-01-t", 0.022)]
    // [InlineData("fonts-elem-02-t", 0.022)]
    // [InlineData("fonts-elem-03-b", 0.022)]
    // [InlineData("fonts-elem-04-b", 0.022)]
    // [InlineData("fonts-elem-05-t", 0.022)]
    // [InlineData("fonts-elem-06-t", 0.022)]
    // [InlineData("fonts-elem-07-b", 0.022)]
    // [InlineData("fonts-glyph-02-t", 0.022)]
    // [InlineData("fonts-glyph-03-t", 0.022)]
    // [InlineData("fonts-glyph-04-t", 0.022)]
    // [InlineData("fonts-kern-01-t", 0.022)]
    // [InlineData("fonts-overview-201-t", 0.022)]
    // [InlineData("imp-path-01-f", 0.022)]
    // [InlineData("interact-cursor-01-f", 0.022)]
    // [InlineData("interact-dom-01-b", 0.022)]
    // [InlineData("interact-events-01-b", 0.022)]
    // [InlineData("interact-events-02-b", 0.022)]
    // [InlineData("interact-events-202-f", 0.022)]
    // [InlineData("interact-events-203-t", 0.022)]
    // [InlineData("interact-order-01-b", 0.022)]
    // [InlineData("interact-order-02-b", 0.022)]
    // [InlineData("interact-order-03-b", 0.022)]
    // [InlineData("interact-pevents-01-b", 0.022)]
    // [InlineData("interact-pevents-03-b", 0.022)]
    // [InlineData("interact-pevents-04-t", 0.022)]
    // [InlineData("interact-pevents-05-b", 0.022)]
    // [InlineData("interact-pevents-07-t", 0.022)]
    // [InlineData("interact-pevents-08-f", 0.022)]
    // [InlineData("interact-pevents-09-f", 0.022)]
    // [InlineData("interact-pevents-10-f", 0.022)]
    // [InlineData("interact-pointer-01-t", 0.022)]
    // [InlineData("interact-pointer-02-t", 0.022)]
    // [InlineData("interact-pointer-03-t", 0.022)]
    // [InlineData("interact-pointer-04-f", 0.022)]
    // [InlineData("interact-zoom-01-t", 0.022)]
    // [InlineData("interact-zoom-02-t", 0.022)]
    // [InlineData("interact-zoom-03-t", 0.022)]
    // [InlineData("linking-a-01-b", 0.022)]
    // [InlineData("linking-a-03-b", 0.022)]
    // [InlineData("linking-a-04-t", 0.022)]
    // [InlineData("linking-a-05-t", 0.022)]
    // [InlineData("linking-a-07-t", 0.022)]
    // [InlineData("linking-a-08-t", 0.022)]
    // [InlineData("linking-a-09-b", 0.022)]
    // [InlineData("linking-a-10-f", 0.022)]
    // [InlineData("linking-frag-01-f", 0.022)]
    // [InlineData("linking-uri-01-b", 0.022)]
    // [InlineData("linking-uri-02-b", 0.022)]
    // [InlineData("linking-uri-03-t", 0.022)]
    // [InlineData("masking-filter-01-f", 0.022)]
    // [InlineData("masking-intro-01-f", 0.022)]
    // [InlineData("masking-mask-01-b", 0.022)]
    // [InlineData("masking-mask-02-f", 0.022)]
    // [InlineData("masking-opacity-01-b", 0.022)]
    // [InlineData("masking-path-01-b", 0.022)]
    // [InlineData("masking-path-02-b", 0.022)]
    // [InlineData("masking-path-03-b", 0.022)]
    // [InlineData("masking-path-04-b", 0.022)]
    // [InlineData("masking-path-05-f", 0.022)]
    // [InlineData("masking-path-06-b", 0.022)]
    // [InlineData("masking-path-07-b", 0.022)]
    // [InlineData("masking-path-08-b", 0.022)]
    // [InlineData("masking-path-09-b", 0.022)]
    // [InlineData("masking-path-10-b", 0.022)]
    // [InlineData("masking-path-11-b", 0.022)]
    // [InlineData("masking-path-12-f", 0.022)]
    // [InlineData("masking-path-13-f", 0.022)]
    // [InlineData("masking-path-14-f", 0.022)]
    // [InlineData("metadata-example-01-t", 0.022)]
    // [InlineData("painting-control-01-f", 0.022)]
    // [InlineData("painting-control-02-f", 0.022)]
    // [InlineData("painting-control-03-f", 0.022)]
    // [InlineData("painting-control-04-f", 0.022)]
    // [InlineData("painting-control-05-f", 0.022)]
    // [InlineData("painting-control-06-f", 0.022)]
    // [InlineData("painting-fill-01-t", 0.022)]
    // [InlineData("painting-fill-02-t", 0.022)]
    // [InlineData("painting-fill-03-t", 0.022)]
    // [InlineData("painting-fill-04-t", 0.022)]
    // [InlineData("painting-fill-05-b", 0.022)]
    // [InlineData("painting-marker-01-f", 0.022)]
    // [InlineData("painting-marker-02-f", 0.022)]
    // [InlineData("painting-marker-03-f", 0.022)]
    // [InlineData("painting-marker-04-f", 0.022)]
    // [InlineData("painting-marker-05-f", 0.022)]
    // [InlineData("painting-marker-06-f", 0.022)]
    // [InlineData("painting-marker-07-f", 0.022)]
    // [InlineData("painting-marker-properties-01-f", 0.022)]
    // [InlineData("painting-render-01-b", 0.022)]
    // [InlineData("painting-render-02-b", 0.022)]
    // [InlineData("painting-stroke-01-t", 0.022)]
    // [InlineData("painting-stroke-02-t", 0.022)]
    // [InlineData("painting-stroke-03-t", 0.022)]
    // [InlineData("painting-stroke-04-t", 0.022)]
    // [InlineData("painting-stroke-05-t", 0.022)]
    // [InlineData("painting-stroke-06-t", 0.022)]
    // [InlineData("painting-stroke-07-t", 0.022)]
    // [InlineData("painting-stroke-08-t", 0.022)]
    // [InlineData("painting-stroke-09-t", 0.022)]
    // [InlineData("painting-stroke-10-t", 0.022)]
    // [InlineData("paths-data-01-t", 0.022)]
    // [InlineData("paths-data-02-t", 0.022)]
    // [InlineData("paths-data-03-f", 0.022)]
    // [InlineData("paths-data-04-t", 0.022)]
    // [InlineData("paths-data-05-t", 0.022)]
    // [InlineData("paths-data-06-t", 0.022)]
    // [InlineData("paths-data-07-t", 0.022)]
    // [InlineData("paths-data-08-t", 0.022)]
    // [InlineData("paths-data-09-t", 0.022)]
    // [InlineData("paths-data-10-t", 0.022)]
    // [InlineData("paths-data-12-t", 0.022)]
    // [InlineData("paths-data-13-t", 0.022)]
    // [InlineData("paths-data-14-t", 0.022)]
    // [InlineData("paths-data-15-t", 0.022)]
    // [InlineData("paths-data-16-t", 0.022)]
    // [InlineData("paths-data-17-f", 0.022)]
    // [InlineData("paths-data-18-f", 0.022)]
    // [InlineData("paths-data-19-f", 0.022)]
    // [InlineData("paths-data-20-f", 0.022)]
    // [InlineData("paths-dom-01-f", 0.022)]
    // [InlineData("paths-dom-02-f", 0.022)]
    // [InlineData("pservers-grad-01-b", 0.022)]
    // [InlineData("pservers-grad-02-b", 0.022)]
    // [InlineData("pservers-grad-03-b", 0.022)]
    // [InlineData("pservers-grad-04-b", 0.022)]
    // [InlineData("pservers-grad-05-b", 0.022)]
    // [InlineData("pservers-grad-06-b", 0.022)]
    // [InlineData("pservers-grad-07-b", 0.022)]
    // [InlineData("pservers-grad-08-b", 0.022)]
    // [InlineData("pservers-grad-09-b", 0.022)]
    // [InlineData("pservers-grad-10-b", 0.022)]
    // [InlineData("pservers-grad-11-b", 0.022)]
    // [InlineData("pservers-grad-12-b", 0.022)]
    // [InlineData("pservers-grad-13-b", 0.022)]
    // [InlineData("pservers-grad-14-b", 0.022)]
    // [InlineData("pservers-grad-15-b", 0.022)]
    // [InlineData("pservers-grad-16-b", 0.022)]
    // [InlineData("pservers-grad-17-b", 0.022)]
    // [InlineData("pservers-grad-18-b", 0.022)]
    // [InlineData("pservers-grad-20-b", 0.022)]
    // [InlineData("pservers-grad-21-b", 0.022)]
    // [InlineData("pservers-grad-22-b", 0.022)]
    // [InlineData("pservers-grad-23-f", 0.022)]
    // [InlineData("pservers-grad-24-f", 0.022)]
    // [InlineData("pservers-grad-stops-01-f", 0.022)]
    // [InlineData("pservers-pattern-01-b", 0.022)]
    // [InlineData("pservers-pattern-02-f", 0.022)]
    // [InlineData("pservers-pattern-03-f", 0.022)]
    // [InlineData("pservers-pattern-04-f", 0.022)]
    // [InlineData("pservers-pattern-05-f", 0.022)]
    // [InlineData("pservers-pattern-06-f", 0.022)]
    // [InlineData("pservers-pattern-07-f", 0.022)]
    // [InlineData("pservers-pattern-08-f", 0.022)]
    // [InlineData("pservers-pattern-09-f", 0.022)]
    // [InlineData("render-elems-01-t", 0.022)]
    // [InlineData("render-elems-02-t", 0.022)]
    // [InlineData("render-elems-03-t", 0.022)]
    // [InlineData("render-elems-06-t", 0.022)]
    // [InlineData("render-elems-07-t", 0.022)]
    // [InlineData("render-elems-08-t", 0.022)]
    // [InlineData("render-groups-01-b", 0.022)]
    // [InlineData("render-groups-03-t", 0.022)]
    // [InlineData("script-handle-01-b", 0.022)]
    // [InlineData("script-handle-02-b", 0.022)]
    // [InlineData("script-handle-03-b", 0.022)]
    // [InlineData("script-handle-04-b", 0.022)]
    // [InlineData("script-specify-01-f", 0.022)]
    // [InlineData("script-specify-02-f", 0.022)]
    // [InlineData("shapes-circle-01-t", 0.022)]
    // [InlineData("shapes-circle-02-t", 0.022)]
    // [InlineData("shapes-ellipse-01-t", 0.022)]
    // [InlineData("shapes-ellipse-02-t", 0.022)]
    // [InlineData("shapes-ellipse-03-f", 0.022)]
    // [InlineData("shapes-grammar-01-f", 0.022)]
    // [InlineData("shapes-intro-01-t", 0.022)]
    // [InlineData("shapes-intro-02-f", 0.022)]
    // [InlineData("shapes-line-01-t", 0.022)]
    // [InlineData("shapes-line-02-f", 0.022)]
    // [InlineData("shapes-polygon-01-t", 0.022)]
    // [InlineData("shapes-polygon-02-t", 0.022)]
    // [InlineData("shapes-polygon-03-t", 0.022)]
    // [InlineData("shapes-polyline-01-t", 0.022)]
    // [InlineData("shapes-polyline-02-t", 0.022)]
    // [InlineData("shapes-rect-01-t", 0.022)]
    // [InlineData("shapes-rect-02-t", 0.022)]
    // [InlineData("shapes-rect-03-t", 0.022)]
    // [InlineData("shapes-rect-04-f", 0.022)]
    // [InlineData("shapes-rect-05-f", 0.022)]
    // [InlineData("shapes-rect-06-f", 0.022)]
    // [InlineData("shapes-rect-07-f", 0.022)]
    // [InlineData("struct-cond-01-t", 0.022)]
    // [InlineData("struct-cond-02-t", 0.022)]
    // [InlineData("struct-cond-03-t", 0.022)]
    // [InlineData("struct-cond-overview-02-f", 0.022)]
    // [InlineData("struct-cond-overview-03-f", 0.022)]
    // [InlineData("struct-cond-overview-04-f", 0.022)]
    // [InlineData("struct-cond-overview-05-f", 0.022)]
    // [InlineData("struct-defs-01-t", 0.022)]
    // [InlineData("struct-dom-01-b", 0.022)]
    // [InlineData("struct-dom-02-b", 0.022)]
    // [InlineData("struct-dom-03-b", 0.022)]
    // [InlineData("struct-dom-04-b", 0.022)]
    // [InlineData("struct-dom-05-b", 0.022)]
    // [InlineData("struct-dom-06-b", 0.022)]
    // [InlineData("struct-dom-07-f", 0.022)]
    // [InlineData("struct-dom-08-f", 0.022)]
    // [InlineData("struct-dom-11-f", 0.022)]
    // [InlineData("struct-dom-12-b", 0.022)]
    // [InlineData("struct-dom-13-f", 0.022)]
    // [InlineData("struct-dom-14-f", 0.022)]
    // [InlineData("struct-dom-15-f", 0.022)]
    // [InlineData("struct-dom-16-f", 0.022)]
    // [InlineData("struct-dom-17-f", 0.022)]
    // [InlineData("struct-dom-18-f", 0.022)]
    // [InlineData("struct-dom-19-f", 0.022)]
    // [InlineData("struct-dom-20-f", 0.022)]
    // [InlineData("struct-frag-01-t", 0.022)]
    // [InlineData("struct-frag-02-t", 0.022)]
    // [InlineData("struct-frag-03-t", 0.022)]
    // [InlineData("struct-frag-04-t", 0.022)]
    // [InlineData("struct-frag-05-t", 0.022)]
    // [InlineData("struct-frag-06-t", 0.022)]
    // [InlineData("struct-group-01-t", 0.022)]
    // [InlineData("struct-group-02-b", 0.022)]
    // [InlineData("struct-group-03-t", 0.022)]
    // [InlineData("struct-image-01-t", 0.022)]
    // [InlineData("struct-image-02-b", 0.022)]
    // [InlineData("struct-image-03-t", 0.022)]
    // [InlineData("struct-image-04-t", 0.022)]
    // [InlineData("struct-image-05-b", 0.022)]
    // [InlineData("struct-image-06-t", 0.022)]
    // [InlineData("struct-image-07-t", 0.022)]
    // [InlineData("struct-image-08-t", 0.022)]
    // [InlineData("struct-image-09-t", 0.022)]
    // [InlineData("struct-image-10-t", 0.022)]
    // [InlineData("struct-image-11-b", 0.022)]
    // [InlineData("struct-image-12-b", 0.022)]
    // [InlineData("struct-image-13-f", 0.022)]
    // [InlineData("struct-image-14-f", 0.022)]
    // [InlineData("struct-image-15-f", 0.022)]
    // [InlineData("struct-image-16-f", 0.022)]
    // [InlineData("struct-image-17-b", 0.022)]
    // [InlineData("struct-image-18-f", 0.022)]
    // [InlineData("struct-image-19-f", 0.022)]
    // [InlineData("struct-svg-01-f", 0.022)]
    // [InlineData("struct-svg-02-f", 0.022)]
    // [InlineData("struct-svg-03-f", 0.022)]
    // [InlineData("struct-symbol-01-b", 0.022)]
    // [InlineData("struct-use-01-t", 0.022)]
    // [InlineData("struct-use-03-t", 0.022)]
    // [InlineData("struct-use-04-b", 0.022)]
    // [InlineData("struct-use-05-b", 0.022)]
    // [InlineData("struct-use-06-b", 0.022)]
    // [InlineData("struct-use-07-b", 0.022)]
    // [InlineData("struct-use-08-b", 0.022)]
    // [InlineData("struct-use-09-b", 0.022)]
    // [InlineData("struct-use-10-f", 0.022)]
    // [InlineData("struct-use-11-f", 0.022)]
    // [InlineData("struct-use-12-f", 0.022)]
    // [InlineData("struct-use-13-f", 0.022)]
    // [InlineData("struct-use-14-f", 0.022)]
    // [InlineData("struct-use-15-f", 0.022)]
    // [InlineData("styling-class-01-f", 0.022)]
    // [InlineData("styling-css-01-b", 0.022)]
    // [InlineData("styling-css-02-b", 0.022)]
    // [InlineData("styling-css-03-b", 0.022)]
    // [InlineData("styling-css-04-f", 0.022)]
    // [InlineData("styling-css-05-b", 0.022)]
    // [InlineData("styling-css-06-b", 0.022)]
    // [InlineData("styling-css-07-f", 0.022)]
    // [InlineData("styling-css-08-f", 0.022)]
    // [InlineData("styling-css-09-f", 0.022)]
    // [InlineData("styling-css-10-f", 0.022)]
    // [InlineData("styling-elem-01-b", 0.022)]
    // [InlineData("styling-inherit-01-b", 0.022)]
    // [InlineData("styling-pres-01-t", 0.022)]
    // [InlineData("styling-pres-02-f", 0.022)]
    // [InlineData("styling-pres-03-f", 0.022)]
    // [InlineData("styling-pres-04-f", 0.022)]
    // [InlineData("styling-pres-05-f", 0.022)]
    // [InlineData("svgdom-over-01-f", 0.022)]
    // [InlineData("text-align-01-b", 0.022)]
    // [InlineData("text-align-02-b", 0.022)]
    // [InlineData("text-align-03-b", 0.022)]
    // [InlineData("text-align-04-b", 0.022)]
    // [InlineData("text-align-05-b", 0.022)]
    // [InlineData("text-align-06-b", 0.022)]
    // [InlineData("text-align-07-t", 0.022)]
    // [InlineData("text-align-08-b", 0.022)]
    // [InlineData("text-altglyph-01-b", 0.022)]
    // [InlineData("text-altglyph-02-b", 0.022)]
    // [InlineData("text-altglyph-03-b", 0.022)]
    // [InlineData("text-bidi-01-t", 0.022)]
    // [InlineData("text-deco-01-b", 0.022)]
    // [InlineData("text-dom-01-f", 0.022)]
    // [InlineData("text-dom-02-f", 0.022)]
    // [InlineData("text-dom-03-f", 0.022)]
    // [InlineData("text-dom-04-f", 0.022)]
    // [InlineData("text-dom-05-f", 0.022)]
    // [InlineData("text-fonts-01-t", 0.022)]
    // [InlineData("text-fonts-02-t", 0.022)]
    // [InlineData("text-fonts-03-t", 0.022)]
    // [InlineData("text-fonts-04-t", 0.022)]
    // [InlineData("text-fonts-05-f", 0.022)]
    // [InlineData("text-fonts-06-t", 0.022)]
    // [InlineData("text-fonts-202-t", 0.022)]
    // [InlineData("text-fonts-203-t", 0.022)]
    // [InlineData("text-fonts-204-t", 0.022)]
    // [InlineData("text-intro-01-t", 0.022)]
    // [InlineData("text-intro-02-b", 0.022)]
    // [InlineData("text-intro-03-b", 0.022)]
    // [InlineData("text-intro-04-t", 0.022)]
    // [InlineData("text-intro-05-t", 0.022)]
    // [InlineData("text-intro-06-t", 0.022)]
    // [InlineData("text-intro-07-t", 0.022)]
    // [InlineData("text-intro-09-b", 0.022)]
    // [InlineData("text-intro-10-f", 0.022)]
    // [InlineData("text-intro-11-t", 0.022)]
    // [InlineData("text-intro-12-t", 0.022)]
    // [InlineData("text-path-01-b", 0.022)]
    // [InlineData("text-path-02-b", 0.022)]
    // [InlineData("text-spacing-01-b", 0.022)]
    // [InlineData("text-text-01-b", 0.022)]
    // [InlineData("text-text-03-b", 0.022)]
    // [InlineData("text-text-04-t", 0.022)]
    // [InlineData("text-text-05-t", 0.022)]
    // [InlineData("text-text-06-t", 0.022)]
    // [InlineData("text-text-07-t", 0.022)]
    // [InlineData("text-text-08-b", 0.022)]
    // [InlineData("text-text-09-t", 0.022)]
    // [InlineData("text-text-10-t", 0.022)]
    // [InlineData("text-text-11-t", 0.022)]
    // [InlineData("text-text-12-t", 0.022)]
    // [InlineData("text-tref-01-b", 0.022)]
    // [InlineData("text-tref-02-b", 0.022)]
    // [InlineData("text-tref-03-b", 0.022)]
    // [InlineData("text-tselect-01-b", 0.022)]
    // [InlineData("text-tselect-02-f", 0.022)]
    // [InlineData("text-tselect-03-f", 0.022)]
    // [InlineData("text-tspan-01-b", 0.022)]
    // [InlineData("text-tspan-02-b", 0.022)]
    // [InlineData("text-ws-01-t", 0.022)]
    // [InlineData("text-ws-02-t", 0.022)]
    // [InlineData("text-ws-03-t", 0.022)]
    // [InlineData("types-basic-01-f", 0.022)]
    // [InlineData("types-basic-02-f", 0.022)]
    // [InlineData("types-dom-01-b", 0.022)]
    // [InlineData("types-dom-02-f", 0.022)]
    // [InlineData("types-dom-03-b", 0.022)]
    // [InlineData("types-dom-04-b", 0.022)]
    // [InlineData("types-dom-05-b", 0.022)]
    // [InlineData("types-dom-06-f", 0.022)]
    // [InlineData("types-dom-07-f", 0.022)]
    // [InlineData("types-dom-08-f", 0.022)]
    // [InlineData("types-dom-svgfittoviewbox-01-f", 0.022)]
    // [InlineData("types-dom-svglengthlist-01-f", 0.022)]
    // [InlineData("types-dom-svgnumberlist-01-f", 0.022)]
    // [InlineData("types-dom-svgstringlist-01-f", 0.022)]
    // [InlineData("types-dom-svgtransformable-01-f", 0.022)]

    [WindowsAndOSXTheory(Skip = "TODO")]
    [InlineData("coords-trans-01-b", 0.022)]
    [InlineData("coords-trans-02-t", 0.022)]
    [InlineData("coords-trans-03-t", 0.022)]
    [InlineData("coords-trans-04-t", 0.022)]
    [InlineData("coords-trans-05-t", 0.022)]
    [InlineData("coords-trans-06-t", 0.022)]
    [InlineData("coords-trans-07-t", 0.022)]
    [InlineData("coords-trans-08-t", 0.022)]
    [InlineData("coords-trans-09-t", 0.022)]
    [InlineData("coords-trans-10-f", 0.022)]
    [InlineData("coords-trans-11-f", 0.022)]
    [InlineData("coords-trans-12-f", 0.022)]
    [InlineData("coords-trans-13-f", 0.022)]
    [InlineData("coords-trans-14-f", 0.022)]
    public void coords_trans(string name, double errorThreshold) => TestImpl(name, errorThreshold);
    
    [WindowsAndOSXTheory(Skip = "TODO")]
    [InlineData("coords-transformattr-01-f", 0.022)]
    [InlineData("coords-transformattr-02-f", 0.022)]
    [InlineData("coords-transformattr-03-f", 0.022)]
    [InlineData("coords-transformattr-04-f", 0.022)]
    [InlineData("coords-transformattr-05-f", 0.022)]
    public void coords_transformattr(string name, double errorThreshold) => TestImpl(name, errorThreshold);

    [WindowsAndOSXTheory]
    [InlineData("paths-data-01-t", 0.074)]
    [InlineData("paths-data-02-t", 0.086)]
    [InlineData("paths-data-03-f", 0.076)]
    [InlineData("paths-data-04-t", 0.075)]
    [InlineData("paths-data-05-t", 0.069)]
    [InlineData("paths-data-06-t", 0.067)]
    [InlineData("paths-data-07-t", 0.065)]
    [InlineData("paths-data-08-t", 0.080)]
    [InlineData("paths-data-09-t", 0.076)]
    [InlineData("paths-data-10-t", 0.101)]
    [InlineData("paths-data-12-t", 0.062)]
    [InlineData("paths-data-13-t", 0.062)]
    [InlineData("paths-data-14-t", 0.064)]
    [InlineData("paths-data-15-t", 0.063)]
    [InlineData("paths-data-16-t", 0.069)]
    [InlineData("paths-data-17-f", 0.068)]
    [InlineData("paths-data-18-f", 0.059)]
    [InlineData("paths-data-19-f", 0.076)]
    [InlineData("paths-data-20-f", 0.063)]
    public void paths_data(string name, double errorThreshold) => TestImpl(name, errorThreshold);

    [WindowsTheory]
    [InlineData("__AJ_Digital_Camera", 0.027)]
    [InlineData("__Telefunken_FuBK_test_pattern", 0.022)]
    [InlineData("__tiger", 0.055)]
    public void Misc(string name, double errorThreshold) => TestImpl(name, errorThreshold);
}
