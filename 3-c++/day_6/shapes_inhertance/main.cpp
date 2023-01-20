#include <iostream>

using namespace std;

class shape
{
protected:
    double dim1,dim2;
public:
    shape()
    {
        dim1=dim2=0;
    }
    shape(double _dim)
    {
        dim1=dim2=_dim;
    }
    shape(double _dim1,double _dim2)
    {
        dim1=_dim1;
        dim2=_dim2;
    }
    void set_dim1(double _dim1)
    {
        dim1=_dim1;
    }

    void set_dim2(double _dim2)
    {
        dim2=_dim2;
    }

    double get_first_dim()
    {
        return dim1;
    }
    double get_second_dim()
    {
        return dim2;
    }
};

class Rect : protected shape
{
public:
    Rect():shape()
    {}
    Rect(double _dim1,double _dim2):shape(_dim1,_dim2)
    {}

    void set_dim1(double _dim1)
    {
        dim1=_dim1;
    }
    void set_dim2(double _dim2)
    {
        dim2=_dim2;
    }

    double area()
    {
        return dim1*dim2;
    }
};

class square : protected shape
{
public:
    square():shape()
    {}
    square(double _dim1):shape(_dim1)
    {}
    void set_dim1(double _dim1)
    {
        dim1=_dim1;
        dim2=_dim1;
    }
    double area()
    {
        return dim1*dim2;
    }
};

class trin : protected shape
{
private:
    double dim3;
public:
    trin():shape()
    {
        dim3=0;
    }
    trin(double _dim1):shape(_dim1)
    {
        dim3=_dim1;
    }
    trin(double _dim1,double _dim2,double _dim3):shape(_dim1,_dim2)
    {
        dim3=_dim3;
    }
    void set_dim3(double _dim3)
    {
        dim3=_dim3;
    }
    void set_all_dim(double _dim1,double _dim2,double _dim3)
    {
        dim1=_dim1;
        dim2=_dim2;
        dim3=_dim3;
    }
    double area()
    {
        return .5*dim1*dim2;
    }
};

class cirle : protected shape
{
public:
    cirle():shape()
    {}
    cirle(double _dim1):shape(_dim1)
    {}
    void set_dim1(double _dim1)
    {
        dim1=_dim1;
        dim2=_dim1;
    }
    double area()
    {
        return 3.14*dim1*dim2;
    }
};
double area_to_all_shapes(Rect R1[], square S1[], cirle C1[],trin T1[])
{
    double result=0;
    for(int i=0;i<2;i++)
    {
        result+=R1[i].area();
    }
    for(int i=0;i<2;i++)
    {
        result+=S1[i].area();
    }
    for(int i=0;i<2;i++)
    {
        result+=C1[i].area();
    }
    for(int i=0;i<2;i++)
    {
        result+=T1[i].area();
    }
    return result;
}

int main()
{
    //Rect R1(2,4);
    //square s1(4);
    //cirle c1(2);
    //trin t1(2,2,2);
    Rect *R1 = new Rect[2];
    square *S1 = new square[2];
    cirle *C1 = new cirle[2];
    trin *T1 = new trin[2];

    R1[0].set_dim1(2);
    R1[0].set_dim2(4);

    R1[1].set_dim1(1);
    R1[1].set_dim2(2);

    S1[0].set_dim1(2);

    S1[1].set_dim1(4);

    C1[0].set_dim1(3);

    C1[1].set_dim1(5);

    T1[0].set_all_dim(1,2,3);
    T1[1].set_all_dim(4,5,6);

    cout<<"---------------------------------"<<endl;
    cout<<"Area Of ALL Shapes = "<<area_to_all_shapes(R1,S1,C1,T1)<<endl;

    cout<<"---------------------------------"<<endl;

    /*
    cout<<R1.area()<<endl;
    cout<<s1.area()<<endl;
    cout<<c1.area()<<endl;
    cout<<t1.area()<<endl;
*/
    return 0;
}
