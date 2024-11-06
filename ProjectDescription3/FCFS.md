# FCFS Process Scheduler 📅💻

Welcome to the **First-Come, First-Served (FCFS) Process Scheduler** project! This scheduler simulates the FCFS scheduling algorithm, allowing you to manage and observe the execution order of processes based on their arrival times.

## Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Examples](#examples)
- [Detailed Overview](#detailed-overview)
- [Contributing](#contributing)
- [License](#license)

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

#### **What is FCFS?**
First-Come, First-Served (FCFS) is one of the simplest and most straightforward scheduling algorithms used in operating systems. It ensures that the process that arrives first is executed first.

#### *Step-by-Step Explanation
1.  Arrival and Queueing:

Processes arrive in the ready queue and are placed in the order they arrive.

2.  Execution:

The scheduler picks the first process in the queue and executes it until completion.

The process is then removed from the queue.

3.  Next Process:

The scheduler moves to the next process in the queue and repeats the execution until all processes are completed.


