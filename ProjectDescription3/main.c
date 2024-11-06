#include <stdio.h>

typedef struct {
    int processID;
    int arrivalTime;
    int burstTime;
    int turnaroundTime;
    int responseTime;
    int ioBurstTime;
} Process;