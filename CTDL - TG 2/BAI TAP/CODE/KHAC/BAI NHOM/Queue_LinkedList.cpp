//#include <iostream>
//#include <ctime>
//#include <chrono>
//using namespace std;
//
////function that merges two lists into 1 sorted list.
////A must be sizeable enough to store L and R
//
////Queue - Linked List
//
//#include <iostream>
//using namespace std;
//
//struct Node
//{
//    int data;
//    Node* next;
//
//    Node(int x)
//    {
//        data = x;
//        next = nullptr;
//    }
//};
//
//class Queue
//{
//private:
//    Node* front;
//    Node* rear;
//public:
//    Queue()
//    {
//        front = nullptr;
//        rear = nullptr;
//    }
//    bool empty()
//    {
//        if (front == NULL && rear == NULL)
//        {
//            return true;
//        }
//        return false;
//    }
//    void enQueue (int x)
//    {
//        if (empty())
//        {
//            Node* newNode = new Node(x);
//            front = newNode;
//            rear = newNode;
//        }
//        else
//        {
//            Node* newNode = new Node(x);
//            rear->next = newNode;
//            rear = newNode;
//        }
//    }
//    void deQueue ()
//    {
//        if (!empty())
//        {
//            if (front == rear)
//            {
//                Node* temp = front;
//                front = NULL;
//                rear = NULL;
//                delete temp;
//            }
//            else
//            {
//                Node* temp = front;
//                front = front->next;
//                delete temp;
//            }
//        }
//        
//    }
//    int peek()
//    {
//        if (!empty())
//        {
//            return front->data;
//        }
//    }
//    void print()
//    {
//        if (front != NULL and rear != NULL)
//        {
//            Node* tmp = front;
//            while (tmp != NULL)
//            {
//                cout << tmp->data << " ";
//                tmp = tmp->next;
//            }
//        }
//    }
//    ~Queue()
//    {
//        while(!empty())
//        {
//            deQueue();
//        }
//    }
//};
//
//
//int main()
//{
//    int n = 1000;
//    Queue q;
//    srand(time(0));
//    chrono::steady_clock::time_point start = chrono::high_resolution_clock::now();
//       for (int i = 0; i < n; i++)
//       {
//            q.enQueue(i);
//       }
//    chrono::steady_clock::time_point end = chrono::high_resolution_clock::now();
//    q.print(); cout << endl;
//    chrono::duration<float> duration = end - start;
//    cout << "enqueue time: " << duration.count() * 1000 << "ms\n";
//
//    start = chrono::high_resolution_clock::now();
//    int val = q.peek();
//    end = chrono::high_resolution_clock::now();
//    cout << "front of queue: " << val << "\n";
//    duration = end - start;
//    cout << "peek time: " << duration.count() * 1000 << "ms\n";
//
//    start = chrono::high_resolution_clock::now();
//    while (q.empty() == false)
//        q.deQueue();    
//    end = chrono::high_resolution_clock::now();
//    duration = end - start;
//    cout << "dequeue time: " << duration.count() * 1000 << "ms\n";
//}