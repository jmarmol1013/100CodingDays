class TreeNode(object):
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right
        
class Solution(object):
    def rangeSumBST(self, root, L, R):
        if root == None: return 0
        if root.val > R: return self.rangeSumBST(root.left,L,R)
        if root.val < L: return self.rangeSumBST(root.right,L,R)
        return root.val + self.rangeSumBST(root.left,L,R) + self.rangeSumBST(root.right,L,R)        
