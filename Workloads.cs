using System;
using System.Numerics;

namespace BenchmarkingCsharp
{
    class Workloads
    {

        private const int ArraySize = 1024;
        private const int ArraySizeVector = ArraySize / 4;
        private readonly int[] intSourceArray = new int[ArraySize];
        private int[] intResultArray = new int[ArraySize];
        private readonly float[] floatSourceArray = new float[ArraySize];
        private float[] floatResultArray = new float[ArraySize];
        private readonly Vector4[] vectorSourceArray = new Vector4[ArraySizeVector];
        private Vector4[] vectorResultArray = new Vector4[ArraySizeVector];

        private long loopCount;

        public Workloads()
        {
            Random rnd = new Random();

            for (int i = 0; i < ArraySize; i++)
            {
                intSourceArray[i] = rnd.Next(int.MinValue / 2 + 1, int.MaxValue / 2 - 1);
                floatSourceArray[i] = (float)rnd.NextDouble();
            }

            for (int i = 0; i < ArraySizeVector; i++)
            {
                vectorSourceArray[i].W = (float)rnd.NextDouble();
                vectorSourceArray[i].X = (float)rnd.NextDouble();
                vectorSourceArray[i].Y = (float)rnd.NextDouble();
                vectorSourceArray[i].Z = (float)rnd.NextDouble();
            }
        }

        public void StartIntegerAdd()
        {
            loopCount = 0;

            while (true)
            {
                IntegerAdd();
                loopCount++;
            }
        }

        public void StartIntegerMultiply()
        {
            loopCount = 0;

            while (true)
            {
                IntegerMultiply();
                loopCount++;
            }
        }

        public void StartIntegerDivide()
        {
            loopCount = 0;

            while (true)
            {
                IntegerDivide();
                loopCount++;
            }
        }

        public void StartBranchyIntegerAdd()
        {
            loopCount = 0;

            while (true)
            {
                BranchyIntegerAdd();
                loopCount++;
            }
        }

        public void StartFloatAdd()
        {
            loopCount = 0;

            while (true)
            {
                FloatAdd();
                loopCount++;
            }
        }

        public void StartFloatMultiply()
        {
            loopCount = 0;

            while (true)
            {
                FloatMultiply();
                loopCount++;
            }
        }

        public void StartFloatDivide()
        {
            loopCount = 0;

            while (true)
            {
                FloatDivide();
                loopCount++;
            }
        }

        public void StartVectorMultiply()
        {
            loopCount = 0;

            while (true)
            {
                VectorMultiply();
                loopCount++;
            }
        }

        public long GetExecutedOperations()
        {
            return loopCount * ArraySize;
        }


        private void IntegerAdd()
        {
            for (int i = 0; i < ArraySize; i++)
            {
                intResultArray[i] = intSourceArray[i] + 1;
            }
        }

        private void IntegerMultiply()
        {
            for (int i = 0; i < ArraySize; i++)
            {
                intResultArray[i] = intSourceArray[i] * 2;
            }
        }

        private void IntegerDivide()
        {
            for (int i = 0; i < ArraySize; i++)
            {
                intResultArray[i] = intSourceArray[i] / 2;
            }
        }

        private void BranchyIntegerAdd()
        {
            for (int i = 0; i < ArraySize; i++)
            {
                if (intResultArray[i] > 0)
                {
                    intResultArray[i] = intSourceArray[i] - 1;
                }
                else
                {
                    intResultArray[i] = intSourceArray[i] + 1;
                }
            }
        }

        private void FloatAdd()
        {
            for (int i = 0; i < ArraySize; i++)
            {
                floatResultArray[i] = floatSourceArray[i] + 1.0f;
            }
        }

        private void FloatMultiply()
        {
            for (int i = 0; i < ArraySize; i++)
            {
                floatResultArray[i] = floatSourceArray[i] * 0.5f;
            }
        }

        private void FloatDivide()
        {
            for (int i = 0; i < ArraySize; i++)
            {
                floatResultArray[i] = floatSourceArray[i] / 2f;
            }
        }

        private void VectorMultiply()
        {
            for (int i = 0; i < ArraySizeVector; i++)
            {
                vectorResultArray[i] = Vector4.Multiply(2.0f, vectorSourceArray[i]);
            }
        }

    }
}
