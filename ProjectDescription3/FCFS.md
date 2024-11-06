# FCFS Process Scheduler 📅💻

Welcome to the **First-Come, First-Served (FCFS) Process Scheduler** project! This scheduler simulates the FCFS scheduling algorithm, allowing you to manage and observe the execution order of processes based on their arrival times.

## Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [Getting Started](#getting-started)
- [Prerequisites](#prerequisites)
- [Detailed Overview](#detailed-overview)

## Introduction
The **FCFS Process Scheduler** is a fundamental simulation of process management within an operating system. In FCFS, processes are executed in the order they arrive, ensuring simplicity and fairness but potentially leading to high waiting times for longer processes.

## Features
- **Process Management**: Add, view, and manage processes with their arrival times and burst times.
- **Scheduling Algorithm**: Implements the FCFS scheduling algorithm.
- **Performance Metrics**: Calculates and displays average waiting time and turnaround time.
- **Interactive CLI**: User-friendly command-line interface for interaction.

## Getting Started
Follow these instructions to set up and run the FCFS Process Scheduler on your local machine.

### Prerequisites
- **C Compiler**: `gcc` for C implementation.
- **.NET SDK**: For C# implementation.

### Installation

#### C Implementation
1. **Clone the Repository**:
   ```bash
   git clone https://github.com/yourusername/FCFS-Process-Scheduler.git
   cd FCFS-Process-Scheduler/C

2. **Compile the Program**:
    ```
    gcc -o FCFS main.c
    ```

3. **Run the Prgram**:
    ```
    ./FCFS
    ```



#### C# Implementation
1. **Clone the Repository**:
```
git clone https://github.com/yourusername/FCFS-Process-Scheduler.git
cd FCFS-Process-Scheduler/CSharp
```
2. **dotnet run**
```
dotnet run
```


#### Detailed Overview

#### **What is FCFS? 🤔**
First-Come, First-Served (FCFS) is one of the simplest and most straightforward scheduling algorithms used in operating systems. It ensures that the process that arrives first is executed first.

#### *Step-by-Step Explanation📝*
1.  Arrival and Queueing:

Processes arrive in the ready queue and are placed in the order they arrive. 🚶‍♂️🚶‍♀️


2.  Execution:

The scheduler picks the first process in the queue and executes it until completion. ✅

The process is then removed from the queue. 🗑️


3.  Next Process:

The scheduler moves to the next process in the queue and repeats the execution until all processes are completed. 🔄




#### **Characteristics of FCFS: ⚙️**
1. Queue Mechanism: Processes are scheduled in the order they arrive. The first process to enter the ready queue is the first one to be executed.

2. Non-preemptive: Once a process starts its execution, it runs to completion before the next process starts. This means that processes are not interrupted.



##### Advantages of FCFS:
1. Simplicity: Easy to understand and implement. It doesn’t require complex data structures or algorithms.

2. Fairness: Every process gets a fair chance as it gets executed in the order it arrives, thus no process can suffer from starvation.



##### Disadvantages of FCFS:
1. Poor Average Waiting Time: Long processes can significantly increase the waiting time of subsequent processes, leading to the “convoy effect,” where shorter processes get stuck waiting for long processes to complete.

2. Non-preemptive Nature: It doesn’t consider process priorities or burst times, potentially leading to inefficient use of the CPU.

3. Turnaround Time: The total turnaround time can be quite high for processes arriving late in the sequence.



##### Practical Implementations of FCFS 🛠️
Despite its simplicity, FCFS is rarely used in modern operating systems for process scheduling due to its inefficiencies, especially in scenarios with varied process burst times. However, it is still used in some specific scenarios:

Batch Processing: Environments where tasks are processed in large batches with similar execution times.

Sequential Tasks: Systems where tasks must be executed in the exact order they arrive.