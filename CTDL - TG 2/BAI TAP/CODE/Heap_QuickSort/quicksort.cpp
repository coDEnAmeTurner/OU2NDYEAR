#include <stdio.h>	
#include <iostream>
#include <ctime>	
#define MAX 100000

int a[MAX];
int n = 0;

using namespace	std;

void swap(int& a, int& b)
{
	int tmp = a;
	a = b;
	b = tmp;
}
void init()
{
	do {
		cout << "Nhap so phan tu: "; cin >> n;
		if (n < 1 || n > MAX)
		{
			cout << "Nhap so n < " << MAX << endl;
		}
	} while (n < 1 || n > MAX);
	srand(time(0));
	for (int i = 0; i < n; i++)
	{
		a[i] = rand() % 20 + 1;
	}
	cout << "Mang sau khi nhap ngau nhien: " << endl; 
	for (int i = 0; i < n; i++)
	{
		cout << a[i] << " ";
	}
}
void input()
{
	do {
		cout << "Nhap so phan tu: "; cin >> n;
		if (n < 1 || n > MAX)
		{
			cout << "Nhap so n < " << MAX << endl;
		}
	} while (n < 1 || n > MAX);
	for (int i = 0; i < n; i++)
	{
		cout << "Nhap phan tu a[" << i << "]: "; cin >> a[i];
	}
	cout << "Mang sau khi nhap: " << endl;
	for (int i = 0; i < n; i++)
	{
		cout << a[i] << " ";
	}
}
void output()
{
	if (n == 0) return;
	for (int i = 0; i < n; i++)
	{
		cout << a[i] << " ";
	}
}
void QuickSort1(int a[], int l, int r)
{
	int x = a[(l + r) / 2];
	int i = l;
	int j = r;

	while (i < j)
	{
		while (a[i] < x)
		{
			i++;
		}
		while (a[j] > x)
		{
			j--;
		}
		if (i <= j)
		{
			swap(a[i], a[j]);
			i++;
			j--;
		}
	}
	if (l < j) QuickSort1(a, l, j);
	if (i < r) QuickSort1(a, i, r);
}
int partition(int a[], int low, int high)
{
	int pivot = a[high];
	int left = low;
	int right = high - 1;
	while (true)
	{
		while (left <= right && a[left] < pivot) left++;
		while (right >= left && a[right] > pivot) right--;
		if (left >= right)
			break;
		swap(a[left], a[right]);
		left++;
		right--;
	}
	swap(a[left], a[high]);
	return left;
	
}
void QuickSort2(int a[], int low, int high)
{
	if (low < high)
	{
		int pi = partition(a, low, high);

		QuickSort2(a, low, pi - 1);
		QuickSort2(a, pi + 1, high);

	}
}
int Partition(int A[], int start, int end)
{
	int pivot = end;
	int pindex = start;
	for (int i = start; i < end; i++)
	{
		if (A[i] <= A[pivot])
		{
			swap(A[i], A[pindex]);
			pindex++;
		}
	}
	swap(A[pivot], A[pindex]);
	return pindex;
}
void QuickSort3(int a[], int l, int r)
{
	if (l < r)
	{
		int pivot = Partition(a, l, r);
		QuickSort3(a, l, pivot - 1);
		QuickSort3(a, pivot + 1, r);

	}
}
void selectionSort(int a[], int n)
{
	int i, j, min_pos;
	for (i = 0; i < n - 1; i++)
	{
		min_pos = i;
		for (int j = i + 1; j < n; j++)
		{
			if (a[min_pos] > a[j])
			{
				min_pos = j;
				swap(a[min_pos], a[j]);
			}
		}
	}
}
void insertionSort(int a[], int n)
{
	for (int i = 1; i < n; i++)
	{
		int x = a[i];
		int j = i - 1;
		while (j >= 0 && a[j] > x)
		{
			a[j + 1] = a[j];
			j--;
		}
		a[j] = x;
	}
}
void copyArray(int a[], int b[], int n)
{
	for (int i = 0; i < n; i++)
	{
		b[i] = a[i];
	}
}

int main()
{
	int choice;
	clock_t start;
	double duration;
	int b[MAX];

	cout << "-------QUICKSORT---------" << endl;
	cout << "1. Nhap mang ngau nhien." << endl;
	cout << "2. Tu nhap mang " << endl;
	cout << "3. Xuat mang" << endl;
	cout << "4. Quick Sort 1" << endl;
	cout << "5. Selection Sort" << endl;
	cout << "6. Insertion Sort" << endl;
	cout << "7. Quick Sort 2" << endl;
	cout << "8. Quick Sort 3" << endl;
	cout << "9. Thoat" << endl;
	
	do {
		cout << "Chon: "; cin >> choice;
		switch (choice)
		{
		case 1:
			init();
			cout << endl;
			break;
		case 2:
			input();
			cout << endl;

			break;
		case 3:
			output();
			cout << endl;

			break;
		case 4:
			copyArray(a, b, n);
			start = clock();
			QuickSort1(a, 0, n - 1);
			duration = (clock() - start) / (double)CLOCKS_PER_SEC;
			cout << "Quick sort 1 ton: " << duration * pow(10.0, 6.0) << "ms" << endl;
			break;
		case 5:
			copyArray(a, b, n);
			start = clock();
			selectionSort(b, n);
			duration = (clock() - start) / (double)CLOCKS_PER_SEC;
			cout << "Selection sort ton: " << duration * pow(10.0, 6.0) << "ms" << endl;
			break;
		case 6:
			copyArray(a, b, n);
			start = clock();
			insertionSort(b, n);
			duration = (clock() - start) / (double)CLOCKS_PER_SEC;
			cout << "Insertion sort ton: " << duration * pow(10.0, 6.0) << "ms" << endl;
			break;
		case 7:
			copyArray(a, b, n);
			start = clock();
			QuickSort2(a, 0, n - 1);
			duration = (clock() - start) / (double)CLOCKS_PER_SEC;
			cout << "Quick sort 2 ton: " << duration * pow(10.0, 6.0) << "ms" << endl;
			break;
		case 8:
			copyArray(a, b, n);
			start = clock();
			QuickSort3(a, 0, n - 1);
			duration = (clock() - start) / (double)CLOCKS_PER_SEC;
			cout << "Quick sort 3 ton: " << duration * pow(10.0, 6.0) << "ms" << endl;
			break;
		default:
			break;
		}
	} while (choice != 9);
	system("pause");
}