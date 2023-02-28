#include <iostream>
#include <string>
#include <fstream>
#include <Windows.h>
#include <iomanip>
#define MAXCHOICE 9
#define MAX 20
#define W 4
#define WD 50

using namespace std;

int a[MAX][MAX], n = 0;
char vertex[MAX];
int dist[MAX];

struct Node
{
	int info;
	Node* link;
};

Node* first[MAX];

void initFirst()
{
	for (int i = 0; i < MAX; i++)
		first[i] = NULL;
}

void insertLast(Node*& first, int newInfo)
{
	Node* p = new Node;
	p->info = newInfo;
	p->link = NULL;

	if (first == NULL)
		first = p;
	else
	{
		Node* q = first;
		while (q->link != NULL)
			q = q->link;
		q->link = p;
	}
}

void colorText(int colorCode)
{
	HANDLE h = GetStdHandle(STD_OUTPUT_HANDLE);
	SetConsoleTextAttribute(h, colorCode);
}

void initGraph() { n = 0; }

void initMatrix(int a[MAX][MAX], int& n)
{
	cout << "Enter n = ";
	cin >> n;

	while (n <= 0 || n > MAX)
	{
		colorText(12);
		cout << "Invalid! Again: ";
		colorText(7);
		cin >> n;
	}

	for (int i = 0; i < n; i++)
	{
		cout << "Name of vertex: ";
		cin >> vertex[i];

		for (int j = 0; j < n; j++)
			a[i][j] = rand() % 50;
	}
}

void inputMatrix(int a[MAX][MAX], int& n)
{
	cout << "Enter n = ";
	cin >> n;

	while (n <= 0 || n > MAX)
	{
		colorText(12);
		cout << "Invalid! Again: ";
		colorText(7);
		cin >> n;
	}

	for (int i = 0; i < n; i++)
	{
		cout << "Name of vertex: ";
		cin >> vertex[i];

		for (int j = 0; j < n; j++)
		{
			cout << "a[" << i + 1 << "][" << j + 1 << "] = ";
			cin >> a[i][j];
		}
	}
}

void inputMatrix_txt(int a[MAX][MAX], int& n, string filetxt)
{
	ifstream inFile(filetxt);

	if (inFile.is_open())
	{
		inFile >> n;

		if (n <= 0 || n > MAX)
		{
			colorText(12);
			cout << "Invalid!";
			colorText(7);
			return;
		}

		for (int i = 0; i < n; i++)
		{
			inFile.ignore();
			inFile >> vertex[i];
		}

		for (int i = 0; i < n; i++)
			for (int j = 0; j < n; j++)
			{
				inFile.ignore();
				inFile >> a[i][j];
			}
	}
	else
	{
		colorText(12);
		cout << "The file can't be opened!\n";
		colorText(7);
	}

	inFile.close();
}

void outMatrix(int a[MAX][MAX], int n)
{
	colorText(6);
	cout << " " << setfill('=') << setw((W + 3) * n + 1) << "=" << endl;

	for (int i = 0; i < n; i++)
		cout << setfill(' ') << " | " << setw(W) << left << vertex[i];
	cout << " | \n";

	cout << " " << setfill('=') << setw((W + 3) * n + 1) << "=" << endl;

	colorText(7);
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
		{
			colorText(6);
			cout << " | ";
			colorText(7);
			cout << setfill(' ') << setw(W) << left << a[i][j];

		}
		colorText(6);
		cout << " | \n";
		cout << " " << setfill('-') << setw((W + 3) * n + 1) << "-" << endl;
	}

	colorText(7);
}

void initAdList_txt(string filetxt)
{
	ifstream inFile(filetxt);
	if (inFile.is_open())
	{
		inFile >> n;

		if (n <= 0)
		{
			colorText(12);
			cout << "Invalid!\n";
			colorText(7);
			return;
		}

		for (int i = 0; i < n; i++)
		{
			inFile.ignore();
			inFile >> vertex[i];
		}

		initFirst();

		for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < n; j++)
			{
				inFile.ignore();
				int x;
				inFile >> x;

				if (x == 0)
					continue;
				else
					insertLast(first[i], j);
			}
		}
	}
	else
	{
		colorText(12);
		cout << "The file can't be opened!\n";
		colorText(7);
	}

	inFile.close();
}

void initAdList_matrix()
{
	initFirst();

	for (int i = 0; i < n; i++)
		for (int j = 0; j < n; j++)
			if (a[i][j] == 0)
				continue;
			else
				insertLast(first[i], j);
}

void outAdList()
{
	for (int i = 0; i < n; i++)
	{
		colorText(6);
		cout << vertex[i] << ": ";

		Node* p = new Node;
		p = first[i];
		while (p != NULL)
		{
			colorText(7);
			cout << p->info;
			colorText(8);
			cout << " -> ";
			p = p->link;
		}
		if (p == NULL)
		{
			colorText(7);
			cout << "NULL\n";
		}
		cout << endl;
	}
}

int E1[MAX];
int E2[MAX];
int wE[MAX];
int nE = 0;

int T1[MAX];
int T2[MAX];
int wT[MAX];
int nT = 0;

int tonTai(int d, int D[], int nD)
{
	for (int i = 0; i < nD; i++)
		if (D[i] == d)
			return 1;

	return 0;
}

void XoaViTriE(int i)
{
	for (int j = i; j < nE; j++)
	{
		E1[j] = E1[j + 1];
		E2[j] = E2[j + 1];
		wE[j] = wE[j + 1];
	}

	nE--;
}

void XoaCanhE(int u, int v)
{
	for(int i = 0; i < nE; i++)
		if (E1[i] == u && E2[i] == v)
		{
			XoaViTriE(i);
			break;
		}
}

void Prim(int s)
{
	//d1, d2 de chua dinh s va e cua canh co weight chua trong min
	int u = s, min, i, d1, d2;

	while (nT < n - 1)
	{
		//add canh ke cua u vao E
		for (int v = 0; v < n; v++) 
			if (a[u][v] != 0)
				if (tonTai(v, T2, nT) == 0) //neu canh ke chua co trong T
				{
					E1[nE] = u;
					E2[nE] = v;
					wE[nE] = a[u][v];
					nE++;
				}
		
		//lay canh dau tien thoa dieu kien lam min
		for (i = 0; i < nE; i++)
			if (tonTai(E2[i], T2, nT) == 0) //neu co 1 dinh dich chua co trong T2 (1 canh chua co trong T)
			{
				min = wE[i];
				d1 = E1[i];
				d2 = E2[i];
				break;
			}

		//tim canh min that
		for (; i < nE; i++)
			if (tonTai(E2[i], T2, nT) == 0)
				if (min > wE[i])
				{
					min = wE[i];
					d1 = E1[i];
					d2 = E2[i];
				}

		//add canh min vao T
		T1[nT] = d1;
		T2[nT] = d2;
		wT[nT] = a[d1][d2];

		//xoa canh min khoi ma tran ke
		a[d1][d2] = 0;
		a[d2][d1] = 0;
		nT++;
		XoaCanhE(d1, d2);

		//set dinh dang visit la dinh dich cua canh min 
		u = d2;
	}
}

void outGraph(bool vertexName)
{
	int tong = 0;

	for (int i = 0; i < nT; i++)
	{
		if (vertexName)
			cout << "(" << vertex[T1[i]] << ", " << vertex[T2[i]] << ") = " << wT[i] << endl;
		else
			cout << "(" << T1[i] << ", " << T2[i] << ") = " << wT[i] << endl;

		tong += wT[i];
	}

	cout << "\tTong = " << tong << endl;
}

int main()
{
	int choice, x;
	bool cont = true;
	string filetxt;

	do {
		system("cls");

		colorText(11);
		cout << "\t+" << setfill('=') << setw(WD / 2 + 3) << "=" << " SPANNING TREE " << setw(WD / 2 + 3) << "=" << "+\n"
			<< "\t|" << setfill(' ') << setw(3) << " " << setw(WD + 10) << left << "1. Intialize a random matrix" << setw(3) << "|\n"
			<< "\t|" << setfill(' ') << setw(3) << " " << setw(WD + 10) << left << "2. Input a matrix" << setw(3) << "|\n"
			<< "\t|" << setfill(' ') << setw(3) << " " << setw(WD + 10) << left << "3. Input a matrix from file .txt" << setw(3) << "|\n"
			<< "\t|" << setfill(' ') << setw(3) << " " << setw(WD + 10) << left << "4. Ouput the matrix" << setw(3) << "|\n"
			<< "\t|" << setfill(' ') << setw(3) << " " << setw(WD + 10) << left << "5. Intialize the adjacency list from file .txt" << setw(3) << "|\n"
			<< "\t|" << setfill(' ') << setw(3) << " " << setw(WD + 10) << left << "6. Intialize the adjacency list from the matrix" << setw(3) << "|\n"
			<< "\t|" << setfill(' ') << setw(3) << " " << setw(WD + 10) << left << "7. Output the adjacency list" << setw(3) << "|\n"
			<< "\t|" << setfill(' ') << setw(3) << " " << setw(WD + 10) << left << "8. Prim" << setw(3) << "|\n"
			<< "\t|" << setfill(' ') << setw(3) << " " << MAXCHOICE << setw(WD + 10 - 2) << left << ". Exit" << setw(3) << "|\n"
			<< "\t+" << setfill('=') << setw(WD + 13) << "=" << "+\n"
			<< "Your choice: ";
		colorText(7);
		cin >> choice;

		while (choice <= 0 || choice > MAXCHOICE)
		{
			colorText(12);
			cout << "Invalid! Again: ";
			colorText(7);
			cin >> choice;
		}

		switch (choice)
		{
		case 1:
			initMatrix(a, n);
			colorText(2);
			cout << "Done!\n";
			break;
		case 2:
			inputMatrix(a, n);
			colorText(2);
			cout << "Done!\n";
			break;
		case 3:
			cout << "File: ";
			cin >> filetxt;
			inputMatrix_txt(a, n, filetxt);
			colorText(2);
			cout << "Done!\n";
			break;
		case 4:
			if (n > 0)
			{
				colorText(6);
				cout << "The matrix:\n";
				outMatrix(a, n);
			}
			else
			{
				colorText(12);
				cout << "The matrix is unavailable!\n";
			}
			break;
		case 5:
			cout << "File: ";
			cin >> filetxt;
			initAdList_txt(filetxt);
			colorText(2);
			cout << "Done!\n";
			break;
		case 6:
			if (n > 0)
			{
				initAdList_matrix();
				colorText(2);
				cout << "Done!\n";
			}
			else
			{
				colorText(12);
				cout << "The matrix is unavailable!\n";
			}
			break;
		case 7:
			outAdList();
			break;
		case 8:
			cout << "Vertex: ";
			cin >> x;
			Prim(x);
			cout << "Cay khung toi tieu:\n";
			outGraph(true);
			break;
		default:
			cont = false;
			colorText(12);
			cout << "Thanks for visiting us! Goodbye and see you again!\n";
			break;
		}

		colorText(7);
		system("pause");
	} while (cont == true);
}