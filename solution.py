class Solution:
    def helper(self, root, arr):
        if not root: 
            return

        arr.append(root.val)
        for c in root.children:
            self.helper(c, arr)

    def preorder(self, root):
        arr = []
        self.helper(root, arr)
        return arr
