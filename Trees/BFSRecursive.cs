// Program for BFS of a tree recursive.

using System;

public class Node {
  public int data;
  public Node left, right;

  public Node(int item) {
    data = item;
    left = right = null;
  }
}

class BFS {
  public Node root;

  public void BinaryTree() {
    root = null;
  }

  // function to print level order traversal of tree
  public virtual void printLevelOrder() {
    int h = height(root);
    int i;
    for (i = 1; i <= h; i++) {
      printGivenLevel(root, i);
    }
  }

  public virtual int height(Node root) {
    if(root == null) {
      return 0;
    }
    else {
      // compute height of each subtree
      int lheight = height(root.left);
      int rheight = height(root.right);

      // Use the larger one
      if (lheight > rheight) {
        return (lheight + 1);
      }
      else {
        return (rheight + 1);
      }
    }
  }

  // Print Nodes at a given level
  public virtual void printGivenLevel(Node root, int level) {
    if (root == null)
      return;

    if (level == 1)
    {
      Console.WriteLine(root.data + " ");
    }
    else if (level > 1) {
      printGivenLevel(root.left, level - 1);
      printGivenLevel(root.right, level - 1);
    }
  }

  // Driver Code
  public static void Main(string[] args) {
    BFS tree = new BFS();
    tree.root = new Node(1);
    tree.root.left = new Node(2);
    tree.root.right = new Node(3);
    tree.root.left.left = new Node(4);
    tree.root.left.right = new Node(5);
    Console.WriteLine("Level order traversal " +
                          "of binary tree is ");
    tree.printLevelOrder();
  }
  // Time complexity: O(n^2) worst case.
}
