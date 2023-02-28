//Queue - Linked List

#include <iostream>
using namespace std;

struct Node
{
    int data;
    Node* next;

    Node(int x)
    {
        data = x;
        next = nullptr;
    }
};

class Queue
{
private:
    Node* front;
    Node* rear;
public:
    Queue()
    {
        front = nullptr;
        rear = nullptr;
    }
    bool empty()
    {
        if (front == NULL && rear == NULL)
        {
            return true;
        }
        return false;
    }
    void enQueue (int x)
    {
        if (empty())
        {
            Node* newNode = new Node(x);
            front = newNode;
            rear = newNode;
        }
        else
        {
            Node* newNode = new Node(x);
            rear->next = newNode;
            rear = newNode;
        }
    }
    void deQueue ()
    {
        if (!empty())
        {
            if (front == rear)
            {
                Node* temp = front;
                front = NULL;
                rear = NULL;
                delete temp;
            }
            else
            {
                Node* temp = front;
                front = front->next;
                delete temp;
            }
        }
        
    }
    int peek()
    {
        if (!empty())
        {
            return front->data;
        }
    }
    ~Queue()
    {
        while(!empty())
        {
            deQueue();
        }
    }
};
