/**
 * Copyright (c) 2014-present, Facebook, Inc.
 * All rights reserved.
 *
 * This source code is licensed under the BSD-style license found in the
 * LICENSE file in the root directory of this source tree. An additional grant
 * of patent rights can be found in the PATENTS file in the same directory.
 */

#include <CSSLayout/CSSLayout.h>
#include <gtest/gtest.h>

TEST(CSSLayoutTest, dirty_propagation) {
  const CSSNodeRef root = CSSNodeNew();
  CSSNodeStyleSetAlignItems(root, YGAlignFlexStart);
  CSSNodeStyleSetWidth(root, 100);
  CSSNodeStyleSetHeight(root, 100);

  const CSSNodeRef root_child0 = CSSNodeNew();
  CSSNodeStyleSetWidth(root_child0, 50);
  CSSNodeStyleSetHeight(root_child0, 20);
  CSSNodeInsertChild(root, root_child0, 0);

  const CSSNodeRef root_child1 = CSSNodeNew();
  CSSNodeStyleSetWidth(root_child1, 50);
  CSSNodeStyleSetHeight(root_child1, 20);
  CSSNodeInsertChild(root, root_child1, 1);

  CSSNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionLTR);

  CSSNodeStyleSetWidth(root_child0, 20);

  EXPECT_TRUE(CSSNodeIsDirty(root_child0));
  EXPECT_FALSE(CSSNodeIsDirty(root_child1));
  EXPECT_TRUE(CSSNodeIsDirty(root));

  CSSNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionLTR);

  EXPECT_FALSE(CSSNodeIsDirty(root_child0));
  EXPECT_FALSE(CSSNodeIsDirty(root_child1));
  EXPECT_FALSE(CSSNodeIsDirty(root));

  CSSNodeFreeRecursive(root);
}

TEST(CSSLayoutTest, dirty_propagation_only_if_prop_changed) {
  const CSSNodeRef root = CSSNodeNew();
  CSSNodeStyleSetAlignItems(root, YGAlignFlexStart);
  CSSNodeStyleSetWidth(root, 100);
  CSSNodeStyleSetHeight(root, 100);

  const CSSNodeRef root_child0 = CSSNodeNew();
  CSSNodeStyleSetWidth(root_child0, 50);
  CSSNodeStyleSetHeight(root_child0, 20);
  CSSNodeInsertChild(root, root_child0, 0);

  const CSSNodeRef root_child1 = CSSNodeNew();
  CSSNodeStyleSetWidth(root_child1, 50);
  CSSNodeStyleSetHeight(root_child1, 20);
  CSSNodeInsertChild(root, root_child1, 1);

  CSSNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionLTR);

  CSSNodeStyleSetWidth(root_child0, 50);

  EXPECT_FALSE(CSSNodeIsDirty(root_child0));
  EXPECT_FALSE(CSSNodeIsDirty(root_child1));
  EXPECT_FALSE(CSSNodeIsDirty(root));

  CSSNodeFreeRecursive(root);
}

TEST(CSSLayoutTest, dirty_node_only_if_children_are_actually_removed) {
  const CSSNodeRef root = CSSNodeNew();
  CSSNodeStyleSetAlignItems(root, YGAlignFlexStart);
  CSSNodeStyleSetWidth(root, 50);
  CSSNodeStyleSetHeight(root, 50);

  const CSSNodeRef child0 = CSSNodeNew();
  CSSNodeStyleSetWidth(child0, 50);
  CSSNodeStyleSetHeight(child0, 25);
  CSSNodeInsertChild(root, child0, 0);

  CSSNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionLTR);

  const CSSNodeRef child1 = CSSNodeNew();
  CSSNodeRemoveChild(root, child1);
  EXPECT_FALSE(CSSNodeIsDirty(root));
  CSSNodeFree(child1);

  CSSNodeRemoveChild(root, child0);
  EXPECT_TRUE(CSSNodeIsDirty(root));
  CSSNodeFree(child0);

  CSSNodeFreeRecursive(root);
}
