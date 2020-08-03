namespace LeetCode.StringAndArray
{
    /// <summary>
    /// 面试题 01.07. 旋转矩阵
    /// </summary>
    public class RotateMatrixLCCI
    {
        public void Rotate(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = i; j < matrix.Length - 1 - i; j++)
                {
                    // 左上和右上交换
                    matrix[i][j] = matrix[i][j] ^ matrix[j][matrix.Length - 1 - i];
                    matrix[j][matrix.Length - 1 - i] = matrix[i][j] ^ matrix[j][matrix.Length - 1 - i];
                    matrix[i][j] = matrix[i][j] ^ matrix[j][matrix.Length - 1 - i];

                    // 左下和右下交换
                    matrix[matrix.Length - 1 - j][i] = matrix[matrix.Length - 1 - j][i] ^ matrix[matrix.Length - 1 - i][matrix.Length - 1 - j];
                    matrix[matrix.Length - 1 - i][matrix.Length - 1 - j] = matrix[matrix.Length - 1 - j][i] ^ matrix[matrix.Length - 1 - i][matrix.Length - 1 - j];
                    matrix[matrix.Length - 1 - j][i] = matrix[matrix.Length - 1 - j][i] ^ matrix[matrix.Length - 1 - i][matrix.Length - 1 - j];

                    // 左上和右下交换
                    matrix[i][j] = matrix[i][j] ^ matrix[matrix.Length - 1 - i][matrix.Length - 1 - j];
                    matrix[matrix.Length - 1 - i][matrix.Length - 1 - j] = matrix[i][j] ^ matrix[matrix.Length - 1 - i][matrix.Length - 1 - j];
                    matrix[i][j] = matrix[i][j] ^ matrix[matrix.Length - 1 - i][matrix.Length - 1 - j];
                }
            }
        }
    }
}
/*
 *# 审题
 * 题目要求旋转矩阵，那么第一个想到的就是元素的交换，一般是借助第三个变量来进行
 * int x=1;
 * int y=2;
 * int temp;
 * temp=x;
 * x=y;
 * y=temp;
 *
 * 这样就完成了两个元素的交换，但是题目中要求不占用额外的空间，那么就用交换律来实现
 * int x=1;
 * int y=2;
 * x=x+y;
 * y=x-y;
 * x=x-y;
 *
 * 题目中还有一个条件，每一个元素是4个字节的大小。我们知道int是4个字节，如果用加法，就会溢出。那么我们用异或^就能解决问题
 * int x=1;
 * int y=2;
 * x=x ^ y;
 * y=x ^ y;
 * y=x ^ y;
 *
 * # 解题
 * 按照左上、右上交换，右上、右下交换，左下、左上交换；顺时针交换全部元素即可
 */