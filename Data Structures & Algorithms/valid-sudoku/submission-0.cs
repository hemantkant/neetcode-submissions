public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> seen = new HashSet<string>();
        for(int r = 0; r<9; r++){
            for(int c = 0; c<9; c++){
                if(board[r][c] == '.') continue;
                string val = board[r][c].ToString();
                string rowKey= "row" + r+ val;
                string colKey = "col"+c+val;
                string boxKey = "box"+(r/3*3+c/3) + val;

                if(seen.Contains(rowKey) ||
                    seen.Contains(colKey) ||
                     seen.Contains(boxKey)){
                        return false;
                     }
                seen.Add(rowKey);
                seen.Add(colKey);
                seen.Add(boxKey); 
            }
        }
        return true;
    }
}
