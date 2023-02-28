////dtk
////unfinished: haven't finished coding
//#include <iostream>
//#include <fstream>	
//#include <sstream>	
//#define MAX 100
//using namespace std;
//
//struct GNode
//{
//	int info; //neighbour
//	GNode* next;
//	int weight; //weight of edge to the neighbour
//
//	GNode(int x, int _weight)
//	{
//		info = x;
//		weight = _weight;
//		next = NULL;
//	}
//};
//struct Node
//{
//	int info;
//	Node* next;
//
//	Node(int x)
//	{
//		info = x;
//		next = NULL;
//	}
//};
//
//GNode* First[MAX];
//char vertex[MAX];
//int n;
//
//Node* front, *rear;
//Node* sp;
//
//void initStack()
//{
//	sp = nullptr;
//}
//void push(int x)
//{
//	if (sp == NULL)
//		sp = new Node(x);
//	else
//	{
//		Node* newNode = new Node(x);
//		newNode->next = sp;
//		sp = newNode;
//	}
//}
//void pop()
//{
//	if (sp == nullptr)
//		return;
//	else
//	{
//		Node* temp = sp;
//		sp = sp->next;
//		delete temp;
//	}
//}
//int peekS()
//{
//	if (sp != NULL)
//		return sp->info;
//}
//
//
//void initQueue()
//{
//	front = nullptr;
//	rear = nullptr;
//}
//void enqueue(int x)
//{
//	if (front == NULL && rear == NULL)
//	{
//		front = new Node(x);
//		rear = front;
//	}
//	else
//	{
//		rear->next = new Node(x);
//		rear = rear->next;
//	}
//}
//void dequeue()
//{
//	if (front == NULL && rear == NULL)
//	{
//		return;
//	}
//	else
//	{
//		if (front == rear)
//		{
//			delete front;
//			front = nullptr;
//			rear = nullptr;
//		}
//		else
//		{
//			Node* temp = front;
//			front = front->next;
//			delete temp;
//			temp = nullptr;
//		}
//	}
//}
//int peekQ()
//{
//	if (front != NULL && rear != NULL)
//		return front->info;
//}
//
//void insertLast(GNode*& first, GNode* p)
//{
//	if (first == NULL)
//		first = p;
//	else
//	{
//		GNode* tmp = first;
//		while (tmp->next != NULL)
//		{
//			tmp = tmp->next;
//		}
//		tmp->next = p;
//	}
//}
//void initGraph()
//{
//	n = 0;
//	for (int i = 0; i < MAX; i++)
//		First[i] = NULL;
//}
//void inputGraphFromTxt()
//{
//	ifstream myfile("D:/OU 2ND YEAR/CTDL - TG 2/BAI TAP/CODE/26-11/mtts4.txt");
//	if (myfile.is_open())
//	{
//		string str;
//		myfile >> n;
//		for (int i = 0; i < n; i++)
//			myfile >> vertex[i];
//		
//		myfile.ignore();
//		int i = 0; 
//		while (getline(myfile, str))
//		{
//			int weight, j = 0; 
//			istringstream sstr(str);
//			while (sstr >> weight)
//			{
//				if (weight != 0)
//					insertLast(First[i], new GNode(j, weight));
//				j++;
//			}
//			i++;
//		}
//		myfile.close();
//	}
//}
//void inputGraph()
//{
//	cout << "Nhap so nut trong do thi: "; cin >> n;
//	for (int i = 0; i < n; i++)
//	{
//		int dinhke, weight;
//		cout << "Nhap ten cua nut: "; cin >> vertex[i];
//		cout << "Nhap noi dung dong [" << i << "] (-1 neu muon thoat): \n";
//		do 
//		{
//			cin >> dinhke;
//			cin >> weight;
//			if (dinhke != -1)
//				insertLast(First[i], new GNode(dinhke, weight));
//		} while (dinhke != -1);
//	}
//
//}
//void output(int a[], int n)
//{
//	for (int i = 0; i < n; i++)
//	{
//		cout << vertex[a[i]] << " ";
//	}
//}
//void outputGraph()
//{
//	for (int i = 0; i < n; i++)
//	{
//		cout << "First[" << i << "] (" << vertex[i] << "): ";
//		GNode* tmp = First[i];
//		while (tmp != NULL)
//		{
//			cout << tmp->info << " ";
//			tmp = tmp->next;
//		}
//		cout << "\n";
//	}
//}
//
//int C[100], bfs[100];
//int nbfs = 0;
//void initC()
//{
//	for (int i = 0; i < n; i++)
//	{
//		C[i] = 1;
//	}
//}
//void BFS(int v)
//{
//	int p;
//	GNode* w;
//	enqueue(v);
//	C[v] = 0;
//	while (front != NULL)
//	{
//		p = peekQ();
//		dequeue();
//
//		bfs[nbfs] = p;
//		nbfs++;
//
//		w = First[p];
//		while (w != NULL)
//		{
//			if (C[w->info])
//			{
//				enqueue(w->info);
//				C[w->info] = 0;
//			}
//			w = w->next;
//		}
//	}
//}
//
//int dfs[100];
//int ndfs = 0;
//void DFS(int s)
//{
//	push(s);
//	dfs[ndfs] = s;
//	ndfs++;
//	C[s] = 0;
//
//	int u = s;
//	GNode* v;
//	while (sp != nullptr)
//	{
//		v = First[u];
//		while (v != NULL)
//		{
//			if (C[v->info] == 1)
//			{
//				push(v->info);
//				push(u);
//				dfs[ndfs] = v->info;
//				ndfs++;
//				C[v->info] = 0;
//				u = v->info;
//				break;
//			}
//			v = v->next;
//		}
//
//		if (v == NULL)
//		{
//			u = peekS();
//			pop();
//		}
//	}
//}
//
//void searchByBFS(int x, int v)
//{
//	int p;
//	GNode* w;
//	enqueue(v);
//	C[v] = 0;
//	while (front != NULL)
//	{
//		p = peekQ();
//		dequeue();
//		if (x == p)
//		{
//			cout << "Tim thay x = " << x << endl;
//			return;
//		}
//		w = First[p];
//		while (w != NULL)
//		{
//			if (C[w->info])
//			{
//				enqueue(w->info);
//				C[w->info] = 0;
//			}
//			w = w->next;
//		}
//	}
//}
//
//int dist[MAX];
//int previous[MAX];
//void initBell()
//{
//	for (int i = 0; i < MAX; i++)
//	{
//		dist[i] = INT_MAX;
//		previous[i] = 0;
//	}
//
//}
//void BellmanFord(int src) {
//	dist[src] = 0;
//	for (int k = 0; k < n - 1; k++)
//	{
//			for (int j = 0; j < n; j++)
//			{
//				GNode* to = First[j];
//				while (to != NULL)
//				{
//					if (dist[j] != INT_MAX && dist[to->info] > dist[j] + to->weight)
//					{
//						dist[to->info] = dist[j] + to->weight;
//						previous[to->info] = j;
//					}
//					to = to->next;
//				}
//			}
//	}
//
//	for (int k = 0; k < n - 1; k++)
//	{
//			for (int j = 0; j < n; j++)
//			{
//				GNode* to = First[j];
//				while (to != NULL)
//				{
//					if (dist[j] != INT_MAX && dist[to->info] > dist[j] + to->weight)
//					{
//						dist[to->info] = INT_MAX;
//						previous[to->info] = -1;
//						cout << "Graph contains negative weight cycle" << endl;
//						return;
//					}
//					to = to->next;
//				}
//			}
//	}
//
//	cout << "Vertex: \t\t";
//	for (int i = 0; i < n; i++)
//		cout << vertex[i] << "\t";
//	cout << "\nDistance From source: \t";
//	for (int i = 0; i < n; i++)
//		cout << dist[i] << "\t";
//	cout << "\n";
//	return;
//}
//
//int main()
//{
//	int chon, x;
//	cout << "1. Nhap tu file" << endl;
//	cout << "2. BFS" << endl;
//	cout << "3. DFS" << endl;
//	cout << "4. Search by BFS: " << endl;
//	cout << "5. SSSP BellFord: " << endl;
//	do
//	{
//		cout << "Chon: ";  cin >> chon;
//		switch (chon)
//		{
//		case 1:
//			inputGraphFromTxt();
//			break;
//		case 2:
//			initQueue();
//			initC();
//			cout << "Vui long nhap dinh xuat phat: ";
//			cin >> x;
//			nbfs = 0;
//			BFS(x);
//			cout << "Thu tu dinh sau khi duyet BFS: ";
//			output(bfs, n);
//			cout << "\n";
//			break;
//		case 3:
//			initStack();
//			initC();
//			cout << "Vui long nhap dinh xuat phat: ";
//			cin >> x;
//			ndfs = 0;
//			DFS(x);
//			cout << "Thu tu dinh sau khi duyet DFS: " << endl;
//			output(dfs, n);
//			cout << "\n";
//
//			break;
//		case 4:
//			initQueue();
//			initC();
//			nbfs = 0;
//			cout << "Vui long nhap dinh can tim: ";
//			cin >> x;
//			searchByBFS(x, 0);
//			cout << "\n";
//
//			break;
//		case 5:
//			initBell();
//			cout << "Vui long nhap dinh bat dau: ";
//			cin >> x;
//			BellmanFord(x);
//			cout << "\n";
//
//			break;
//		default:
//			break;
//		}
//
//	} while (chon >= 1 && chon <= 4);
//
//	cin.get();
//}