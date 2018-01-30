using System;
using System.Runtime.InteropServices;

namespace SimTest
{
    class Program
    {
        public const string QSIM_DLL_NAME = "Microsoft.Quantum.Simulator.Runtime.dll";

        [DllImport(QSIM_DLL_NAME, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "init")]
        private static extern void Init();

        [DllImport(QSIM_DLL_NAME, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "allocateQubit")]
        private static extern void AllocateOne(uint id);

        [DllImport(QSIM_DLL_NAME, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "release")]
        private static extern bool ReleaseOne(uint id);

        [DllImport(QSIM_DLL_NAME, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "X")]
        private static extern void X(uint id);


        static void Main(string[] args)
        {
            uint id = 0;
            Console.WriteLine("Hello!");
            Init();

            Console.WriteLine("Do something...");
            AllocateOne(id);
            X(id);
            ReleaseOne(id);

            Console.WriteLine("Test complete.");
        }
    }
}
