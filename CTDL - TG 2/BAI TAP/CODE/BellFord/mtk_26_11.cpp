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
int n; //number of vertices

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
	ifstream myfile("D:/OU 2ND YEAR/CTDL - TG 2/BAI TAP/CODE/26-11/mtts4.txt");
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

//C is to check if the vertex is visited, if no then 1, yes then 0
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
			if (C[w] && A[p][w] == 1)
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

	int u = s, 
		v = -1; 
	while (sp != nullptr)
	{
		if (v == n) //can not find any edge to the neighbour and the neighbour is not visited => have traversed to the deepest level
		{
			u = peekS(); //remember the top is always the "prev", so in other words, you are backtracking by poping into u
			pop();
			//after entering this block, the traversal is backtracking
			//so backtracking by using a stack and var tracking latest printed vertex
		}

		for (v = 0; v < n; v++)
		{
			if (A[u][v] != 0 && C[v] == 1) //v is to traverse u's neighbours and is the vertex to be printed
			{
				push(v); //so that later we can backtrack it
				push(u); //push prev of v twice so that you may revisit it twice or more
				dfs[ndfs] = v;
				ndfs++;
				C[v] = 0;
				u = v; //u keeps track of the vertex printed so far, which is at the furthest level, this line might be redundant when pushing only 1 vertex for each latest printed vertex
				break; //since you want to traverse to the next level's vertex, break makes sure you will not relax any other edge to other neighbour, since you want to keep moving to furthest level
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
		for (int i = 0; i < n; i++) //go through each edge of graph
		{
			for (int j = 0; j < n; j++)
			{
				if (dist[i] != INT_MAX && A[i][j] && dist[j] > dist[i] + A[i][j]) 
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

int main()
{
	int option, x;
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
		default:
			break;
		}

	} while (option <= 9 && option >= 1);


	cin.get();
}
