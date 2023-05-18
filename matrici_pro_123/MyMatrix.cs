using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrici_pro_123
{
    internal class MyMatrix
    {
        private int[,] matrix;
        private int size;
        Random ran = new Random();

        public MyMatrix(int size)
        {
            this.size = size;
            matrix = new int[size, size];
        }
        public void GenerateMatrix()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = ran.Next(10);
                }
            }
        }
        public int GetValue(int row, int col)
        {
            return matrix[row, col];
        }

        public int[,] FillMatrixFromData(int row, int col, int value)
        {
            try
            {
                matrix[row, col] = value;
                return matrix;
            }
            catch
            {
                MessageBox.Show("Неправильный размер матрицы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return matrix;
            }
        }
        public void GetValueFromDataGribView(DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    matrix = FillMatrixFromData(i,j, Convert.ToInt32(dataGridView.Rows[i].Cells[j].Value));
                }
            }
        }

        public void FillMatrix(DataGridView dataGridView)
        {
            dataGridView.RowCount = matrix.GetLength(0);
            dataGridView.ColumnCount = matrix.GetLength(1);
            for (int i = 0;i < matrix.GetLength(0);i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = matrix[i,j];
                }
            }
        }
        public MyMatrix Sum(MyMatrix other)
        {
            MyMatrix result = new MyMatrix(size);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result.matrix[i, j] = matrix[i, j] + other.matrix[i, j]; 
                }
            }
            return result;
        }

        public MyMatrix Multiply(MyMatrix other)
        {
            MyMatrix result = new MyMatrix(size);
            int count=0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    for (int k = 0; k < size; k++)
                    {
                        count += matrix[i, k] * other.matrix[k, j];
                    }
                    result.matrix[i, j] = count;
                    count = 0;
                }
            }
            return result;
        }
        public MyMatrix Transposition()
        {
            MyMatrix result = new MyMatrix(size);
            for ( int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    result.matrix[i,j] = matrix[j,i];
                }
            }
            return result;
        }
    }
}
