void dem (int dinh)
{
    //tim dinh
    node* dnode;
    int i;
    for (i = 0; i < n; i++)
    {
        if (first[i]->dinh == dinh)
        {
            dnode = first[i];
            break;
        }
    }
    if (i == n) return;

    //dem 
    int count = 0;
    node* nnode = dnode;
    while (nnode != nullptr)
    {
        count++;
        nnode = nnode->next;
    }

    cout << "So dinh ke cua " << dinh << ": " --count << "\n";
}