public class Solution {
    public bool CheckValid(int[][] matrix) {
        Dictionary<int, List<int>> hash = new(); //Line, Int[]
        int colLength = matrix[0].Length;
        for (int i = 0;i<matrix.Length;i++)
        {
            var row = matrix[i];
            if (!hash.ContainsKey(i))
                hash.Add(i, new());
            for (int j = 0; j < matrix[i].Length;j++)
            {
                var number = row[j];
                var element = hash[i];
                if (element.Contains(number))
                    return false;
                else
                    element.Add(number);
            }
        }
        Dictionary<int, List<int>> hashTopBottom = new(); //Line, Int[]
        for (int j = 0; j < colLength; j++)
        {
            if (!hashTopBottom.ContainsKey(j))
                hashTopBottom.Add(j, new());
            for (int i = 0; i < matrix.Length; i++)
            {
                var number = matrix[i][j];
                var element = hashTopBottom[j];
                if (element.Contains(number))
                    return false;
                else
                    element.Add(number);
            }
        }
        return true;
    }
}