using System;

public class Process {
    public int ProcessID { get; set; }
    public int ArrivalTime { get; set; }
    public int BurstTime { get; set; }
    public int WaitingTime { get; set; }
    public int TurnaroundTime { get; set; }
    public int ResponseTime { get; set; }
    public int IOBurstTime { get; set; }
}

public class FCFS_Scheduler {
    public static void FCFS(Process[] processes) {
        int totalWaitingTime = 0;
        int totalTurnaroundTime = 0;
        int totalResponseTime = 0;
        int currentTime = 0;

        // Calculate waiting time, turnaround time and response time for each process
        for (int i = 0; i < processes.Length; i++) {
            if (currentTime < processes[i].ArrivalTime) {
                currentTime = processes[i].ArrivalTime;
            }
            processes[i].WaitingTime = currentTime - processes[i].ArrivalTime;
            processes[i].ResponseTime = processes[i].WaitingTime;
            currentTime += processes[i].BurstTime + processes[i].IOBurstTime;
            processes[i].TurnaroundTime = currentTime - processes[i].ArrivalTime;

            totalWaitingTime += processes[i].WaitingTime;
            totalTurnaroundTime += processes[i].TurnaroundTime;
            totalResponseTime += processes[i].ResponseTime;
        }

        // Calculate average times
        float averageWaitingTime = (float)totalWaitingTime / processes.Length;
        float averageTurnaroundTime = (float)totalTurnaroundTime / processes.Length;
        float averageResponseTime = (float)totalResponseTime / processes.Length;

        // Display results
        Console.WriteLine("\nProcess ID\tArrival Time\tBurst Time\tI/O Burst Time\tWaiting Time\tTurnaround Time\tResponse Time");
        for (int i = 0; i < processes.Length; i++) {
            Console.WriteLine($"P{processes[i].ProcessID}\t\t{processes[i].ArrivalTime}\t\t{processes[i].BurstTime}\t\t{processes[i].IOBurstTime}\t\t{processes[i].WaitingTime}\t\t{processes[i].TurnaroundTime}\t\t{processes[i].ResponseTime}");
        }

        Console.WriteLine($"\nAverage Waiting Time: {averageWaitingTime:F2}");
        Console.WriteLine($"Average Turnaround Time: {averageTurnaroundTime:F2}");
        Console.WriteLine($"Average Response Time: {averageResponseTime:F2}");

        // Display Gantt Chart
        Console.WriteLine("\nGantt Chart:");
        currentTime = 0;
        Console.Write("0");
        for (int i = 0; i < processes.Length; i++) {
            if (currentTime < processes[i].ArrivalTime) {
                currentTime = processes[i].ArrivalTime;
            }
            Console.Write($" | P{processes[i].ProcessID} ");
            currentTime += processes[i].BurstTime + processes[i].IOBurstTime;
            Console.Write($" {currentTime}");
        }
        Console.WriteLine(" |");
    }

    public static void Main(string[] args) {
        Console.Write("Enter the number of processes: ");
       #pragma warning disable CS8604
        int n = int.Parse(Console.ReadLine());
       #pragma warning restore CS8604

        Process[] processes = new Process[n];

        for (int i = 0; i < n; i++) {
            processes[i] = new Process { ProcessID = i + 1 };
            Console.Write($"Enter arrival time, burst time, and I/O burst time for process P{processes[i].ProcessID}: ");
           #pragma warning disable CS8602
            string[] input = Console.ReadLine().Split();
           #pragma warning restore CS8602
            processes[i].ArrivalTime = int.Parse(input[0]);
            processes[i].BurstTime = int.Parse(input[1]);
            processes[i].IOBurstTime = int.Parse(input[2]);
        }

        FCFS(processes);
    }
}

