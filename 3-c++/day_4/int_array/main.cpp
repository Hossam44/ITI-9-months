#include <iostream>

using namespace std;
class int_array{
private:
    int Size;
    int *arr;
public:
    /**/

    int_array()
    {
        Size=10;
        arr = new int[Size];
    }
    int_array(int x)
    {
        Size=x;
        arr = new int[Size];
    }
    int_array(int_array &temp)
    {
        Size=temp.Size;
        arr = new int[Size];
        for(int i=0;i<Size;i++)
        {
            arr[i]=temp.arr[i];
        }
    }
    int_array& operator=(const int_array &temp )
    {
        Size=temp.Size;
        arr = new int[Size];
        for(int i=0;i<Size;i++)
        {
            arr[i]=temp.arr[i];
        }
        return *this;
    }
    int& operator[](int index)
    {
        if((index>=0)&&(index<Size))
            return arr[index];
        return arr[0];
    }
    void set_array_value(int index,int value )
    {
        if((index>=0)&&(index<Size))
            arr[index]=value;
    }
    int get_array_value(int index,int value )
    {
        if((index>=0)&&(index<Size))
            return arr[index];
    }
    int get_Size()
    {
        return Size;
    }

    ~int_array()
    {
        delete []arr;
    }
};
int main()
{
    int_array arr(5);

    for(int i=0;i<5;i++)
    {
        arr[i]=i;
        cout<<arr[i]<<" ";
    }
    return 0;
}
