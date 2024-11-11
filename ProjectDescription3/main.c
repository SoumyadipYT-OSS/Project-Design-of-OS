#include <stdio.h>


// Define the structure named 'Process'
typedef struct {
    int processID;
    int arrivalTime;
    int burstTime;
    int waitingTime;
    int turnaroundTime;
    int responseTime;
    int ioBurstTime;
} Process;





// Implement the FCFS Scheduling Algorithm
void FCFS(Process processes[], int n) {
    int totalWaitingTime = 0;
    int totalTurnaroundTime = 0;
    int totalResponseTime = 0;
    int currentTime = 0;

    /* calculate waiting time, turnaround time and response time for each process*/
    for (int i=0; i<n; i++) {
        if (currentTime < processes[i].arrivalTime) {
            currentTime = processes[i].arrivalTime;
        }
        processes[i].waitingTime = currentTime - processes[i].arrivalTime;
        processes[i].responseTime = processes[i].waitingTime;
        currentTime += processes[i].burstTime + processes[i].ioBurstTime;
        processes[i].turnaroundTime = currentTime - processes[i].arrivalTime;

        totalWaitingTime += processes[i].waitingTime;
        totalTurnaroundTime += processes[i].turnaroundTime;
        totalResponseTime += processes[i].responseTime;
    }


    // Calculate average times
    float averageWaitingTime = (float) totalWaitingTime / n;
    float averageTurnaroundTime = (float) totalTurnaroundTime / n;
    float averageResponseTime = (float) totalResponseTime / n;


    // Display results
    printf("\nProcess ID\tArrival Time\tBurst Time\tI/O Burst Time\tWaiting Time\tTurnaround Time\tResponse Time\n");
    for (int i=0; i<n; i++) {
        printf("P%d\t\t%d\t\t%d\t\t%d\t\t%d\t\t%d\t\t%d\n", processes[i].processID, processes[i].arrivalTime, processes[i].burstTime, processes[i].ioBurstTime, processes[i].waitingTime, processes[i].turnaroundTime, processes[i].responseTime);
    }
    
    printf("\nAverage Waiting Time: %.2f\n", averageWaitingTime);
    printf("Average Turnaround Time: %.2f\n", averageTurnaroundTime);
    printf("Average Response Time: %.2f\n", averageResponseTime);




    // Display Gantt Chart
    printf("\nGantt Chart: \n");
    currentTime = 0;
    for (int i=0; i<n; i++) {
        if (currentTime < processes[i].arrivalTime) {
            currentTime = processes[i].arrivalTime;
        }
        printf("| P%d ", processes[i].processID); 
        currentTime += processes[i].burstTime + processes[i].ioBurstTime;
    }
    printf("|\n");
}


// main method
int main() {
    int n;

    printf("Enter the number of processes: ");
    scanf("%d", &n);

    Process processes[n];

    for (int i = 0; i < n; i++) {
        processes[i].processID = i + 1;
        printf("Enter arrival time, burst time, and I/O burst time for process P%d: ", i + 1);
        scanf("%d%d%d", &processes[i].arrivalTime, &processes[i].burstTime, &processes[i].ioBurstTime);
    }

    FCFS(processes, n);

    return 0;
}
