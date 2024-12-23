using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here

        // end

        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        // code here

        // end

        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        int answer = 0;
        // code here
        int n = A.GetLength(0), k = A.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < k; j++)
            {
                if (i == j)
                {
                    answer += A[i, j];
                }
            }

        }
        // end

        return answer;
    }   
    public (int, int) Task_1_4(int[,] A)
    {
        int row = 0, col = 0;
        // code here

        // end

        return (row, col);
    }
    public (int, int) Task_1_5(int[,] A, int colIndex)
    {
        int value = 0, rowIndex = -1;
        // code here

        // end

        return (value, rowIndex);
    }
    public int[] Task_1_6(int[,] A)
    {
        int[] answer = new int[4];
        // code here
        int mi = 0;
        for (int i = 0; i < 4; i++)
        {
            mi = 100000;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < mi)
                {
                    mi = A[i, j];
                }
            }
            answer[i] = mi;
        }
        // end

        return answer;
    }
    public int[] Task_1_7(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public double[] Task_1_8(int[,] A)
    {
        double[] answer = default(double[]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_1_9(int[,] A)
    {
        int p = 0;
        int ind = 0;
        int ma = 0;
        for (int i = 0; i < 5; i++)
        {
            ma = 0;
            for (int j = 0; j < 7; j++)
            {
                if ((A[i, j] > ma)) {
                    ind = j;
                    ma = A[i, j];
                }
            }
            p = A[i, ind];
            A[i, ind] = A[i, 1];
            A[i, 1] = p;
        }

        // end

        return A;
    }
    public int[,] Task_1_10(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_11(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_12(int[,] A)
    {
        int[,] B = new int[5, 6];
        int ma = 0;
        int ind1 = 0;
        int ind2 = 0;
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > ma)
                {
                    ma = A[i, j];
                    ind1 = i;
                    ind2 = j;
                }
            }
        }
        int i1 = 0; int i2 = 0;
        int j1 = 0; int j2 = 0;
        while (i1 < 5)
        {
            while (j1 < 6)
            {
                if (i2 == ind1)
                {
                    i2++;
                }
                if (j2 == ind2)
                {
                    j2++;
                }
                B[i1, j1] = A[i2, j2];
                j1++;
            }
            j1 = 0;
            i1++;
        }

        // end

        return B;
    }
    public int[,] Task_1_13(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[] Task_1_14(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_1_15(int[,] A)
    {
        int ma = 0;
        int ind = 0;
        for (int i = 0; i < 5; i++)
        {
            ma = 0;
            ind = 0;
            for (int j = 0; j < 7; j++)
            {
                if ((A[i, j] > ma))
                {
                    ma = A[i, j];
                    ind = j;
                }
                A[i, ind] *= i;
            }
        }

        // end

        return A;
    }
    public int[,] Task_1_16(int[,] A, int n, int m)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_17(int[,] B, int n, int m)
    {
        // code here

        // end

        return B;
    }
    public int[,] Task_1_18(int[,] D, int n, int m)
    {
        int ma = 0;
        int ind = 0;
        int first = 0;
        int last = 0;
        int p = 0;
        for (int i = 0; i < n; i++)
        {
            ma = 0;
            ind = 0;
            first = 0;
            last = m - 1;
            while (true)
            {
                if (D[i, first] < 0)
                {
                    break;
                }
                else
                {
                    first++;
                }
            }
            while (true)
            {
                if (D[i, last] < 0)
                {
                    break;
                }
                else
                {
                    last--;
                }
            }
            for (int j = 0; j < first; j++)
            {
                if ((D[i, j] > ma))
                {
                    ma = D[i, j];
                    ind = j;
                }
            }
            p = D[i, ind];
            D[i, ind] = D[i, last];
            D[i, last] = D[i, ind];

        }

        return D;
    }
    public double[,] Task_1_19(double[,] C, int n, int m)
    {
        // code here

        // end

        return C;
    }
    public double[,] Task_1_20(double[,] F, int n, int m)
    {
        // code here

        // end

        return F;
    }
    public int[,] Task_1_21(int[,] H)
    {
        int ma = 0;
        int ind = 0;
        for (int i = 0; i < 5; i++)
        {
            ma = 0;
            ind = 0;
            for (int j = 0; j < 6; j++)
            {
                if ((H[i, j] > ma))
                {
                    ma = H[i, j];
                    ind = j;
                }

            }
            H[i, 7] = H[i, 6];
            H[i, 6] = ma;
        }

        return H;
    }
    public double[,] Task_1_22(double[,] Z)
    {
        // code here

        // end

        return Z;
    }
    public int[,] Task_1_23(int[,] G)
    {
        // code here

        // end

        return G;
    }
    public double[,] Task_1_24(double[,] Y)
    {
        double ma = 0;
        int ind = 0;
        double s = 0;
        for (int i = 0; i < 6; i++)
        {
            ma = 0;
            ind = 0;
            s = 0;
            for (int j = 0; j < 5; j++)
            {
                if ((Y[i, j] > ma))
                {
                    ma = Y[i, j];
                    ind = j;
                }


            }
            ind++;
            for (int x = ind; x < 5; x++)
            {
                if (Y[i, x] > 0) {
                    s += Y[i, x];
                } }

            s = s / (5 - ind);
            for (int x = 0; x < ind; x++)
            {
                if (Y[i, x] < 0)
                {
                    Y[i, x] = s;
                }
            }

        }

        return Y;
    }
    public int[,] Task_1_25(int[,] X)
    {
        // code here

        // end

        return X;
    }
    public int[,] Task_1_26(int[,] A, int[] B)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_27(int[,] B)
    {
        int ma = 0;
        int ind = 0;

        for (int i = 0; i < 5; i++)
        {
            ma = 0;
            ind = 0;

            for (int j = 0; j < 7; j++)
            {
                if ((B[i, j] > ma))
                {
                    ma = B[i, j];
                    ind = j;
                }


            }
            B[i, 4] = ma;



        }
        int p = 0;
        for (int i = 0; i < 2; i++)
        {
            p = B[i, 4];
            B[i, 4] = B[4 - i, 4];
            B[4 - i, 4] = p;
        }


        return B;
    }
    public int[,] Task_1_28(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_29(int[,] F)
    {
        // code here

        // end

        return F;
    }
    public int[,] Task_1_30(int[,] B)
    {
        int ma = 0;
        int ind = 0;
        int ind2 = 0; 
        for (int i = 0; i < 5; i++)
        {
            if( B[i,i] > ma)
            {
                ma = B[i,i];
                ind = i;
            }

           
        }
        for (int i = 0;i < 5; i++)
        {
            if( B[i,3] < 0)
            {
                ind2 = i;
                break;
            }
        }
        return B;
        public int[,] Task_1_31(int[,] A, int[] B)
        {
            // code here

            // end

            return A;
        }
        public double[,] Task_1_32(double[,] A)
        {
            // code here

            // end

            return A;
        }
        public int[] Task_1_33(int[,] A)
        {
            int[] answer = default(int[]);
            // code here

            // end

            return answer;
        }
        #endregion

        #region Level 2
        public double[,] Task_2_1(double[,] A)
        {
            // code here

            // end

            return A;
        }

        public int[,] Task_2_2(int[,] A)
        {
            // code here

            // end

            return A;
        }
        public int[,] Task_2_3(int[,] A)
        {
            // code here

            // end

            return A;
        }
        public int[,] Task_2_4(int[,] A, int[] B)
        {
            // code here

            // end

            return A;
        }
        public double[,] Task_2_5(double[,] A)
        {
            // code here

            // end

            return A;
        }
        public int[,] Task_2_6(int n)
        {
            int[,] answer = default(int[,]);
            // code here

            // end

            return answer;
        }
        public int[,] Task_2_7(int[,] A)
        {
            // code here

            // end

            return A;
        }
        public int[,] Task_2_8(int[,] B)
        {
            // code here

            // end

            return B;
        }
        public int[,] Task_2_9(int[,] A)
        {
            // code here

            // end

            return A;
        }
        #endregion
        #region Level 3
        public int[,] Task_3_1(int[,] matrix)
        {
            // code here

            // end

            return matrix;
        }
        public int[,] Task_3_2(int[,] matrix)
        {
            // code here

            // end

            return matrix;
        }
        public int[] Task_3_3(int[,] matrix)
        {
            int[] answer = default(int[]);
            // code here

            // end

            return answer;
        }
        public int[,] Task_3_4(int[,] matrix)
        {
            // code here

            // end

            return matrix;
        }
        public int[,] Task_3_5(int[,] matrix, int k)
        {
            // code here

            // end

            return matrix;
        }
        public (int[], int[]) Task_3_6(int[,] matrix)
        {
            int[] upper = default(int[]);
            int[] lower = default(int[]);
            // code here

            // end

            return (upper, lower);
        }
        public int[] Task_3_7(int[] A, int[] B, int n)
        {
            int[] answer = default(int[]);

            // code here

            // end

            return answer;
        }
        public int[,] Task_3_8(int[,] matrix)
        {
            // code here

            // end

            return matrix;
        }
        public int[,] Task_3_9(int[,] matrix)
        {
            // code here

            // end

            return matrix;
        }
        public int[,] Task_3_10(int[,] matrix)
        {
            // code here

            // end

            return matrix;
        }
        public int[,] Task_3_11(int[,] matrix)
        {
            // code here

            // end

            return matrix;
        }
        #endregion
    } }