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
	ifstream myfile("C:/Users/admin/Downloads/mtts4.txt");
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

	while (front != NULL) //check q rổng
	{
		p = peekQ();
		dequeue();

		bfs[nbfs] = p;
		nbfs++;

		for (w = 0; w < n; w++)
		{
			if (C[w] && A[p][w] != 1)
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
	int u = s, v = -1;
	while (sp != nullptr)
	{
		if (v == n)
		{
			u = peekS();
			pop();
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

void searchByBFS(int x, int v)
{
	int w, p;
	enqueue(v);
	C[v] = 0;
	while (front != NULL)
	{
		p = peekQ();
		dequeue();

		if (x == p)
		{
			cout << "Tim thay x = " << x << endl;
			return;
		}

		for (w = 0; w < n; w++)
		{
			if (C[w] && A[p][w] == 1)
			{
				enqueue(w);
				C[w] = 0;
			}
		}
	}
}

void searchByDFS(int x, int s)
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
		}

		if (x == u)
		{
			cout << "Tim thay x = " << x << endl;
			return;
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

int dist[MAX];
int previous[MAX];
void initBell()
{
	for (int i = 0; i < MAX; i++)
	{
		dist[i] = INT_MAX;
		previous[i] = 0;
	}

}
void BellmanFord(int src) {
	dist[src] = 0;
	for (int k = 0; k < n - 1; k++)
	{
		for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < n; j++)
			{
				if (dist[i] != INT_MAX && A[i][j] && dist[j] > (dist[i] + A[i][j])) 
				{
					dist[j] = dist[i] + A[i][j];
					previous[j] = i;
				}
			}
		}
	}

	for (int k = 0; k < n - 1; k++)
	{
		for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < n; j++)
			{
				if (A[i][j] && dist[j] > (dist[i] + A[i][j]))
				{
					dist[j] = INT_MAX;
					previous[j] = -1;
					cout << "Graph contains negative weight cycle" << endl;
					return;
				}
			}
		}
	}

	cout << "Vertex: \t\t";
	for (int i = 0; i < n; i++)
		cout << vertex[i] << "\t";
	cout << "\nDistance From source: \t";
	for (int i = 0; i < n; i++)
		cout << dist[i] << "\t";
	cout << "\n";
	return;
}
int minimumDist(int dist[], bool Tset[])
{
	int min = INT_MAX, index;

	for (int i = 0; i < 6; i++)
	{
		if (Tset[i] == false && dist[i] <= min)
		{
			min = dist[i];
			index = i;
		}
	}
	return index;
}

void Dijkstra(int src)
{
	int dist[MAX];
	dist[src] = 0;
	for (int k = 0; k < n - 1; k++)
	{
		for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < n; j++)
			{
				if (dist[i] != INT_MAX && A[i][j] && dist[j] >(dist[i] + A[i][j]))
				{
					dist[j] = dist[i] + A[i][j];
					previous[j] = i;
				}
			}
		}
	}

	for (int k = 0; k < n - 1; k++)
	{
		for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < n; j++)
			{
				if (A[i][j] && dist[j] >(dist[i] + A[i][j]))
				{
					dist[j] = INT_MAX;
					previous[j] = -1;
					cout << "Graph contains negative weight cycle" << endl;
					return;
				}
			}
		}
	}

	dist[src] = 0;
	bool Tset[MAX]; //visited array

	for (int i = 0; i < n; i++) 
	{
		dist[i] = INT_MAX;
		Tset[i] = false;
	}

	dist[src] = 0; 
	
	//priority queue is replaced with minimumDist() and dist[]
	for (int i = 0; i < n; i++)
	{
		int m = minimumDist(dist, Tset);
		Tset[m] = true;

		for (int i = 0; i < n; i++)
		{
			if (!Tset[i] && A[m][i] && dist[m] != INT_MAX && dist[m] + A[m][i] < dist[i])
				dist[i] = dist[m] + A[m][i];
		}
	}
	cout << "Vertex\t\tDistance from source" << endl;
	for (int i = 0; i < n; i++)
	{
		cout << vertex[i] << "\t\t\t" << dist[i] << endl;
	}
}

//khai bao tap E
int E1[MAX];
int E2[MAX];
int wE[MAX];
int nE = 0; //so phan tu tap E

//khai bao tap T
int T1[MAX];
int T2[MAX];
int wT[MAX];
int nT = 0; //so phan tu tap T

void TaoE()
{
	for (int i = 0; i < n; i++)
	{
		for (int j = i; j < n; j++)
		{
			if (A[i][j] != 0)
			{
				E1[nE] = i;
				E2[nE] = j;
				wE[nE] = A[i][j];
				A[i][j] = 0;
				A[j][i] = 0;
				nE++;
			}
		}
	}
}

int TonTai(int E, int T[], int nT)
{
	for (int i = 0; i < nT; i++)
	{
		if (E == T[i])
			return 1;
	}
	return 0;
}

void Swap(int &a, int &b)
{
	int temp = a;
	a = b;
	b = temp;
}

void SapXepE()
{
	for (int i = 0; i < nE - 1; i++)
	{
		for (int j = i + 1; j < nE; j++)
		{
			if (wE[i] > wE[j])
			{
				swap(wE[i], wE[j]);
				swap(E1[i], E1[j]);
				swap(E2[i], E2[j]);

			}
		}
	}
}

int connectedComponent()
{
	int visited[MAX];
	int nV = 0; 
	int i = 0, j = 0;
	int nC = 0;

	while (nV < n)
	{
		for (j = 0; j < n; j++)
		{
			if (A[i][j] != 0 && visited[j] != 1)
			{
				visited[j] = 1;
				nV++;
				i = j;
				break;
			}
		}
		if (j >= n && i < n - 1)
		{
			i++;
			visited[i] = 1;
			nV++;
			nC++;
		}
		else if (j >= n && i >= n - 1)
		{
			i = 1;
			visited[i] = 1;
			nV++;
			nC++;
		}
	}
	return nC;
}

void kruskal()
{
	for (int i = 0; i < nE; i++)
	{
		//kiem tra co gay vong lap neu add canh i 
		if (TonTai(E1[i], T1, nT) == 1 && TonTai(E2[i], T2, nT) == 1)
			continue;
		if (TonTai(E1[i], T2, nT) == 1 && TonTai(E2[i], T1, nT) == 1)
			continue;

		//cho canh i vao T
		T1[nT] = E1[i];
		T2[nT] = E2[i];
		wT[nT] = wE[i];
		nT++;
		if (nT == n - 1)
			break;
	}
}

void output(bool VertexName)
{
	int tong = 0;
	for (int i = 0; i < nT; i++)
	{
		if (VertexName)
			cout << endl << "(" << vertex[T1[i]] << "," << vertex[T2[i]] << ") = " << wT[i];
		else
			cout << endl << "(" << T1[i] << "," << T2[i] << ") = " << wT[i];
		tong += wT[i];
	}
	cout << "\n Tong = " << tong;
}

void outputE(bool VertexName)
{
	int tong = 0;
	for (int i = 0; i < nE; i++)
	{
		if (VertexName)
			cout << endl << "(" << vertex[E1[i]] << "," << vertex[E2[i]] << ") = " << wT[i];
		else
			cout << endl << "(" << E1[i] << "," << E2[i] << ") = " << wT[i];
		tong += wT[i];
	}
	cout << "\n Tong = " << tong;
}

int main()
{
	int option, x, i;
	system("cls");
	cout << "----------BIEU DIEN DO THI-------------\n";
	cout << "1. Khoi tao ma tran ke rong\n";
	cout << "2. Nhap ma tran ke tu file text\n";
	cout << "3. Nhap tay ma tran ke\n";
	cout << "4. Xuat ma tran ke\n";
	cout << "5. BFS" << endl;
	cout << "6. DFS" << endl;
	cout << "7. Search by BFS: " << endl;
	cout << "8. Search by BFS: " << endl;
	cout << "9. Duong di ngan nhat BellFord: " << endl;
	cout << "10. Duong di ngan nhat Dijkstra: " << endl;
	cout << "11. Tim CAY BAO TRUM TOI THIEU bang Kruskal: " << endl;
	cout << "12. In ra tap E: " << endl;
	cout << "13. Connected Graph: " << endl;

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
			cin >> x;
			searchByBFS(x, 0);
			cout << "\n";
			
			break;
		case 8:
			initStack();
			initC();
			ndfs = 0;
			cout << "Vui long nhap dinh can tim: ";
			cin >> x;
			searchByDFS(x, 0);
			cout << "\n";
			break;
		case 9:
			cout << "Vui long nhap dinh: "; cin >> x;
			initBell();
			BellmanFord(x);
			break;
		case 10:
			cout << "Vui long nhap dinh: "; cin >> x;
			Dijkstra(x);
			break;
		case 11:
			nT = 0;
			TaoE();
			SapXepE();
			kruskal();
			cout << "Cay bao trum toi thieu voi Kruskal: " << endl;
			output(true);
			cout << endl;
			break;
		case 12:
			outputE(true);
			break;
		case 13:
			i = connectedComponent();
			cout << "i = " << i << endl;
			break;
		default:
			break;
		}

	} while (option <= 13 && option >= 1);


	cin.get();
}
