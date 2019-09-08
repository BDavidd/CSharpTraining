using System;

namespace Delegates
{
    public delegate void WorkPerformedHandler(int hours, WorkType workType);

    public enum WorkType
    {
        Analyze,
        Design,
        Build
    }

    class Worker
    {
        public Worker()
        {
            WorkPerformedHandler del1 = WorkPerformed1;
            del1 += WorkPerformed2;
            WorkPerformedHandler del2 = WorkPerformed2;

            DoWork(del1);
            del2(3, WorkType.Design);
        }

        private void DoWork(WorkPerformedHandler del)
        {
            del(10, WorkType.Analyze);
        }

        private void WorkPerformed1(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformed1 called: {hours}, {workType}");
        }

        private void WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformed2 called: {hours}, {workType}");
        }
    }

    class Program
    {
        static void Main()
        {
            // ReSharper disable once AssignmentIsFullyDiscarded
            _ = new Worker();
        }
    }
}
