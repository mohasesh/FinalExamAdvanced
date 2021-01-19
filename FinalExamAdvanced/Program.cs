using System;

namespace FinalExamAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            lightcheker light = new lightcheker();
            light.ProcessCompleted += Lightcheck; 
            light.StartProcess();
        }
        public static void Lightcheck(object sender, EventArgs e)
        {
            Console.WriteLine("The Light is Turned on");
        }
    }
    public class lightcheker
    {
        public event EventHandler ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");

            OnProcessCompleted(EventArgs.Empty);
        }


        protected virtual void OnProcessCompleted(EventArgs e)
        {
            ProcessCompleted?.Invoke(this, e);
        }
    }
}
