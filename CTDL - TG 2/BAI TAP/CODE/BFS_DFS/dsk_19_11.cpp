//dtk
#include <iostream>
#include <string>
#include <fstream>	
#include <sstream>	
#define MAX 100
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

Node* First[MAX];
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



void insertLast(Node*& first, Node* p)
{
	if (first == NULL)
		first = p;
	else
	{
		Node* tmp = first;
		while (tmp->next != NULL)
		{
			tmp = tmp->next;
		}
		tmp->next = p;
	}
}
void initGraph()
{
	n = 0;
	for (int i = 0; i < MAX; i++)
		First[i] = NULL;
}
void inputGraphFromTxt()
{
	ifstream myfile("D:/OU 2ND YEAR/CTDL - TG 2/BAI TAP/CODE/12-11/12-11/dsk.txt");
	if (myfile.is_open())
	{
		string str;
		myfile >> n;
		for (int i = 0; i < n; i++)
			myfile >> vertex[i];
		
		myfile.ignore();
		int i = 0; 
		while (getline(myfile, str))
		{
			int u;
			istringstream sstr(str);
			while (sstr >> u)
			{
				insertLast(First[i], new Node(u));
			}
			i++;
		}
		myfile.close();
	}
}
void inputGraph()
{
	cout << "Nhap so nut trong do thi: "; cin >> n;
	for (int i = 0; i < n; i++)
	{
		cout << "Nhap ten cua nut: "; cin >> vertex[i]; cin.ignore();
		cout << "Nhap noi dung dong [" << i << "] (-1 neu muon thoat): \n";
		string str; int dinhke;
		getline(cin, str);
		istringstream sstream(str);
		while (sstream >> dinhke)
		{
			insertLast(First[i], new Node(dinhke));
		}
	}

}
void output(int a[], int n)
{
	for (int i = 0; i < n; i++)
	{
		cout << vertex[a[i]] << " ";
	}
}
void outputGraph()
{
	for (int i = 0; i < n; i++)
	{
		cout << "First[" << i << "] (" << vertex[i] << "): ";
		Node* tmp = First[i];
		while (tmp != NULL)
		{
			cout << tmp->info << " ";
			tmp = tmp->next;
		}
		cout << "\n";
	}
}

int C[MAX]; //visited array in DS page, any vertex (pointed by the index) that is processed will be marked as 0 (basically means "Unavailable")
int bfs[MAX]; //the array is a depiction of an order in which a vertex is processed
int nbfs = 0; //basically, the actual size of bfs

void initC()
{
	for (int i = 0; i < n; i++)
	{
		C[i] = 1;
	}
}
void BFS(int v)
{
	int p;
	Node* w;
	enqueue(v);
	C[v] = 0; //vertex v is visted
	while (front != NULL)
	{
		p = peekQ();
		dequeue();
		bfs[nbfs] = p;
		w = First[p];
		nbfs++;

		while (w != NULL)
		{
			if (C[w->info])
			{
				enqueue(w->info);
				C[w->info] = 0; //normally, this statement would be after the vertex is "processed",
			}
			w = w->next;
		}
	}
}

int dfs[MAX];
int ndfs = 0;
void DFS(int s)
{
	push(s);
	dfs[ndfs] = s;
	ndfs++;
	C[s] = 0;

	int u = s;
	Node* v = nullptr;
	while (sp != nullptr)
	{
		if (v == NULL)
		{
			u = peekS();
			pop();
		}
		v = First[u];
		while (v != NULL)
		{
			if (C[v->info] == 1)
			{
				push(u);
				push(v->info);
				dfs[ndfs] = v->info;
				ndfs++;
				C[v->info] = 0;
				u = v->info;
				break;
			}
			v = v->next;
		}
	}
}

void searchByBFS(char x, int v)
{
	int p;
	Node* w;
	enqueue(v);
	C[v] = 0;
	while (front != NULL)
	{
		p = peekQ();
		dequeue();
		if (x == vertex[p] )
		{
			cout << "Tim thay x = " << vertex[p] << endl;
			return;
		}
		w = First[p];
		while (w != NULL)
		{
			if (C[w->info])
			{
				enqueue(w->info);
				C[w->info] = 0;
			}
			w = w->next;
		}
	}
	cout << "Khong tim thay " << x << "\n";
}

void searchByDFS(char x, int s)
{
	push(s);
	dfs[ndfs] = s;
	ndfs++;
	C[s] = 0;

	int u = s;
	Node* v = nullptr;
	while (sp != nullptr)
	{
		if (v == NULL)
		{
			u = peekS();
			pop();

			if (x == vertex[u])
			{
				cout << "Tim thay x = " << vertex[u] << endl;
				return;
			}
		}
		v = First[u];
		while (v != NULL)
		{
			if (C[v->info] == 1)
			{
				push(u);
				push(v->info);
				dfs[ndfs] = v->info;
				ndfs++;
				C[v->info] = 0;
				u = v->info;
				break;
			}
			v = v->next;
		}
	}
}

int main()
{
	int chon, x;
	char letter;
	cout << "1. Nhap tu file" << endl;
	cout << "2. BFS" << endl;
	cout << "3. DFS" << endl;
	cout << "4. Search by BFS: " << endl;
	cout << "5. Search by DFS: " << endl;
	cout << "6. Nhap tay" << endl;
	cout << "7. Xuat do thi" << endl;

	do
	{
		cout << "Chon: ";  cin >> chon;
		switch (chon)
		{
		case 1:
			inputGraphFromTxt();
			break;
		case 2:
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
		case 3:
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
		case 4:
			initQueue();
			initC();
			nbfs = 0;
			cout << "Vui long nhap dinh can tim: ";
			cin >> letter;
			searchByBFS(letter, 0);
			cout << "\n";

			break;
		case 5:
			initQueue();
			initC();
			nbfs = 0;
			cout << "Vui long nhap dinh can tim: ";
			cin >> letter;
			searchByDFS(letter, 0);
			cout << "\n";

			break;
		case 6:
			inputGraph();
			break;
		case 7:
			outputGraph();
			break;
		default:
			break;
		}

	} while (chon >= 1 && chon <= 7);

	cin.get();
}