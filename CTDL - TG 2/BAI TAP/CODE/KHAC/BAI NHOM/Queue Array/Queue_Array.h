//Queue - Array

#include <iostream>
using namespace std;

class Queue
{
private: 
    static const int maxSize = 100;
    int queue[maxSize];
    int front, rear;
    bool created = false;
public:
    Queue()
    {
        front = -1;
        rear = -1;
        created = true;
    }
    bool empty()
    {
        if (created)
        {
            if (front == -1 && rear == -1)
            {
                return true;
            }
            return false;

        }
    }
    bool full()
    {
        if (created)
        {
            if ((rear + 1) % maxSize == front) //next element of rear is front
            {
                return true;
            }
            return false;

        }
    }
    void enQueue(int x)
    {
        if (created)
        {
            if (!full())
            {
                if (empty())
                {
                    front = rear = 0;
                    queue[rear] = x;
                }
                else
                {
                    rear = (rear + 1) % maxSize;
                    queue[rear] = x;

                }
            }

        }
    }
    void deQueue()
    {
        if (created)
        {
            if (!empty())
            {
                if (front == rear)
                {
                    front = -1;
                    rear = -1;
                }
                else
                {
                    front = (front + 1) % maxSize;
                }
            }

        }
    }
    int peek()
    {
        if (created)
        {
            if (front != -1 && rear != -1)
                return queue[front];

        }
    }
};
