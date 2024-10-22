using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_3(new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } });
        //program.Task_1_6(new int[,] { { 1, 2, 3, 4, 5, 6, 7 }, { 5, 6, 7, 8, -9, 10, 11 }, { 9, 10, -11, -12, -13, -14, -15 }, { -13, -14, 15, 16, 17, 18, -19 } });
        //program.Task_1_9(new int[,] { { 1, 2, 3, 4, -5, -6, -7 }, { 5, 11, -17, 11, -10, 6, 5 }, { -9, -10, -11, -14, -15, -16, 1 }, { -9, -10, -11, -14, -15, -6, -2 }, { -9, -10, -11, -14, -15, 6, 4 } });
        //program.Task_1_12(new int[,] { { 1, 2, 3, 4, -5, -6, -7 }, { 5, 11, -17, 11, -10, 6, 5 }, { -9, -10, -11, -14, -15, -16, 1 }, { -9, -10, -11, -14, 15, -6, -2 }, { -9, -10, -11, -14, -15, 6, 4 }, { 0, -2, -3, -4, -5, 0, 5 } });
        //program.Task_1_15(new int[,] { { 1, 2, -3, 4, -5, 6, 7 }, { 5, 6, -7, 8, 9, -10, -11 }, { 9, 10, 11, -12, 13, 14, 15 }, { -13, 14, 15, 16, 17, -18, -19 }, { 0, -1, -2, -3, -4, -5, -6 } });
        //program.Task_1_18(new int[,] { { 1, 2, -3, 4, -5, 6, 7 }, { 5, 6, -7, 8, 9, -10, -11 }, { 9, 10, 11, 12, 13, 14, 15 }, { -13, 14, 15, 16, 17, -18, -19 }, { 0, -1, -2, -3, -4, -5, -6 } }, 5, 7);
        //program.Task_1_21(new int[,] { { 1, 2, -3, 4, -5, 7, 0 }, { 5, 6, -7, 8, 9, -11, 0 }, { 9, 10, 11, 12, 13, 15, 0 }, { -13, 14, 15, 16, 17, -19,0 }, { 0, -1, -2, -3, -4, -6, 0 } });
        //program.Task_1_24(new double[,] { { 1, 2, -3, 4, -5 }, { 5, 6, -7, 8, 9, }, { 9, 10, 11, 12, 13}, { -13, 14, 25, 16, 11 }, { 0, -1, -2, -3, -4 }, { 1, -1, 2, -2, 3 } });
        //program.Task_1_27(new int[,] { { 1, 2, -3, 7, -5, 7, 7 }, { 5, 6, -7, 8, 9, 9, -11 }, { 9, 10, 11, 12, 13, 15, 15 }, { -13, 14, 25, 25, 16, 17, -19 }, { 0, 0, -1, -2, -3, -4, -6 } });
        //program.Task_1_30(new int[,] { { 1, 2, -3, 7, -5}, { 5, 6, -7, 8, 9 }, { 9, 10, 11, 12, 13 }, { -13, 14, 25, 25, 16 }, { 0, 0, -1, -2, -3 } });
        //program.Task_1_33(new int[,] { { 1, 2, -3, 7, -5, 7, 7 }, { 5, 6, -7, 8, 9, 9, -11 }, { 9, 10, 11, 12, 13, 15, 15 }, { -13, 14, 25, 25, 16, 17, -19 }, { -6, -5, -1, -2, -3, -4, -6 } });
        //program.Task_2_1(new double[,] { { 1, 2, -3, 7, -5, 7, 7 }, { 5, 6, -7, 8, 9, 9, -11 }, { 9, 10, 11, 12, 13, 15, 15 }, { -13, -30, 25, 25, 16, 17, -19 }, { -6, -5, -1, -2, -3, -4, -6 } });
        program.Task_2_2(new int[,] { { 1, 2, -3, 7, 7 }, { 5, 6, -7, 9, -11 }, { 9, 10, 11, 15, 15 }, { -13, 14, 25, 25, -19 }, { 5, 6, -7, 8, 9}, { -13, 14, 25, 25, -19 }, { 0, 0, -1, -2, -3 } });
    }
    //3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33
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
        int m = A.GetLength(0), n = A.GetLength(1);

        if (m == n)
            for (int i = 0; i < 4; i++)
                answer += A[i, i];
        else
            return 0;

        Console.WriteLine(answer);
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
        int[] answer = default(int[]);
        // code here
        int m = A.GetLength(0), n = A.GetLength(1), min = 999999, index = 0;
        answer = new int[m];
        if (m != 4 || n != 7)
            return default(int[]);
        else
            for (int i = 0, k = 0; i < m; i++){
                for (int j = 0; j < n; j++)
                    if (A[i, j] < min) { min = A[i, j]; index = j; }
                answer[k] = index;
                k++;
            }

        foreach (int i in answer)
            Console.Write(i + " ");
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
        // code here
        void swap(int[,] arr, int i, int j, int h){ int a = arr[h, j]; arr[h, j] = arr[h, i]; arr[h, i] = a; }
        int m = A.GetLength(0), n = A.GetLength(1), max = -9999999, index = -1;
        if (m != 5 || n != 7) return null;
        for (int i = 0; i < m; i++){
            for(int j = 0; j < n; j++)
                if (A[i, j] > max) { max = A[i, j]; index = j; }
            swap(A, 0, index, i);
            max = -999999;
            index = -1;
        }
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
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
        // code here
        int m = A.GetLength(0), n = A.GetLength(1), max = -9999999, indexI = -1, indexJ = -1;
        if (m != 6 || n != 7) return null;
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                if (A[i, j] > max) { max = A[i, j]; indexI = i; indexJ = j; }

        int[,] B = new int[m-1, n-1];
        for (int i = 0, a = 0; i < m; i++){
            for (int j = 0, b = 0; j < n; j++)
                if (j != indexJ) { B[a, b] = A[i, j]; b++; }
            if (i != indexI) a++;
        }

        A = new int[m-1, n-1];
        A = B;

        for (int i = 0; i < m-1; i++){
           for (int j = 0; j < n-1; j++)
                Console.Write(B[i, j] + " ");
            Console.WriteLine(); 
        }
        // end

        return A;
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
        // code here
        int m = A.GetLength(0), n = A.GetLength(1), max = -9999999, index = -1;
        if (m != 5 || n != 7) return null;
        for (int i = 0; i < m; i++){
            for (int j = 0; j < n; j++)
                if (A[i, j] > max) { max = A[i, j]; index = j; }
            A[i, index] *= (i+1);
            index = -1;
            max = -999999;
        }
        // end
        for (int i = 0; i < m; i++){
            for (int j = 0; j < n; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }
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
        // code here
        void swap(int[,] arr, int i, int j, int h) { int a = arr[h, j]; arr[h, j] = arr[h, i]; arr[h, i] = a; }

        int max = -9999999, maxNeg = -999999, indexMax = -1, indexNeg = -1;
        bool key = false;
        for (int i = 0; i < n; i++){
            for (int j = 0; j < m; j++){
                if (D[i, j] < 0) key = true;
                if (!key && D[i, j] > max) { max = D[i, j]; indexMax = j; }
                else if (key && D[i, j] > maxNeg && D[i, j] < 0) { maxNeg = D[i, j]; indexNeg = j; }
            }

            if (indexMax > -1 && indexNeg > -1)
                swap(D, indexMax, indexNeg, i);
            indexMax = indexNeg = -1;
            max = maxNeg = -999999;
            key = false;
        }

        for (int i = 0; i < n; i++){
            for (int j = 0; j < m; j++)
                Console.Write(D[i, j] + " ");
            Console.WriteLine();
        }
        // end

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
        // code here
        int m = H.GetLength(0), n = H.GetLength(1), maxAbs = -9999999, indexAbs = -1, max = -999999, indexMax = -1;
        if (m != 5 || n != 7) return null;
        for (int i = 0; i < m; i++){
            for (int j = 0; j < n; j++)
            {
                if (Math.Abs(H[i, j]) > max) { maxAbs = H[i, j]; indexAbs = j; }
                if (H[i, j] > max) { max = H[i, j]; indexMax = j; }
            }
            if(maxAbs >= 0){
                H[i, n - 1] = maxAbs;
            }
            if(maxAbs < 0){
                H[i, n - 1] = maxAbs;
                H[i, n - 2] = max;
            }
            max = maxAbs = -999999;
            indexMax = indexAbs = -1;
        }
        for (int i = 0; i < m; i++){
            for (int j = 0; j < n; j++)
                Console.Write(H[i, j] + " ");
            Console.WriteLine();
        }
        // end

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
        // code here
        int m = Y.GetLength(0), n = Y.GetLength(1), index = -1; 
        double max = -999999, sum = 0, count = 0;
        if (m != 6 || n != 5) return null;
        for (int i = 0; i < m; i++){
            for (int j = 0; j < n; j++)
                if (Y[i, j] > max) { max = Y[i, j]; index = j; }
            if (index != n - 1)
                for (int j = index + 1; j < n; j++)
                    if (Y[i, j] > 0) { sum += Y[i, j]; count++; }
            else
                sum = count = 0;
            if(count == 0) sum = 0;
            else sum /= count;
            for (int j = 0; j < index; j++)
                if (Y[i, j] < 0)Y[i, j] = sum;
            sum = count = 0;
            max = -9999;
            index = -1;
        }
        for (int i = 0; i < m; i++){
            for (int j = 0; j < n; j++)
                Console.Write(Y[i, j] + " ");
            Console.WriteLine();
        }
        // end

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
        // code here
        int m = B.GetLength(0), n = B.GetLength(1), max = -9999999;
        int[] numbers = new int[m];
        if (m != 5 || n != 7) return null;
        for (int i = 0; i < m; i++){
            for (int j = 0; j < n; j++)
                if (B[i, j] > max) { max = B[i, j]; }
            numbers[i] = max;
            max = -9999;
        }
        for(int i = 0, j = m-1; i < m; i++, j--)
            B[i, 3] = numbers[j];

        for (int i = 0; i < m; i++){
            for (int j = 0; j < n; j++)
                Console.Write(B[i, j] + " ");
            Console.WriteLine();
        }
        // end

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
        // code here
        int m = B.GetLength(0), n = B.GetLength(1);
        if (m != 5 || n != 5) return null;
        for (int i = 0; i < m; i++){
            int a = B[0, i];
            B[0, i] = B[3, i];
            B[3, i] = a; 
        }
        /*Console.WriteLine(" i 0 1 2 3 4");
        Console.WriteLine("j  _________");
        for (int i = 0; i < m; i++){
            Console.Write(i + "| ");
            for(int j = 0; j < m; j++)
                Console.Write($"{B[i, j]} ");
            Console.WriteLine();
        }
        Console.WriteLine(B[3, 0]);*/
        for (int i = 0; i < m; i++){
            for (int j = 0; j < m; j++)
                Console.Write(B[i, j] + " ");
            Console.WriteLine();
        }
        // end

        return B;
    }
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
        int m = A.GetLength(0), n = A.GetLength(1), count = 0, counter = 0;
        if (m != 5 || n != 7) return null;
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                if (A[i, j] < 0) count++;
        answer = new int[count];
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                if (A[i, j] < 0) { answer[counter] = A[i, j]; counter++; }

        foreach (int i in answer)
            Console.Write(i + " ");
        // end

        return answer;
    }
    #endregion
    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here
        int m = A.GetLength(0), n = A.GetLength(1), indexMax = -1, indexPrev = -1, indexPost = -1; 
        double max = -99999;
        if (m != 5 || n != 7)return null;
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++)
                if (A[i, j] > max ) { max = A[i, j]; indexMax = j; }
            if(indexMax == n){
                if (A[i, indexPrev] > 0) A[i, indexPrev] *= 2;
                else A[i, indexPrev] /= 2;
            }else if(indexMax == 0) {
                if (A[i, indexPost] > 0) A[i, indexPost] *= 2;
                else A[i, indexPost] /= 2;
            }else if(A[i, indexMax-1] > A[i, indexMax+1]){
                if (A[i, indexMax + 1] > 0) A[i, indexMax + 1] *= 2;
                else A[i, indexMax + 1] /= 2;
            }else{
                if (A[i, indexMax - 1] > 0) A[i, indexMax - 1] *= 2;
                else A[i, indexMax - 1] /= 2;
            }
            //Console.WriteLine($"prev: {indexPrev} | max: {indexMax} | post: {indexPost}");
            max = -99999;
            indexMax  = -1;
        }

        for (int i = 0; i < m; i++){
            for (int j = 0; j < n; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }
        // end

        return A;
    }
    
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int m = A.GetLength(0), n = A.GetLength(1), index = -1, cPos = 0, cNeg = 0;
        double max = -99999;
        if (m != 7 || n != 5) return null;
        for (int i = 0; i < n; i++){
            for (int j = 0; j < m; j++) { 
                if (A[j, i] > max) { max = A[j, i]; index = j; }
                if (A[j, i] < 0) cNeg++;
                if (A[j, i] > 0) cPos++;
            }
            if (cPos > cNeg) A[index, i] = 0;
            if (cPos < cNeg) A[index, i] = index;
            //Console.WriteLine($"index: {index} max: {max}");
            max = -99999;
            index = -1;
        }
        // end
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
                Console.Write(A[j, i] + " ");
            Console.WriteLine();
        }
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
}