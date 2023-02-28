#include <iostream>
#include <iomanip>
using namespace std;

#define NARRAY 7
#define NBUCKET 6
#define INTERVAL 10

struct Node {
	int data;
	Node* next;
	Node(int x)
	{
		data = x;
		next = NULL;
	}
};

void BucketSort(int arr[]);
struct Node* InsertionSort(struct Node* list);
void print(int arr[]);
void printBuckets(struct Node* list);
int getBucketIndex(int value);

void BucketSort(int arr[])
{
	int i, j;
	Node** buckets;
	buckets = new Node*[NBUCKET];

	for (i = 0; i < NBUCKET; i++)
	{
		buckets[i] = nullptr;
	}

	for (i = 0; i < NARRAY; i++)
	{
		Node* current;
		int pos = getBucketIndex(arr[i]);
		current = new Node(arr[i]);
		current->next = buckets[pos];
		buckets[pos] = current;
	}

	for (i = 0; i < NBUCKET; i++)
	{
		cout << "Bucket[" << i << "]: ";
		printBuckets(buckets[i]);
		cout << endl;
	}

	for (i = 0; i < NBUCKET; i++)
	{
		buckets[i] = InsertionSort(buckets[i]);
	}

	cout << "-----------------" << endl;
	cout << "Buckets after sorted" << endl;
	for (i = 0; i < NBUCKET; i++)
	{
		cout << "Bucket[" << i << "]: "; 
		printBuckets(buckets[i]);
		cout << endl;
	}

	for (j = 0, i = 0; i < NBUCKET; i++)
	{
		Node* node;
		node = buckets[i];
		while (node) {
			arr[j++] = node->data;
			node = node->next;
		}
	}

	for (i = 0; i < NBUCKET; i++)
	{
		Node* node;
		node = buckets[i];
		while (node) {
			Node* tmp;
			tmp = node;
			node = node->next;
			delete tmp;
		}
	}
	delete[] buckets;
	return;
}
struct Node* InsertionSort(struct Node* list)
{
	Node* k, *nodeList;
	if (list == 0 || list->next == 0) {
		return list;
	}
	nodeList = list;
	k = list->next;	
	nodeList->next = 0;
	while (k != 0)
	{
		Node* ptr;
		if (nodeList->data > k->data) {
			Node* tmp;
			tmp = k;
			k = k->next;
			tmp->next = nodeList;
			nodeList = tmp;
			continue;
		}

		for (ptr = nodeList; ptr->next != 0; ptr = ptr->next)
		{
			if (ptr->next->data > k->data)
				break;
		}

		if (ptr->next != 0)
		{
			Node* tmp;
			tmp = k;
			k = k->next;
			tmp->next = ptr->next;
			ptr->next = tmp;
			continue;
		}
		else {
			ptr->next = k;
			k = k->next;
			ptr->next->next = 0;
			continue;
		}
	}
	return nodeList;
}
void print(int arr[])
{
	int i;
	for (i = 0; i < NARRAY; i++)
	{
		cout << setw(3) << arr[i];
	}
	cout << endl;
}
void printBuckets(struct Node* list) {
	Node* cur = list;
	while (cur) {
		cout << setw(3) << cur->data;
		cur = cur->next;
	}
}
int getBucketIndex(int value) {
	return value / INTERVAL;
}

int main()
{
	int array[NARRAY] = { 42, 32, 33, 52, 37, 47, 51 };

	cout << "Initial array: " << endl;
	print(array);
	cout << "========================" << endl;

	BucketSort(array);
	cout << "------------------------" << endl;
	cout << "Sorted array: " << endl;
	print(array);

	cin.get();
}
