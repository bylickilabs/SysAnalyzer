// -----------------------------------------------------------------------------------------------
//  SysAnalyzer.Gui - Systemanalyse-Tool
//  Copyright 30.06.2025 ©BYLICKILABS. Alle Rechte vorbehalten.
//  Entwickelt von Thorsten Bylicki, Informatiker für Anwendungsentwicklung und Systemintegration
// 
// Website.: https://bylickilabs.de
// Github.: https://github.com/bylickilabs
// ----------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Windows;
using System.Net.NetworkInformation;

namespace SysAnalyzer.Gui
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AnalyzeButton_Click(object sender, RoutedEventArgs e)
        {
            SystemInfoText.Text = GetSystemInfo();
            ProcessesListView.ItemsSource = GetTopProcesses(10);
        }

        private string GetSystemInfo()
        {
            var name = Environment.MachineName;
            var os = Environment.OSVersion.ToString();
            var cpu = GetCpuName();

            return $"Computername: {name}\nBetriebssystem: {os}\nCPU: {cpu}";
        }

        private string GetCpuName()
        {
            using var searcher = new ManagementObjectSearcher("select Name from Win32_Processor");
            var obj = searcher.Get().Cast<ManagementObject>().FirstOrDefault();
            return obj?["Name"]?.ToString() ?? "Unbekannt";
        }

        private List<ProcessInfo> GetTopProcesses(int count)
        {
            var procs = Process.GetProcesses()
                .OrderByDescending(p => p.WorkingSet64)
                .Take(count)
                .Select(p => new ProcessInfo
                {
                    Name = p.ProcessName,
                    Id = p.Id,
                    MemoryMB = Math.Round(p.WorkingSet64 / 1024.0 / 1024.0, 2)
                }).ToList();
            return procs;
        }
    }

    public class ProcessInfo
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double MemoryMB { get; set; }
    }
}
