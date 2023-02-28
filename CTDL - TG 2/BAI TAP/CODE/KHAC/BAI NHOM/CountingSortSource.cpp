#include <iostream>	
#include <chrono>
#define MAX_SIZE 100

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
	//add sorted values to sorted array based on current tmp, before adding decrement the value at tmp
	for (int i = n - 1; i >= 0; i--)
	{
		tmp[a[i]]--;
		sorted[tmp[a[i]]] = a[i];
	}
	delete[] tmp;
}
int main()
{
    int a[MAX_SIZE];
    int b[MAX_SIZE];
    int n = 10;
    for (int i = 0; i < n; i++)
    {
        a[i] = rand() % 10 + 1;

    }
    for (int i = 0; i < n; i++)
    {
        std::cout << a[i] << " ";

    }
    std::cout << "\n";
    std::chrono::steady_clock::time_point begin = std::chrono::high_resolution_clock::now();
    
    countingSort(a, b, n);

    std::chrono::steady_clock::time_point end = std::chrono::high_resolution_clock::now();
    std::chrono::duration<float> duration = end - begin;

    for (int i = 0; i < n; i++)
    {
        std::cout << b[i] << " ";
    }
    std::cout << "\n";
    std::cout << "Duration: " << duration.count() * 1000.0 << "ms\n";

    std::cin.get();
}