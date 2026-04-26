// Optimal Approach (2D Prefix Sum)

// 🔥 THIS is what interviewer wants.

// 💡 Core Idea:

// Create a 2D prefix matrix:

// prefix[r][c] = sum of rectangle from (0,0) → (r-1,c-1)
// TC: O(n*m)
// SC: O(1)

public class NumMatrix {
    private int[][] sumMatrix;

    public NumMatrix(int[][] matrix) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        sumMatrix = new int[rows + 1][];

        for (int i = 0; i <= rows; i++) {
            sumMatrix[i] = new int[cols + 1];
        }

        // Build prefix (same as video)
        for (int r = 1; r <= rows; r++) {
            for (int c = 1; c <= cols; c++) {
                sumMatrix[r][c] =
                    matrix[r - 1][c - 1]
                    + sumMatrix[r - 1][c]
                    + sumMatrix[r][c - 1]
                    - sumMatrix[r - 1][c - 1];
            }
        }
    }

    public int SumRegion(int row1, int col1, int row2, int col2) {
        return sumMatrix[row2 + 1][col2 + 1]
             - sumMatrix[row1][col2 + 1]
             - sumMatrix[row2 + 1][col1]
             + sumMatrix[row1][col1];
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */