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
    node *right;
    node *left;
};
node* Troot;

node* Search(node* proot,int k)
{
    if(proot!=nullptr)
    {
        if(proot->n.id==k)
            return proot;
        else if(proot->n.id>k)
        {
            Search(proot->left,k);
        }
        else
        {
            Search(proot->right,k);
        }
    }
    return nullptr;
}

int count_nodes(node* proot)
{
    if(proot!=nullptr)
    {
        return count_nodes(proot->left)+1+count_nodes(proot->right);
    }
    return 0;
}

void traverse(node *proot)
{
    if(proot!=nullptr)
    {
        traverse(proot->left);
        cout<<proot->n.id<<" ";
        traverse(proot->right);
    }
}

node *new_node()
{
    node *Pnew = new node();
    if(Pnew == nullptr)
    {
        exit(0);
    }
    //Pnew->n = Data;
    Pnew->right = nullptr;
    Pnew->left = nullptr;
    cout<<"Enter u Number :";
    cin>>Pnew->n.id;
    return Pnew;
}

void insert_(node* &proot,node * pnew)
{
    if(proot==nullptr)
        proot=pnew;
    else if(proot->n.id>pnew->n.id)
        insert_(proot->left,pnew);
    else
        insert_(proot->right,pnew);
}

void insert_(node* proot, node * leaf, node * pnew)
{
    if(leaf==nullptr)
    {
        if(proot==nullptr)
        {
            Troot=pnew;
        }
        else
        {
            if(proot->n.id > pnew->n.id)
                proot->left = pnew;
            else
                proot->right = pnew;
        }
    }
    else
    {
        if(leaf->n.id>pnew->n.id)
            insert_(leaf,leaf->left,pnew);
        else
            insert_(leaf,leaf->right,pnew);
    }
}

emp get_max(node* pmax)
{
    while(pmax->right!=nullptr)
        pmax = pmax->right;
    return pmax->n;
}
void Delete(node* &proot,int Data);
void Delete_Element(node* &proot)
{
    node *del = proot;
    if(proot->right == nullptr)
    {
        cout<<"hossam"<<endl;
        proot = proot->left;
        delete del;
    }
    else if(proot->left == nullptr)
    {
        proot = proot->right;
        delete del;
    }
    else
    {
        emp temp = get_max(proot->left);
        proot->n = temp;
        Delete(proot->left,temp.id);
    }

}
void Delete(node* &proot,int Data)
{
    if(proot != nullptr)
    {
        if(proot->n.id > Data)
            Delete(proot->left ,Data);
        else if(proot->n.id < Data)
            Delete(proot->right ,Data);
        else
            Delete_Element(proot);
    }
}

int main()
{
    for(int i=0;i<4;i++)
    {
        insert_(Troot,new_node());
    }
    traverse(Troot);
    cout<<endl<<count_nodes(Troot)<<endl;
    Delete(Troot,3);
    traverse(Troot);
    cout<<endl<<count_nodes(Troot)<<endl;

    Delete(Troot,3);
    traverse(Troot);
    cout<<endl<<count_nodes(Troot)<<endl;
    return 0;
}
