import pandas as pd
import matplotlib.pyplot as plt


file_path = 'file.csv'
df_corrected = pd.read_csv(file_path, sep=';', header=None)


df_corrected.columns = ["ShellSortTime2/1", "ShellSortTime3/2", "ShellSortTime4/3", "QuickSort", "MyOwnGaps3k+1", "PrimeNumbersGap", "SegewickModifiedGaps"]
df_corrected.index = ["10000","20000","30000","40000","50000"]


plt.figure(figsize=(12, 8))

for column in df_corrected.columns:
    plt.plot(df_corrected.index, df_corrected[column],marker='o', label=column)

plt.title('Comparison of Sorting Algorithms Performance')
plt.xlabel('Number Of Elements')
plt.ylabel('Time (milliseconds)')
plt.legend()
plt.grid(True)
plt.show()
