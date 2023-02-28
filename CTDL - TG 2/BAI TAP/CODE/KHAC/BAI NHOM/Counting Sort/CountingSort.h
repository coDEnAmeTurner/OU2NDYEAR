#pragma once

//Time Complex: O(n + k)
void countingSort(int a[], int sorted[], int n)
{
	if (n == 0 || n == 1)
		return;
	int tmpn = 0; 
	//step 1:
	//decide the size k of tmp by going through each entry of a, if the entry > current tmpn (currently 0), assign entry to tmpn
	for (int i = 0; i < n; i++)
	{
		if (a[i] + 2 > tmpn)
			tmpn = a[i] + 2;
	}
	int* tmp = new int[tmpn];
	for (int i = 0; i < tmpn; i++)
	{
		tmp[i] = 0;
	}
	//for each entry in a, increment its corresponding entry in tmp where a's entry is tmp's index
	for (int i = 0; i < n; i++)
	{
		tmp[a[i]]++;
	}

	//step 2:
	//do addition: tmp[i] = tmp[i] + tmp[i - 1], where 1 <= i <= tmpn - 1
	for (int i = 1; i < tmpn; i++)
	{
		tmp[i] += tmp[i - 1];
	}

	//step 3:
	//add sorted values to sorted array based on current tmp, but before adding, decrement the value in tmp
	for (int i = n - 1; i >= 0; i--)
	{
		tmp[a[i]]--;
		sorted[tmp[a[i]]] = a[i];
	}
	delete[] tmp;
}