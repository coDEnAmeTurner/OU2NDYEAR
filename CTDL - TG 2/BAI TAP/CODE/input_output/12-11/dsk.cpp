//dtk
#include <iostream>
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
	ifstream myfile("dsk.txt");
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
		int dinhke;
		cout << "Nhap ten cua nut: "; cin >> vertex[i];
		cout << "Nhap noi dung dong [" << i << "] (-1 neu muon thoat): \n";
		do 
		{
			cin >> dinhke;
			if (dinhke != -1)
				insertLast(First[i], new Node(dinhke));
		} while (dinhke != -1);
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

int main()
{
	inputGraphFromTxt();
	outputGraph();

	cin.get();
}