using System;
using System.Diagnostics;
using System.Threading;

namespace DockerDemo
{
     public class Program
    {
        public static void Main(string[] args)
        {
            Process[] processlist = Process.GetProcesses();
           

		foreach (Process theprocess in processlist)
		{
			Thread.Sleep(1000);
            Console.WriteLine($"Process: {theprocess.ProcessName}  ID: {theprocess.Id}");
		} 
        //Number of processes differs from local execution to docker run
        Console.WriteLine(processlist.Length);
        }
    }
}
