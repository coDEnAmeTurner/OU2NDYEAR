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
void heapify(int a[], int n, int i)
{
	int largest = i;
	int l = 2 * i + 1;
	int r = 2 * i + 2;

	if (l < n && a[l] > a[largest])
	{
		largest = l;
	}
	if (r < n && a[r] > a[largest])
	{
		largest = r;
	}

	if (largest != i)
	{
		swap(a[i], a[largest]);
		heapify(a, n, largest); //largest gio co the khong theo luat cua heap nen goi tiep heapify cho largest
	}
}
//Heap sort that works:
void heapSort2()
{
	for (int i = n / 2 - 1; i >= 0; i--) //tao heap lan dau tien khi sap xep
	{
		heapify(a, n, i);
	}
	for (int i = n - 1; i >= 0; i--)
	{
		swap(a[0], a[i]);
		heapify(a, i, 0); //tao heap cac lan tiep theo 
	}
}
void shift(int a[], int i, int n)
{
	int j = 2 * i + 1;
	if (j >= n)
	{
		return;
	}
	if (j + 1 < n)
		if (a[j] < a[j + 1])
			j++;
	if (a[i] >= a[j])
		return;
	else
	{
		int x = a[i];
		a[i] = a[j];
		a[j] = x;
		shift(a, j, n);
	}
}
void HeapSort(int a[], int n)
{
	int i = (n / 2) - 1;
	while (i >= 0)
	{
		shift(a, i, n);
		i--;
	}
	int r = n - 1;
	while (r > 0)
	{
		swap(a[0], a[r]);
		r--;
		if (r > 0)
			shift(a, 0, r);
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

	cout << "-------HEAPSORT---------" << endl;
	cout << "1. Nhap mang ngau nhien." << endl;
	cout << "2. Tu nhap mang " << endl;
	cout << "3. Xuat mang" << endl;
	cout << "4. Heap Sort 1" << endl;
	cout << "5. Selection Sort" << endl;
	cout << "6. Insertion Sort" << endl;
	cout << "7. Heap Sort 2" << endl;
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
			HeapSort(b, n);
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
			heapSort2();
			duration = (clock() - start) / (double)CLOCKS_PER_SEC;
			cout << "Heap sort ton: " << duration * pow(10.0, 6.0) << "ms" << endl;
			break;
		default:
			break;
		}
	} while (choice != 9);
	system("pause");
}