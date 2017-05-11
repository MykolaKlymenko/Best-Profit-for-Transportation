using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Map.Helpers
{
    public static class RouteMatrixConverter
    {
        public static T[,] ConvertToMatrix<T>(List<List<T>> routes)
        {
            var colsCount = routes.FirstOrDefault().Count();
            var rowsCount = routes.Count();
            var matrix = new T[rowsCount, colsCount];
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    matrix[i, j] = routes[i][j];
                }
            }

            return matrix;
        }
    }
}