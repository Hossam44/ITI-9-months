#include <iostream>

using namespace std;

struct emp
{
    int id,age;
    double salary,over_tm,tax;
    char name[100],address[100],Gen[100];
};

struct node
{
    emp n;
    node *next;
    node *prv;
};
node *start;
node *last;

node *new_node(emp Data)
{
    node *Pnew = new node();
    if(Pnew == nullptr)
    {
        exit(0);
    }
    Pnew->n = Data;
    Pnew->next = nullptr;
    Pnew->prv = nullptr;
    return Pnew;
}
void Add_Node(emp Data)
{
    node *Pnew=new_node(Data);
    if(start == nullptr)
    {
        start=last=Pnew;
    }
    else
    {
        last->next=Pnew;
        Pnew->prv=last;
        last = Pnew;
    }
}
void Display_All()
{
    node *temp = start;
    while(temp != nullptr)
    {
        cout<<(temp->n).id<<" ";
        temp = temp->next;
    }
}
node * Search(emp Data)
{
    node *temp = start;
    while(temp != nullptr)
    {
        if(temp->n.id == Data.id)
            break;
        temp = temp->next;
    }
    return temp;
}

void Delete(emp Data)
{
    node *temp = Search(Data);
    if(temp == nullptr)
    {
        cout<<"NOT Found"<<endl;
    }
    if(last == start )
    {
        start=last=nullptr;
    }
    else if(temp == start)
    {
        start = start->next;

        start->prv = nullptr;
    }
    else if(temp == last)
    {
        last = last->prv;
        last->next = nullptr;
    }
    else
    {
        temp->prv->next = temp->next;
        temp->next->prv = temp->prv;
    }
    delete temp;
}
int main()
{
    cout << "Hello world!" << endl;
    return 0;
}
