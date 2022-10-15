using System;
using System.Collections.Generic;
using System.Linq;

//public static class SaddlePoints
//{
//    public static IEnumerable<(int, int)> Calculate(int[,] matrix)
//    {
//        var matrixPrueba = new[,]
//        {
//             { 9, 8, 7 },
//             { 5, 3, 2 },
//             { 6, 6, 7 }
//        };

//        int columnIndex = 0;
//        int columnRow = 0;

//        List<(int, int)> saddlePoints = new List<(int, int)>();

//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            int maxValueRow = matrix[i,0];
//            int minValueColumn = matrix[i,0];

//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                int actualValue = matrix[i, j];

//                if (actualValue >= maxValueRow)
//                {
//                    maxValueRow = actualValue;
//                    columnIndex = j;
//                }
//            }

//            for(int k = 0; k < matrix.GetLength(0); k++)
//            {
//                int actualValueColumn = matrix[k, columnIndex];
//                minValueColumn = actualValueColumn <= minValueColumn ? actualValueColumn : minValueColumn;
//                columnRow = actualValueColumn <= minValueColumn ? k : columnRow;
//            }

//            if (minValueColumn == maxValueRow)
//            {
//                saddlePoints.Add((i + 1, columnIndex + 1));
//            }

//        }

//        return saddlePoints;
//    }
//}

public static class SaddlePoints
{
    public static IEnumerable<(int, int)> Calculate(int[,] matrix)
    {
        var matrixPrueba = new[,]
        {
             { 9, 8, 7 },
             { 5, 3, 2 },
             { 6, 6, 7 }
        };

        IList<(int, int)> result = new List<(int, int)>();
        int minValueColumn = 0;
        int maxValueRow = 0;

        List<(int, int)> resultList = new List<(int, int)>();
        List<int> resultListColumn = new List<int>();
        List<int> resultListRow = new List<int>();

        //int ultimoValor = matrixPrueba[matrixPrueba.Length - 1, matrixPrueba.Length - 1];
        int j = 0;
        while (j < matrixPrueba.GetLength(0))
        {
            resultListColumn.Clear();
            resultListRow.Clear();

            for (int column = 0; column < matrixPrueba.GetLength(0); column++)
            {
                var tuple = Tuple.Create(matrixPrueba[column, j]);
                resultListColumn.Add(tuple.Item1);

                minValueColumn = resultListColumn.Min();
                
                if (resultListRow.Count() != (matrixPrueba.Length / matrixPrueba.GetLength(0)))
                {
                    for (int row = 0; row < matrixPrueba.GetLength(0); row++)
                    {
                        var tupleRow = Tuple.Create(matrixPrueba[j, row]);
                        resultListRow.Add(tupleRow.Item1);
                    }
                }

                maxValueRow = resultListRow.Max();
            }



            if (minValueColumn == maxValueRow)
                result.Add((maxValueRow, minValueColumn));

            j++;
        }


        //for (int i = 0; i < matrixPrueba.GetLength(0); i++)
        //{
        //    minValueRow = matrixPrueba[i, 0];
        //    maxValueRow = matrixPrueba[i, 0];

        //    int actualValueColumn = matrixPrueba[i, 0];

        //    for (int j = 0; j < matrixPrueba.GetLength(1); j++)
        //    {
        //        int actualValueRow = matrixPrueba[i, j];
        //        maxValueRow = (actualValueRow >= maxValueRow) ? actualValueRow : maxValueRow;
        //    }

        //    minValueRow = (actualValueColumn <= minValueRow) ? actualValueColumn : minValueRow;
        //}


        return result;
    }


}
