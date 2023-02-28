#include <iostream>	
#include <stdio.h>	
#include <fstream>
#define MAX 20

using namespace std;

int A[MAX][MAX];
char vertex[MAX];
int n;

void initGraph()
{
	n = 0; 
}
void inputGraphFromTxt()
{
	string line;
	ifstream myfile("mtk.txt");
	if (myfile.is_open())
	{
		myfile >> n;
		for (int i = 0; i < n; i++)
			myfile >> vertex[i];
		for (int i = 0; i < n; i++)
			for (int j = 0; j < n; j++)
				myfile >> A[i][j];
		myfile.close();
	}
}
void inputGraph()
{
	cout << "Nhap so dinh cua do thi: "; cin >> n;
	for (int i = 0; i < n; i++)
	{
		cout << "Nhap ten cho dinh thu tu [" << i << "]: "; cin >> vertex[i];
		cout << "Nhap du lieu cho dong thu [" << i << "]: " << endl;
		for (int j = 0; j < n; j++)
		{
			cin >> A[i][j];
		}
	}
}

void output(int a[], int n)
{
	for (int i = 0; i < n; i++)
		cout << vertex[a[i]] << " ";
}

void outputGraph()
{
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
			cout << A[i][j] << " ";
		cout << "\n";
	}
}

int main()
{
	int option;
	system("cls");
	cout << "----------BIEU DIEN DO THI-------------\n";
	cout << "1. Khoi tao ma tran ke rong\n";
	cout << "2. Nhap ma tran ke tu file text\n";
	cout << "3. Nhap tay ma tran ke\n";
	cout << "4. Xuat ma tran ke\n";

	do 
	{
		cout << "Nhap lua chon: "; cin >> option;
		switch (option)
		{
		case 1:
			initGraph();
			break;
		case 2:
			inputGraphFromTxt();
			break;
		case 3:
			inputGraph();
			break;
		case 4:
			outputGraph();
			break;
		default:
			break;
		}

	} while (option <= 4 && option >= 1);


	cin.get();
}
