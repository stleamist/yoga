/**
 * Copyright (c) 2014-present, Facebook, Inc.
 * All rights reserved.
 *
 * This source code is licensed under the BSD-style license found in the
 * LICENSE file in the root directory of this source tree. An additional grant
 * of patent rights can be found in the PATENTS file in the same directory.
 */

 // @Generated by gentest/gentest.rb from gentest/fixtures/CSSLayoutAbsolutePositionTest.html

using System;
using NUnit.Framework;

namespace Facebook.CSSLayout
{
    [TestFixture]
    public class CSSLayoutAbsolutePositionTest
    {
        [Test]
        public void Test_absolute_layout_width_height_start_top()
        {
            CSSNode root = new CSSNode();
            root.Width = 100f;
            root.Height = 100f;

            CSSNode root_child0 = new CSSNode();
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.SetPosition(YogaEdge.Start, 10f);
            root_child0.SetPosition(YogaEdge.Top, 10f);
            root_child0.Width = 10f;
            root_child0.Height = 10f;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(80f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_width_height_end_bottom()
        {
            CSSNode root = new CSSNode();
            root.Width = 100f;
            root.Height = 100f;

            CSSNode root_child0 = new CSSNode();
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.SetPosition(YogaEdge.End, 10f);
            root_child0.SetPosition(YogaEdge.Bottom, 10f);
            root_child0.Width = 10f;
            root_child0.Height = 10f;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(80f, root_child0.LayoutX);
            Assert.AreEqual(80f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(80f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_start_top_end_bottom()
        {
            CSSNode root = new CSSNode();
            root.Width = 100f;
            root.Height = 100f;

            CSSNode root_child0 = new CSSNode();
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.SetPosition(YogaEdge.Start, 10f);
            root_child0.SetPosition(YogaEdge.Top, 10f);
            root_child0.SetPosition(YogaEdge.End, 10f);
            root_child0.SetPosition(YogaEdge.Bottom, 10f);
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(80f, root_child0.LayoutWidth);
            Assert.AreEqual(80f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(80f, root_child0.LayoutWidth);
            Assert.AreEqual(80f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_width_height_start_top_end_bottom()
        {
            CSSNode root = new CSSNode();
            root.Width = 100f;
            root.Height = 100f;

            CSSNode root_child0 = new CSSNode();
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.SetPosition(YogaEdge.Start, 10f);
            root_child0.SetPosition(YogaEdge.Top, 10f);
            root_child0.SetPosition(YogaEdge.End, 10f);
            root_child0.SetPosition(YogaEdge.Bottom, 10f);
            root_child0.Width = 10f;
            root_child0.Height = 10f;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(80f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_do_not_clamp_height_of_absolute_node_to_height_of_its_overflow_hidden_parent()
        {
            CSSNode root = new CSSNode();
            root.FlexDirection = YogaFlexDirection.Row;
            root.Overflow = YogaOverflow.Hidden;
            root.Width = 50f;
            root.Height = 50f;

            CSSNode root_child0 = new CSSNode();
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.SetPosition(YogaEdge.Start, 0f);
            root_child0.SetPosition(YogaEdge.Top, 0f);
            root.Insert(0, root_child0);

            CSSNode root_child0_child0 = new CSSNode();
            root_child0_child0.Width = 100f;
            root_child0_child0.Height = 100f;
            root_child0.Insert(0, root_child0_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(50f, root.LayoutWidth);
            Assert.AreEqual(50f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(100f, root_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child0.LayoutX);
            Assert.AreEqual(0f, root_child0_child0.LayoutY);
            Assert.AreEqual(100f, root_child0_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(50f, root.LayoutWidth);
            Assert.AreEqual(50f, root.LayoutHeight);

            Assert.AreEqual(-50f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(100f, root_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child0.LayoutX);
            Assert.AreEqual(0f, root_child0_child0.LayoutY);
            Assert.AreEqual(100f, root_child0_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_within_border()
        {
            CSSNode root = new CSSNode();
            root.SetMargin(YogaEdge.Left, 10f);
            root.SetMargin(YogaEdge.Top, 10f);
            root.SetMargin(YogaEdge.Right, 10f);
            root.SetMargin(YogaEdge.Bottom, 10f);
            root.SetPadding(YogaEdge.Left, 10f);
            root.SetPadding(YogaEdge.Top, 10f);
            root.SetPadding(YogaEdge.Right, 10f);
            root.SetPadding(YogaEdge.Bottom, 10f);
            root.SetBorder(YogaEdge.Left, 10f);
            root.SetBorder(YogaEdge.Top, 10f);
            root.SetBorder(YogaEdge.Right, 10f);
            root.SetBorder(YogaEdge.Bottom, 10f);
            root.Width = 100f;
            root.Height = 100f;

            CSSNode root_child0 = new CSSNode();
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.SetPosition(YogaEdge.Left, 0f);
            root_child0.SetPosition(YogaEdge.Top, 0f);
            root_child0.Width = 50f;
            root_child0.Height = 50f;
            root.Insert(0, root_child0);

            CSSNode root_child1 = new CSSNode();
            root_child1.PositionType = YogaPositionType.Absolute;
            root_child1.SetPosition(YogaEdge.Right, 0f);
            root_child1.SetPosition(YogaEdge.Bottom, 0f);
            root_child1.Width = 50f;
            root_child1.Height = 50f;
            root.Insert(1, root_child1);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(10f, root.LayoutX);
            Assert.AreEqual(10f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(40f, root_child1.LayoutX);
            Assert.AreEqual(40f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(50f, root_child1.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(10f, root.LayoutX);
            Assert.AreEqual(10f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(40f, root_child1.LayoutX);
            Assert.AreEqual(40f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(50f, root_child1.LayoutHeight);
        }

    }
}
