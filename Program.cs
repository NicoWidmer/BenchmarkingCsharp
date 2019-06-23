using System;
using System.Threading;

namespace BenchmarkingCsharp
{
    class Program
    {

        static void Main(string[] args)
        {
            int durationMilliseconds = 2000;

            Workloads workloads = new Workloads();
            Thread thread;


            thread = new Thread(new ThreadStart(workloads.StartIntegerAdd));
            Console.WriteLine("Benchmarking int add operations...");
            Thread.Sleep(200);
            thread.Start();
            Thread.Sleep(durationMilliseconds);
            thread.Abort();
            Console.WriteLine("Int add operations per ms: " + workloads.GetExecutedOperations() / durationMilliseconds);

            
            thread = new Thread(new ThreadStart(workloads.StartIntegerMultiply));
            Console.WriteLine();
            Console.WriteLine("Benchmarking int multiply operations...");
            Thread.Sleep(200);
            thread.Start();
            Thread.Sleep(durationMilliseconds);
            thread.Abort();
            Console.WriteLine("Int multiply operations per ms: " + workloads.GetExecutedOperations() / durationMilliseconds);


            thread = new Thread(new ThreadStart(workloads.StartIntegerDivide));
            Console.WriteLine();
            Console.WriteLine("Benchmarking int divide operations...");
            Thread.Sleep(200);
            thread.Start();
            Thread.Sleep(durationMilliseconds);
            thread.Abort();
            Console.WriteLine("Int divide operations per ms: " + workloads.GetExecutedOperations() / durationMilliseconds);


            thread = new Thread(new ThreadStart(workloads.StartBranchyIntegerAdd));
            Console.WriteLine();
            Console.WriteLine("Benchmarking int branchy add operations...");
            Thread.Sleep(200);
            thread.Start();
            Thread.Sleep(durationMilliseconds);
            thread.Abort();
            Console.WriteLine("Int branchy operations per ms: " + workloads.GetExecutedOperations() / durationMilliseconds);


            thread = new Thread(new ThreadStart(workloads.StartFloatAdd));
            Console.WriteLine();
            Console.WriteLine("Benchmarking float add operations...");
            Thread.Sleep(200);
            thread.Start();
            Thread.Sleep(durationMilliseconds);
            thread.Abort();
            Console.WriteLine("Float add operations per ms: " + workloads.GetExecutedOperations() / durationMilliseconds);


            thread = new Thread(new ThreadStart(workloads.StartFloatMultiply));
            Console.WriteLine();
            Console.WriteLine("Benchmarking float multiply operations...");
            Thread.Sleep(200);
            thread.Start();
            Thread.Sleep(durationMilliseconds);
            thread.Abort();
            Console.WriteLine("Float multiply operations per ms: " + workloads.GetExecutedOperations() / durationMilliseconds);


            thread = new Thread(new ThreadStart(workloads.StartFloatDivide));
            Console.WriteLine();
            Console.WriteLine("Benchmarking float divide operations...");
            Thread.Sleep(200);
            thread.Start();
            Thread.Sleep(durationMilliseconds);
            thread.Abort();
            Console.WriteLine("Float divide operations per ms: " + workloads.GetExecutedOperations() / durationMilliseconds);


            thread = new Thread(new ThreadStart(workloads.StartVectorMultiply));
            Console.WriteLine();
            Console.WriteLine("Benchmarking vector multiply operations...");
            Thread.Sleep(200);
            thread.Start();
            Thread.Sleep(durationMilliseconds);
            thread.Abort();
            Console.WriteLine("Multiply per ms using vectors: " + workloads.GetExecutedOperations() / durationMilliseconds);


            Console.ReadKey();
        }
    }
}
