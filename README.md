# SortProject

## Overview

The **SortProject** is a C# console application designed to measure and compare the performance of different sorting algorithms on arrays of various sizes. The project implements multiple sorting algorithms, including Shell Sort (with different gap sequences), Bubble Sort, Quick Sort, and Insertion Sort. It aims to provide insights into the efficiency of these algorithms by timing their execution on arrays containing 10,000, 20,000, 30,000, 40,000, and 50,000 elements.

## Features

- **Sorting Algorithms**: Includes Shell Sort (with multiple gap sequences), Bubble Sort, Quick Sort, and Insertion Sort.
- **Performance Measurement**: Uses `System.Diagnostics.Stopwatch` to measure and compare the time taken by each sorting algorithm.
- **Custom Gap Sequences**: Evaluates Shell Sort with custom gap sequences such as Stasiewicz gaps, Segewick gaps, prime number gaps, and modified Segewick gaps.
- **Array Initialization**: Automatically generates and initializes arrays of various sizes for testing.
- **Results Display**: Outputs the time taken by each sorting algorithm for different array sizes in a tabular format.
- **Saving Data To CSV FILE**: Allows you to make charts

## Getting Started

### Prerequisites

- .NET SDK
- Visual Studio or any C# compatible IDE

### Outputs

- Example Output
![image](https://github.com/AdrianKrauze/SortingComparision/assets/118012788/27dd83c1-6c8e-495c-b3ad-60b3cf26b1e9)

- And Example chart make with python(chart does not include bubble sort and insertion sort data, because they would go off the chart.)
![Figure_1](https://github.com/AdrianKrauze/SortingComparision/assets/118012788/cdfc8df5-37e8-4fb5-bf65-9bb3d2ae6f39)

