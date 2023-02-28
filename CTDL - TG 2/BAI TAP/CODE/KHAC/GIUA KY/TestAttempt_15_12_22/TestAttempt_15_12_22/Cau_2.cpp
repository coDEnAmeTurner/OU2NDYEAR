#include <iomanip>
#include <iostream>
#include <sstream>
#include <fstream>
#include <string>
#define MAX 200

using namespace std;

struct Edge {
	int src, dest, weight;
	Edge* next = NULL;

};

struct Graph {
	int V, E; //number of vertices and edges

	//edge list
	struct Edge* edge;
};

char VertexList[MAX];

void initGraph(Graph& g)
{
	g.V = 0;
	g.E = 0;
	g.edge = NULL;
}

void insertLast(Edge*& head, Edge* e)
{
	if (head == NULL)
	{
		head = e;
	}
	else
	{
		Edge* temp = head;
		while (temp->next != NULL)
		{
			temp = temp->next;
		}
		temp->next = e;

	}
}

void inputGraphFromFile(Graph& g)
{
	ifstream myFile;
	myFile.open("D:/OU 2ND YEAR/CTDL - TG 2/BAI TAP/CODE/GIUA KY/TestAttempt_15_12_22/TestAttempt_15_12_22/edgeList.txt");

	if (myFile.is_open())
	{
		myFile >> g.V;
		for (int i = 0; i < g.V; i++)
		{
			myFile >> VertexList[i];
		}

		myFile.ignore();
		string line;
		char src, dest;
		while (!myFile.eof())
		{
			Edge* e = new Edge();
			getline(myFile, line);
			g.E++;
			if (line == "")
				break;
			istringstream sstr(line);
			sstr >> src;
			sstr >> dest;
			sstr >> e->weight;
			e->src = (int)src;
			e->dest = (int)dest;
			insertLast(g.edge, e);
		}

		myFile.close();
	}
}

void inputFromTerminal(Graph& g)
{
	int V;
	cout << "Nhap so dinh: "; cin >> V;
	for (int i = 0; i < V; i++)
	{
		cout << "Nhap dinh " << i << ": "; cin >> VertexList[i];
	}
	bool thoat;
	int i = 0;
	do
	{
		char src, dest;
		Edge* e = new Edge();
		cout << "Nhap src cua canh " << i << ": "; cin >> src; e->src = (int)src;
		cout << "Nhap dest cua canh " << i << ": "; cin >> dest; e->dest = (int)dest;
		cout << "Nhap weight cua canh " << i << ": "; cin >> e->weight;
		insertLast(g.edge, e);

		cout << "Nhap tiep? (1/0): "; cin >> thoat;
	} while (thoat == 1);
}

void outputGraph(Graph& g)
{
	Edge* tmp = g.edge;
	while (tmp != NULL)
	{
		cout << "(" << (char)tmp->src << ", " << (char)tmp->dest << ", " << tmp->weight << ")\n";
		tmp = tmp->next;
	}
}

struct Node {
	int vertex;
	Node* next;

	Node(int _vertex)
	{
		vertex = _vertex;
		next = NULL;
	}
};

Node* queue;
Node* stack;

void initQueue() {
	queue = NULL;
}

void initStack()
{
	stack = NULL;
}

void enqueue(int vertex)
{
	if (queue == NULL)
		queue = new Node(vertex);
	else
	{
		Node* temp = queue;
		while (temp->next != NULL)
		{
			temp = temp->next;
		}
		temp->next = new Node(vertex);
	}
}

int dequeue()
{
	if (queue != NULL)
	{
		Node* tmp = queue;
		queue = queue->next;
		int val = tmp->vertex;
		delete tmp;
		tmp = nullptr;
		return val;
	}
}

void push(int vertex)
{
	if (stack == NULL)
		stack = new Node(vertex);
	else
	{
		Node* newNode = new Node(vertex);
		newNode->next = stack;
		stack = newNode;
	}
}

int pop()
{
	if (stack != NULL)
	{
		Node* tmp = stack;
		stack = stack->next;
		int val = tmp->vertex;
		delete tmp;
		tmp = nullptr;
		return val;
	}
}

int visited[MAX];
void BFS(Graph& g, int src)
{
	for (int i = 0; i < g.V; i++)
		visited[i] = 0;

	enqueue(src);
	while (queue != NULL)
	{
		int popped = dequeue();
		visited[popped - 65] = 1;
		cout << (char)popped << " ";
		Edge* curr = g.edge; //find neighbours
		while (curr != NULL)
		{
			if (curr->src == popped and visited[curr->dest - 65] == 0)
			{
				enqueue(curr->dest);
			}
			curr = curr->next;
		}
	}
}
void DFS(Graph& g, int src)
{
	for (int i = 0; i < g.V; i++)
		visited[i] = 0;

	push(src);
	visited[src] = 1;
	cout << (char)src << " ";
	int u = src;
	Edge* curr = NULL;

	while (stack != nullptr)
	{
		if (curr == NULL)
		{
			u = pop();
		}

		curr = g.edge; //find neighbours
		while (curr != NULL)
		{
			if (curr->src == u && visited[curr->dest - 65] == 0)
			{
				push(curr->dest);
				push(u);
				visited[curr->dest - 65] = 1;
				cout << (char)curr->dest << " ";
				u = curr->dest;
				break;
			}
			curr = curr->next;
		}
	}
}
//int countComponent(Graph& g)
//{
//	for (int i = 0; i < g.V; i++)
//		visited[i] = 0;
//
//	int count = 0; //segment count
//	for (int i = 0; i < g.V; i++) 
//		if (!visited[i])
//		{
//			count++;
//			DFS(g, i + 65);
//		}
//	return count;
//}

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

void BellmanFord(Graph& g, int src) {
	initBell();
	dist[src - 65] = 0;
	Edge* curr; //find neighbours

	for (int i = 0; i < g.V - 1; i++)
	{
		curr = g.edge; //find neighbours
		while (curr != NULL)
		{
			if (dist[curr->src - 65] != INT_MAX && dist[curr->dest - 65] > (dist[curr->src - 65] + curr->weight))
			{
				dist[curr->dest - 65] = dist[curr->src - 65] + curr->weight;
				previous[curr->dest - 65] = curr->src - 65;
			}
			curr = curr->next;
		}

	}
	
	for (int i = 0; i < g.V - 1; i++)
	{
		curr = g.edge;
		while (curr != NULL)
		{
			if (dist[curr->src - 65] != INT_MAX && dist[curr->dest - 65] > (dist[curr->src - 65] + curr->weight))
			{
				dist[curr->dest - 65] = INT_MAX;
				previous[curr->dest - 65] = -1;
				cout << "Graph contains negative weight cycle" << endl;
				return;
			}
			curr = curr->next;
		}

	}

	cout << "Vertex: \t\t";
	for (int i = 0; i < g.V; i++)
		cout << setw(20) << left << VertexList[i];
	cout << "\nDistance From source: \t";
	for (int i = 0; i < g.V; i++)
		cout << setw(20) << left << dist[i];
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

void Dijkstra(Graph& g, int src)
{
	dist[src - 65] = 0;
	bool Tset[MAX]; //visited array

	for (int i = 0; i < g.V; i++)
	{
		dist[i] = INT_MAX;
		Tset[i] = false;
	}

	dist[src - 65] = 0;

	//priority queue is replaced with minimumDist() and dist[]
	for (int i = 0; i < g.V; i++)
	{
		int m = minimumDist(dist, Tset) + 65;
		Tset[m - 65] = true;

		Edge* curr = g.edge; //find neighbours
		while (curr != NULL)
		{
			if (dist[curr->src - 65] != INT_MAX && dist[curr->dest - 65] > (dist[curr->src - 65] + curr->weight))
			{
				dist[curr->dest - 65] = dist[curr->src - 65] + curr->weight;
				previous[curr->dest - 65] = curr->src - 65;
			}
			curr = curr->next;
		}
	}

	cout << "Vertex\t\tDistance from source" << endl;
	for (int i = 0; i < g.V; i++)
	{
		cout << VertexList[i] << "\t\t\t" << dist[i] << endl;
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

void TaoE(Graph& g)
{
	Edge* curr = g.edge; //find neighbours
	while (curr != NULL)
	{
		E1[nE] = curr->src;
		E2[nE] = curr->dest;
		wE[nE] = curr->weight;
		nE++;
		curr = curr->next;
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

void Swap(int& a, int& b)
{
	int temp = a;
	a = b;
	b = temp;
}

void SapXepE()
{
	for (int i = 0; i < nE - 1; i++)
	{
		for (int j = 1 + 1; j < nE; j++)
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

void kruskal(Graph& g) //not sure
{
	for (int i = 0; i < nE; i++)
	{
		if (TonTai(E1[i], T1, nT) == 1 && TonTai(E2[i], T2, nT) == 1)
			continue;
		if (TonTai(E1[i], T2, nT) == 1 && TonTai(E2[i], T1, nT) == 1)
			continue;
		T1[nT] = E1[i];
		T2[nT] = E2[i];
		wT[nT] = wE[i];
		nT++;
		if (nT == g.V - 1)
			break;
	}
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
	for (int i = 0; i < nE; i++)
		if (E1[i] == u && E2[i] == v)
		{
			XoaViTriE(i);
			break;
		}
}

void prim(Graph& g, int src) //not sure
{
	int u = src, min, i, d1, d2;

	while (nT < g.V - 1)
	{
		Edge* curr = g.edge; //find neighbours
		while (curr != NULL)
		{
			if (curr->src == u && TonTai(curr->dest, T2, nT) == 0)
			{
				E1[nE] = u;
				E2[nE] = curr->dest;
				wE[nE] = curr->weight;
				nE++;
			}
			curr = curr->next;
		}
				

		for (i = 0; i < nE; i++)
			if (TonTai(E2[i], T2, nT) == 0)
			{
				min = wE[i];
				d1 = E1[i];
				d2 = E2[i];
				break;
			}

		for (; i < nE; i++)
			if (TonTai(E2[i], T2, nT) == 0)
				if (min > wE[i])
				{
					min = wE[i];
					d1 = E1[i];
					d2 = E2[i];
				}

		T1[nT] = d1;
		T2[nT] = d2;
		curr = g.edge; //find neighbours
		while (curr != NULL)
		{
			if (curr->src == d1 && curr->dest == d2)
			{
				wT[nT] = curr->weight;
				break;
			}
			curr = curr->next;
		}

		curr = g.edge;
		while (curr != NULL)
		{
			if ((curr->src == d1 && curr->dest == d2) || (curr->src == d2 && curr->dest == d1))
			{
				curr->weight = 0;
			}
			curr = curr->next;
		}
		nT++;
		XoaCanhE(d1, d2);
		u = d2;
	}
}

void output(bool VertexName)
{
	int tong = 0;
	for (int i = 0; i < nT; i++)
	{
		if (VertexName)
			cout << endl << "(" << VertexList[T1[i] - 65] << "," << VertexList[T2[i] - 65] << ") = " << wT[i];
		else
			cout << endl << "(" << (char)T1[i] << "," << (char)T2[i] << ") = " << wT[i];
		tong += wT[i];
	}
	cout << "\n Tong = " << tong;
}

int main()
{
	Graph g;
	initGraph(g);
	inputGraphFromFile(g);
	
	nT = 0;
	TaoE(g);
	prim(g, 'A');
	cout << "Cay bao trum toi thieu voi Kruskal: " << endl;
	output(true);
	cout << endl;

	cin.get();
}