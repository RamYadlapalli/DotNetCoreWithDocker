﻿using System;
using System.Diagnostics;

namespace DockerDemo
{
     public class Program
    {
        public static void Main(string[] args)
        {
            Process[] processlist = Process.GetProcesses();

		foreach (Process theprocess in processlist)
		{
			Console.WriteLine($"Process: {theprocess.ProcessName}  ID: {theprocess.Id}");
		}
        }
    }
}
