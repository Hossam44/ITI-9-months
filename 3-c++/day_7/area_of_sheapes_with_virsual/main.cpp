#include <iostream>

using namespace std;

class shape
{
protected:
    double dim1;
public:
    shape()
    {
        dim1=0;
    }
    shape(double _dim)
    {
        dim1=_dim;
    }

    virtual void set_dim1(double _dim1)
    {
        dim1=_dim1;
    }
    virtual void set_dim2(double _dim1)
    {
        dim1=_dim1;
    }
    virtual void set_dim3(double _dim1)
    {}
    virtual double get_dim1()
    {
        return dim1;
    }
    virtual double get_dim2()
    {
        return 0;
    }
    virtual double get_dim3()
    {
        return 0;
    }
    virtual double area()=0;
};

class Rect : public shape
{
    double dim2;
public:
    Rect():shape()
    {
        dim2=0;
    }
    Rect(double _dim1,double _dim2):shape(_dim1)
    {
        dim2 = _dim2;
    }

    void set_dim2(double _dim2)
    {
        dim2=_dim2;
    }
    double get_dim2()
    {
        return dim2;
    }
    double area()
    {
        return dim1*dim2;
    }
};

class square : public shape
{
public:
    square():shape()
    {}
    square(double _dim1):shape(_dim1)
    {}
    double area()
    {
        return dim1*dim1;
    }
};

class trin : public shape
{
private:
    double dim2,dim3;
public:
    trin():shape()
    {
        dim3=0;
    }
    trin(double _dim1):shape(_dim1)
    {
        dim3=_dim1;
    }
    trin(double _dim1,double _dim2,double _dim3):shape(_dim1)
    {
        dim2=_dim2;
        dim3=_dim3;
    }
    void set_dim2(double _dim2)
    {
        dim2=_dim2;
    }
    void set_dim3(double _dim3)
    {
        dim3=_dim3;
    }
    double get_dim2()
    {
        return dim2;
    }
    double get_dim3()
    {
        return dim3;
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

class cirle : public shape
{
public:
    cirle():shape()
    {}
    cirle(double _dim1):shape(_dim1)
    {}
    double area()
    {
        return 3.14*dim1*dim1;
    }
};

double area_to_all_shapes(shape **arr, int Size)
{
    double result=0;
    for(int i=0;i<Size;i++)
    {
        result+=arr[i]->area();
    }
    return result;
}

int main()
{

    Rect R1[2] = {Rect(1,2),Rect(3,2)};
    square S1[2] = {square(2),square(2)};
    cirle C1[2] = {cirle(5),cirle(4)};
    trin T1[2] = {trin(1,2,3),trin(3,4,5)};

    shape *sh[8]={R1,&R1[1],S1,&S1[1],C1,&C1[1],T1,&T1[1]};
    cout<<"---------------------------------"<<endl;
    cout<<"Area Of ALL Shapes = "<<area_to_all_shapes(sh,8)<<endl;

    cout<<"---------------------------------"<<endl;

    return 0;
}
