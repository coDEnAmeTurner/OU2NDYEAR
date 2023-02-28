////the so - called merge sort
//#include <iostream>
//#include <ctime>
//#include <chrono>
//using namespace std;
//
////function that merges two lists into 1 sorted list.
////A must be sizeable enough to store L and R
////Queue - Array
//
//#include <iostream>
//using namespace std;
//
//class Queue
//{
//private: 
//    static const int maxSize = 1000;
//    int queue[maxSize];
//    int front, rear;
//    bool created = false;
//public:
//    Queue()
//    {
//        front = -1;
//        rear = -1;
//        created = true;
//    }
//    bool empty()
//    {
//        if (created)
//        {
//            if (front == -1 && rear == -1)
//            {
//                return true;
//            }
//            return false;
//
//        }
//    }
//    bool full()
//    {
//        if (created)
//        {
//            if ((rear + 1) % maxSize == front) //next element of rear is front
//            {
//                return true;
//            }
//            return false;
//
//        }
//    }
//    void enQueue(int x)
//    {
//        if (created)
//        {
//            if (!full())
//            {
//                if (empty())
//                {
//                    front = rear = 0;
//                    queue[rear] = x;
//                }
//                else
//                {
//                    rear = (rear + 1) % maxSize;
//                    queue[rear] = x;
//
//                }
//            }
//
//        }
//    }
//    void deQueue()
//    {
//        if (created)
//        {
//            if (!empty())
//            {
//                if (front == rear)
//                {
//                    front = -1;
//                    rear = -1;
//                }
//                else
//                {
//                    front = (front + 1) % maxSize;
//                }
//            }
//
//        }
//    }
//    void print()
//    {
//        if (created)
//        {
//            for (int i = front; i <= rear; i++)
//                cout << queue[i] << " ";
//        }
//    }
//    int peek()
//    {
//        if (created)
//        {
//            if (front != -1 && rear != -1)
//                return queue[front];
//
//        }
//    }
//};
//
//
//int main()
//{
//    int n = 1000;
//   Queue q;
//   chrono::steady_clock::time_point start = chrono::high_resolution_clock::now();
//   for (int i = 0; i < n; i++)
//   {
//        q.enQueue(i);
//   }
//   chrono::steady_clock::time_point end = chrono::high_resolution_clock::now();
//   chrono::duration<float> duration = end - start;
//   q.print(); cout << endl;
//   cout << "enqueue time: " << duration.count() * 1000 << "ms\n";
//
//
//   start = chrono::high_resolution_clock::now();
//   int val = q.peek();
//   end = chrono::high_resolution_clock::now();
//   cout << "front of queue: " << val << "\n";
//   duration = end - start;
//   cout << "peek time: " << duration.count() * 1000 << "ms\n";
//
//   start = chrono::high_resolution_clock::now();
//   while (!q.empty())
//   {
//        q.deQueue();
//   }
//   end = chrono::high_resolution_clock::now();
//   duration = end - start;
//   cout << "dequeue time: " << duration.count() * 1000 << "ms\n";
//}