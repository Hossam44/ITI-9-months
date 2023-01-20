
#include <iostream>
#include "C:\Program Files (x86)\CodeBlocks\MinGW\include\graphics.h"
#include <conio.h>

using namespace std;

/// ------------------------------- Class Point ------------------------------------- ///
class Point
{
    int x, y;
public:

    Point()
    {
        x=y=0;
    }
    Point (int _x, int _y)
    {
        x = _x;
        y = _y;
    }
    int GetX()
    {
        return x;
    }
    int GetY()
    {
        return y;
    }
    void SetX(int _x)
    {
        x = _x;
    }
    void SetY(int _y)
    {
        y = _y;
    }
    void Show()
    {
        cout << "(" << x  << "," << y << ")\n";
    }


};

/// ------------------------------- Class Rectangle ------------------------------------- ///

class Rect
{
    Point UL;
    Point LR;
    int color;

public:

     // Constructor and Destructor ...
    Rect()
    :UL(),LR()
    {
        int color = 0;
    }
    Rect(int x1, int y1, int x2, int y2, int c)
    :UL(x1,y1),LR(x2,y2)
    {
        color = c;
    }
    void Draw()
    {
        int heigh,wiedth;
        setcolor(0);
        rectangle(UL.GetX(), UL.GetY(), LR.GetX(), LR.GetY());
        setcolor(color);
        int i=0,j=0;
        while(1)//(UL.GetX()+i!=LR.GetX()-i)&&(UL.GetY()+j!=LR.GetY()-j))
        {
            if((UL.GetX()+i!=LR.GetX()-i))
            {
                i++;
            }
            if((UL.GetY()+j!=LR.GetY()-j) )
            {
                j++;
            }

            //cout<<UL.GetX()+i<<"  "<<LR.GetX()-i<<endl;

            rectangle(UL.GetX()+i, UL.GetY()+j, LR.GetX()-i, LR.GetY()-j);
            if(UL.GetX()+i+1==LR.GetX()-i || UL.GetY()+j==LR.GetY()-j)
                break;
            //cout<<"sdada"<<endl;
        }

    }
};


/// ------------------------------- Class Circle ------------------------------------- ///

class Circle
{
    Point Center ;
    int Raduis ;
    int color;

public:

     // Constructor and Destructor ...
    Circle():Center()
    {
        int Raduis = 0;
        int color = 0;
    }
    Circle(int x1, int y1, int rad , int col)
    :Center(x1,y1)
    {
        Raduis =rad;
        color = col;
    }

    void Draw()
    {
        setcolor(0);
        circle(Center.GetX(),Center.GetY(),Raduis);
        circle(Center.GetX(),Center.GetY(),Raduis-1);

        setcolor(color);
        for(int i=Raduis-2;i>=0;i--)
            circle(Center.GetX(),Center.GetY(),i);
    }
};


/// ------------------------------- Class Line ------------------------------------- ///

class Line
{
    Point Head ;
    Point Tail ;
    int color;

public:

    Line():Head(),Tail()
    {
        int color = 0;
    }
    Line(int x1, int y1, int x2 ,int y2, int col)
    : Head(x1,y1),Tail(x2,y2)

    {

        color = col;
    }

    void Draw()
    {
        setcolor(color);
        line(Head.GetX(),Head.GetY(),Tail.GetX(),Tail.GetY());
    }

};


/// ------------------------------- Class Triangle ------------------------------------- ///

class Triangle
{
    Point Left ;
    Point Right ;
    Point Upper;
    int color;

public:

     // Constructor and Destructor ...
    Triangle()
    {
        int color = 0;
        //cout << " Triangle Parameterless Constructor \n";
    }

    Triangle(int x1, int y1, int x2 ,int y2,int x3,int y3, int col)
    : Left(x1,y1),Right(x2,y2),Upper(x3,y3)
    {
        color = col;
    }

    void Draw()
    {
        setcolor(4);
        for(int i=0;i<160;i++)
        {
            line(Left.GetX()+i,Left.GetY(),Right.GetX(),Right.GetY()+i);            //left
            //line(Left.GetX()+i,Left.GetY()-i,Upper.GetX()-i,Upper.GetY()-i);              //down
            line(Right.GetX(),Right.GetY()+i,Upper.GetX()-i,Upper.GetY());                  //right

        }
    }

};



int main()
{
    initgraph();






    Rect R1(300,230,781,528,13);
    R1.Draw();
    Rect R2(700,120,781,230,13);
    R2.Draw();

    Rect R3(670,100,811,120,6);
    R3.Draw();

    Triangle T1(265,230,540,70,816,230,30);
    T1.Draw();
    Rect door(490,350,590,528,4);
    door.Draw();


    Rect door_down(450,518,630,540,13);
    door_down.Draw();

    Rect window1(630,280,740,380,4);
    window1.Draw();
    Rect window2(340,280,450,380,4);
    window2.Draw();

    Rect window_slide1(392,280,400,380,30);
    window_slide1.Draw();
    Rect window_slide2(340,325,450,333,30);
    window_slide2.Draw();

    Rect window_slide3(683,280,691,380,30);
    window_slide3.Draw();
    Rect window_slide4(630,325,740,333,30);
    window_slide4.Draw();


    Rect window_down1(610,378,760,400,6);
    window_down1.Draw();
    Rect window_down2(320,378,470,400,6);
    window_down2.Draw();


    Circle C1(505,430,12,6);
    C1.Draw();
    //Circle C2(358,119,20,20);
    //C2.Draw();

    //Line L1(331,317,331,230,3);
    //L1.Draw();

    //Line L2(387,317,387,230,3);
    //L2.Draw();

    //Line L3(387,188,367,117,3);
    //L3.Draw();

    //Line L4(325,194,348,117,3);
    //L4.Draw();


    getch();
    system("cls");

    //line(200, 200, 300, 300);
    //circle(300, 300, 50);
    //line(110,120,130,120);
    //line(110,120,115,140);
    //line(130,120,115,140);

    return 0;
}
