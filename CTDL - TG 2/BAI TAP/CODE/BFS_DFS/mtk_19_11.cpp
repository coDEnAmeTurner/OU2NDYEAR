#include <iostream>	
#include <stdio.h>	
#include <fstream>
#define MAX 20

//can't input matrix A from txt

using namespace std;

struct Node
{
	int info;
	Node* next;

	Node(int x)
	{
		info = x;
		next = NULL;
	}
};

int A[MAX][MAX];
char vertex[MAX];
int n;

Node* front, *rear;
Node* sp;

void initStack()
{
	sp = nullptr;
}
void push(int x)
{
	if (sp == NULL)
		sp = new Node(x);
	else
	{
		Node* newNode = new Node(x);
		newNode->next = sp;
		sp = newNode;
	}
}
void pop()
{
	if (sp == nullptr)
		return;
	else
	{
		Node* temp = sp;
		sp = sp->next;
		delete temp;
	}
}
int peekS()
{
	if (sp != NULL)
		return sp->info;
}


void initQueue()
{
	front = nullptr;
	rear = nullptr;
}
void enqueue(int x)
{
	if (front == NULL && rear == NULL)
	{
		front = new Node(x);
		rear = front;
	}
	else
	{
		rear->next = new Node(x);
		rear = rear->next;
	}
}
void dequeue()
{
	if (front == NULL && rear == NULL)
	{
		return;
	}
	else
	{
		if (front == rear)
		{
			delete front;
			front = nullptr;
			rear = nullptr;
		}
		else
		{
			Node* temp = front;
			front = front->next;
			delete temp;
			temp = nullptr;
		}
	}
}
int peekQ()
{
	if (front != NULL && rear != NULL)
		return front->info;
}

void initGraph()
{
	n = 0; 
}
void inputGraphFromTxt()
{
	string line;
	ifstream myfile("D:/OU 2ND YEAR/CTDL - TG 2/BAI TAP/CODE/12-11/12-11/dsk.txt");
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

int C[100], bfs[100];
int nbfs = 0;
void initC()
{
	for (int i = 0; i < n; i++)
	{
		C[i] = 1;
	}
}
void BFS(int v)
{
	int w, p;
	enqueue(v);
	C[v] = 0;
	while (front != NULL)
	{
		p = peekQ();
		dequeue();

		bfs[nbfs] = p;
		nbfs++;

		for (w = 0; w < n; w++)
		{
			if (C[w] && A[p][w] != 0)
			{
				enqueue(w); 
				C[w] = 0;
			}
		}
	}
}

int dfs[100];
int ndfs = 0;
void DFS(int s)
{
	push(s);
	dfs[ndfs] = s;
	ndfs++;
	C[s] = 0;
	int u = s, v = -1; //u la dinh dang visit
	while (sp != nullptr)
	{
		if (v == n) //khong tim duoc them dinh ke cua u 
		{
			u = peekS(); //stack top luc nao cung la dinh di truoc, nen pop no ra la bat dau backtrack
			pop();
		}
		for (v = 0; v < n; v++)
		{
			if (A[u][v] != 0 && C[v] == 1)
			{
				push(v); //de backtrack
				push(u); //de backtrack 1 dinh hon 2 lan
				dfs[ndfs] = v;
				ndfs++;
				C[v] = 0;
				u = v; //dinh tiep theo can visit la v, vi v o level tiep theo
				break; //de chi di theo huong cua v
			}
		}
	}
}

void searchByBFS(char x, int v)
{
	int w, p;
	enqueue(v);
	C[v] = 0;
	while (front != NULL)
	{
		p = peekQ();
		dequeue();

		if (x == vertex[p])
		{
			cout << "Tim thay x = " << vertex[p] << endl;
			return;
		}

		for (w = 0; w < n; w++)
		{
			if (C[w] && A[p][w] != 0)
			{
				enqueue(w);
				C[w] = 0;
			}
		}
	}
}

void searchByDFS(char x, int s)
{
	push(s);
	dfs[ndfs] = s;
	ndfs++;
	C[s] = 0;
	int u = s, v = -1;
	while (sp != nullptr)
	{
		if (v == n)
		{
			u = peekS();
			pop();

			if (x == vertex[u])
			{
				cout << "Tim thay x = " << vertex[u] << endl;
				return;
			}
		}


		for (v = 0; v < n; v++)
		{
			if (A[u][v] != 0 && C[v] == 1)
			{
				push(v);
				push(u);
				dfs[ndfs] = v;
				ndfs++;
				C[v] = 0;
				u = v;
				break;
			}
		}
	}
}

int main()
{
	int option, x;
	char letter;
	system("cls");
	cout << "----------BIEU DIEN DO THI-------------\n";
	cout << "1. Khoi tao ma tran ke rong\n";
	cout << "2. Nhap ma tran ke tu file text\n";
	cout << "3. Nhap tay ma tran ke\n";
	cout << "4. Xuat ma tran ke\n";
	cout << "5. BFS" << endl;
	cout << "6. DFS" << endl;
	cout << "7. Search by BFS: " << endl;
	cout << "8. Search by DFS: " << endl;

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
		case 5:
			initQueue();
			initC();
			cout << "Vui long nhap dinh xuat phat: ";
			cin >> x;
			nbfs = 0;
			BFS(x);
			cout << "Thu tu dinh sau khi duyet BFS: ";
			output(bfs, n);
			cout << "\n";
			break;
		case 6:
			initStack();
			initC();
			cout << "Vui long nhap dinh xuat phat: ";
			cin >> x;
			ndfs = 0;
			DFS(x);
			cout << "Thu tu dinh sau khi duyet DFS: " << endl;
			output(dfs, n);
			cout << "\n";
			
			break;
		case 7:
			initQueue();
			initC();
			nbfs = 0;
			cout << "Vui long nhap dinh can tim: ";
			cin >> letter;
			searchByBFS(letter, 0);
			cout << "\n";
			
			break;
		case 8:
			initStack();
			initC();
			ndfs = 0;
			cout << "Vui long nhap dinh can tim: ";
			cin >> letter;
			searchByDFS(letter, 0);
			cout << "\n";
			break;
		default:
			break;
		}

	} while (option <= 8 && option >= 1);


	cin.get();
}
