using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computation
{
    public class MatrixDouble
    {
        private int _m;
        private int _n;
        private double[][] _data;

        //Constructor by default
        public MatrixDouble(int m, int n)
        {
            _m = m;
            _n = n;
            _data = new double[m][];
            for(int i = 0; i < m; i++)
            {
                _data[i] = new double[n];
            }
        }

        //Constructor with data
        public MatrixDouble(double[][] data)
        {
            _m = data.Length;
            _n = data[0].Length;
            for(int i = 0; i < _m; i++)
            {
                for(int j = 0; j < _n; j++)
                {
                    _data[i][j] = data[i][j];
                }
            }
        }

        //Constructor by copy
        public MatrixDouble(MatrixDouble mat)
        {
            this._m = mat._m;
            this._n = mat._n;
            this._data = mat._data;
        }

        //Identity matrix
        public MatrixDouble identity(int n)
        {
            MatrixDouble res = new MatrixDouble(n, n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    res._data[i][j] = 1;
                }
            }
            return res;
        }

        //To create a random matrix
        public MatrixDouble randomMatrix(int m, int n, int min, int max)
        {
            if(min >= max)
            {
                throw new Exception("Incompatible values");
            }
            Random rnd = new Random();
            MatrixDouble res = new MatrixDouble(m, n);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    res._data[i][j] = min + (max - min)*rnd.NextDouble();
                }
            }
            return res;
        }

        //Transpose matrix
        public MatrixDouble transpose()
        {
            MatrixDouble res = new MatrixDouble(this._m, this._n);
            for (int i = 0; i < this._m; i++)
            {
                for (int j = 0; j < this._n; j++)
                {
                    res._data[i][j] = this._data[j][i];
                }
            }
            return res;
        }

        //Addition
        public MatrixDouble addition(MatrixDouble mat)
        {
            if (this._m != mat._m || this._n != mat._n) throw new Exception("Illegal matrix dimensions");
            MatrixDouble res = new MatrixDouble(this._m, this._n);
            for (int i = 0; i < this._m; i++)
            {
                for (int j = 0; j < this._n; j++)
                {
                    res._data[i][j] = this._data[i][j] + mat._data[i][j];
                }
            }
            return res;
        }

        //Substration
        public MatrixDouble substration(MatrixDouble mat)
        {
            if (this._m != mat._m || this._n != mat._n) throw new Exception("Illegal matrix dimensions");
            MatrixDouble res = new MatrixDouble(this._m, this._n);
            for (int i = 0; i < this._m; i++)
            {
                for (int j = 0; j < this._n; j++)
                {
                    res._data[i][j] = this._data[i][j] - mat._data[i][j];
                }
            }
            return res;
        }

        //Multiplication
        public MatrixDouble multiplication(MatrixDouble mat)
        {
            if (this._n != mat._m) throw new Exception("Invalide matrix dimensions");
            MatrixDouble res = new MatrixDouble(this._m, mat._n);
            for (int i = 0; i < this._m; i++)
            {
                for (int j = 0; j < mat._n; j++)
                {
                    res._data[i][j] = 0;
                    for (int k = 0; k < this._n; k++)
                    {
                        res._data[i][j] += this._data[i][k] * mat._data[k][j];
                    }
                    
                }
            }
            return res;
        }

        //To check if matrix is square
        public bool isSquare()
        {
            return _m == _n;
        }

        //To display matrix
        public void displayMatrix()
        {
            Console.Write("[");
            for (int i = 0; i < this._m; ++i)
            {
                if (i != 0)
                {
                    Console.Write(" ");
                }

                Console.Write("[");

                for (int j = 0; j < this._n; ++j)
                {
                    Console.Write("%8.3f", this._data[i][j]);

                    if (j != this._n - 1)
                    {
                        Console.Write(" ");
                    }
                }

                Console.Write("]");

                if (i == this._m - 1)
                {
                    Console.Write("]");
                }

                Console.ReadLine();
            }
        }
    }
}
