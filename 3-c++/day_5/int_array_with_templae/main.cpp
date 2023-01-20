#include <iostream>

using namespace std;
template<class my_type>
class int_array{
private:
    int Size;
    my_type *arr;
    static int i;
public:

    int_array()
    {
        Size=10;
        arr = new my_type[Size];
        i++;
    }
    int_array(int x)
    {
        Size=x;
        arr = new my_type[Size];
        i++;
    }
    int_array(int_array &temp)
    {
        Size=temp.Size;
        arr = new my_type[Size];
        for(int i=0;i<Size;i++)
        {
            arr[i]=temp.arr[i];
        }
        i++;
    }
    int_array& operator=(const int_array &temp )
    {
        Size=temp.Size;
        arr = new my_type[Size];
        for(int i=0;i<Size;i++)
        {
            arr[i]=temp.arr[i];
        }
        return *this;
    }
    my_type& operator[](int index)
    {
        if((index>=0)&&(index<Size))
            return arr[index];
        return arr[0];
    }
    void set_array_value(int index,my_type value )
    {
        if((index>=0)&&(index<Size))
            arr[index]=value;
    }
    /*
    my_type get_array_value(int index,my_type value )
    {
        if((index>=0)&&(index<Size))
            return arr[index];
    }
    */
    int get_Size()
    {
        return Size;
    }
    int get_num_of_objects()
    {
        return i;
    }
    ~int_array()
    {
        i--;
        delete []arr;
    }
};

template<class my_type>
int int_array<my_type>::i=0;
int main()
{
    int_array<int> arr_int(5);
    int_array<char> arr_char(5);

    cout<<"HeLLo in First Array INT"<<endl;
    for(int i=0;i<5;i++)
    {
        arr_int[i]=i;
        cout<<arr_int[i]<<" ";
    }
    cout<<"\n---------------------------"<<endl;
    cout<<"HeLLo in Second Array CHAR"<<endl;
    for(int i=0;i<5;i++)
    {
        arr_char[i]=char(97+i);
        cout<<arr_char[i]<<" ";
    }
    cout<<"\n---------------------------"<<endl;

    return 0;
}
