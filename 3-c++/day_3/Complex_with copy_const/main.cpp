#include <iostream>

using namespace std;

class Complex{
private:
    int real;
    int imaginary;
    static int i;

public:
    /**/

    Complex()
    {
        cout<<"object number:"<<++i<<"the adderess is :"<<this<<endl;
        real=0;
        imaginary=0;
    }

    Complex(Complex &temp)
    {cout<<this<<endl;
        cout<<"Object Number:"<<++i<<"The Adderess Is :"<<this<<endl;
        real=temp.real;
        imaginary=temp.imaginary;
    }

    int get_real()
    {
        return real;
    }
    int get_ima()
    {
        return imaginary;
    }
    void set_real(int _real)
    {
        real = _real;
    }
    void set_imaginary(int _imaginary)
    {
        imaginary = _imaginary;
    }
    void print()
    {
        if(real!=0 && imaginary>0  )
        cout<<real<<"+"<<imaginary<<"i"<<endl;
        else if(real!=0 && imaginary<0)
        cout<<real<<imaginary<<"i"<<endl;
        else if(real==0 && imaginary!=0)
        cout<<imaginary<<"i"<<endl;
        else if(real!=0 && imaginary==0)
        cout<<real<<endl;
        else
        cout<<"0"<<endl;
    }
/*
    Complex add(Complex &c1)
    {
        Complex result;
        result.real = real + c1.real;
        result.imaginary = imaginary + c1.imaginary;
        return result;
    }
    */

    Complex add(Complex c1)
    {
        Complex result;
        result.real = real + c1.real;
        result.imaginary = imaginary + c1.imaginary;
        return result;
    }

    Complex sub(Complex c1)
    {
        Complex result;
        result.real = real - c1.real;
        result.imaginary = imaginary - c1.imaginary;
        return result;
    }
    ~Complex()
    {
        //cout<<"\n"<<this<<endl;
        //cout<<"\nNubmer :"<<++i<<endl;
    }
};
int Complex::i = 0;

int main()
{
    Complex c1,c2,c3;
    c1.set_real(6);
    c1.set_imaginary(5);
    c2.set_real(4);
    c2.set_imaginary(3);
    c3=c1.add(c2);

    return 0;
}
