public class Solution {
    private void preorder(Node root, List<int> list){
        if(root == null){
            return;
        }

        list.Add(root.val);
        for(int i = 0; i < root.children.Count; i++){
            preorder(root.children[i], list);
        }
    }

    public IList<int> Preorder(Node root) {
        List<int> list = new List<int>();
        preorder(root, list);
        return(list);
    }
}
