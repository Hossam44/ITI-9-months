#include <iostream>
#include<windows.h>
#include <conio.h>
#define NormalPen 0x0F
#define HighLightPen 0xc0
using namespace std;

void gotoxy( int column, int line ){
  COORD coord;
  coord.X = column;
  coord.Y = line;
  SetConsoleCursorPosition(
    GetStdHandle( STD_OUTPUT_HANDLE ),
    coord
    );
}
void textattr (int i){
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), i);
}
void Print_small_trinagle(int x,int y){     //45   8


    gotoxy(x,y);
    printf("%c",201);
    for(int i=0;i<2;i++)
    {
        gotoxy(x,y+1+i);
        printf("%c",186);
    }
    gotoxy(x,y+2);
    printf("%c",200);

    //first row =
    for(int i=0;i<19;i++)
    {
        gotoxy(x+1+i,y);
        printf("%c",205);
    }
    //last row =
    for(int i=0;i<19;i++)
    {
        gotoxy(x+1+i,y+2);
        printf("%c",205);
    }


    gotoxy(x+20,y);
    printf("%c",187);
    for(int i=0;i<1;i++)
    {
        gotoxy(x+20,y+1+i);
        printf("%c",186);
    }
    gotoxy(x+20,y+2);
    printf("%c",188);
    gotoxy(0,23);

}

void print_main_trinagle(){

    //first col =
    gotoxy(40,2);
    printf("%c",201);
    for(int i=0;i<21;i++)
    {
        gotoxy(40,3+i);
        printf("%c",186);
    }
    gotoxy(40,24);
    printf("%c",200);

    //first row =
    for(int i=0;i<30;i++)
    {
        gotoxy(41+i,2);
        printf("%c",205);
    }
    //last row =
    for(int i=0;i<30;i++)
    {
        gotoxy(41+i,24);
        printf("%c",205);
    }


    gotoxy(70,2);
    printf("%c",187);
    for(int i=0;i<21;i++)
    {
        gotoxy(70,3+i);
        printf("%c",186);
    }
    gotoxy(70,24);
    printf("%c",188);
    gotoxy(0,0);

}
void print_data(int current){


    string words[5]={"En-Queue","DE-Queue","Peak","Count","Exit"};
    for(int i=0;i<5;i++)
    {
        if(i<2)
            gotoxy(52,5+(4*i));
        else
            gotoxy(53,5+(4*i));
        if(i==current)
        {
            textattr(HighLightPen);
        }
        else
        {
            textattr(8);
        }
        cout<<words[i];
        gotoxy(0,0);
    }
}
void view(int x,int y,int k){

    int m;
    system("cls");
    gotoxy(x,y);

    textattr(6);
    if(k==0)
        printf("Enter Your Number:");
    else
        printf("Your Number:");

    textattr(NormalPen);

    textattr(8);
    Print_small_trinagle(x+20,y-1);
    textattr(NormalPen);

    gotoxy(x+22,y);

}
void print_shape(int current){



        textattr(11);
        print_main_trinagle();
        Print_small_trinagle(45,4);
        Print_small_trinagle(45,8);
        Print_small_trinagle(45,12);
        Print_small_trinagle(45,16);
        Print_small_trinagle(45,20);
        print_data(current);
        textattr(NormalPen);

}

void Load_Bar(){





    char firstName[9]="LOADING ",LastName[9]="NOTEPAD ";
    /*                               print all colors
    gotoxy(40,2);
    for(int i=0;i<50;i++)
    {
        SetColor(i);
        printf("%c",254);
    }
    */


    int sm=254,bi=219;                 //small and big char for print
    printf("\n");
    //
    //1<----------------------------------->       For first "H"
    gotoxy(49,10);
    textattr(22);
    printf(" H ");
    textattr(NormalPen);


    textattr(97);                                  //For last H in the begging
    printf(" H ");
    textattr(NormalPen);
    //1<----------------------------------->

    //2<----------------------------------->       print Loading
    Sleep(80);
    gotoxy(52,10);
    printf(" ");
    for(int i=0;i<8;i++)
    {
        textattr(97);
        gotoxy(52+i+1,10);
        printf(" H ");
        Sleep(80);
        gotoxy(52+i+1,10);
        textattr(6);
        printf("%c",firstName[i]);
    }
    textattr(97);
    printf(" H ");
    Sleep(80);
    //2<----------------------------------->

    //3<----------------------------------->       print NotePAD
    gotoxy(98,10);
    textattr(NormalPen);
    printf(" ");
    for(int i=0;i<8;i++)
    {
        textattr(97);
        gotoxy(60+i+1,10);
        printf(" H ");
        Sleep(80);
        gotoxy(60+i+1,10);
        textattr(9);
        printf("%c",LastName[i]);
    }
    gotoxy(69,10);
    textattr(97);
    printf(" H ");
    textattr(NormalPen);
    //3<----------------------------------->

    {
    /*
        //2<----------------------------------->       Print The words
        textattr(6);
        printf(" LOADING");
        textattr(15);
        printf(" ");
        textattr(9);
        printf("NOTEPAD ");
        textattr(15);
        //2<----------------------------------->

        //3<----------------------------------->       For Last "H"
        textattr(97);
        printf(" H ");
        textattr(NormalPen);
        //3<----------------------------------->

    */
    }

    //4<------------------------------------>      first print
    gotoxy(20,12);
    textattr(8);
    for(int i=0;i<80;i++)
    {
        printf("%c",sm);
    }
    //4<----------------------------------->

    //5<------------------------------------>      overWrite in the print and restore it
    gotoxy(20,12);
    for(int i=0;i<80;i++)
    {
        textattr(9);
        printf("%c",bi);
        Sleep(40);
        gotoxy(20+i,12);
        textattr(6);
        printf("%c",sm);
        //textattr(NormalPen);
    }
    textattr(9);
    printf("%c",bi);
    textattr(NormalPen);

    textattr(9);
    Print_small_trinagle(50,15);
    textattr(NormalPen);

    gotoxy(54,16);
    textattr(97);
    printf("    START    ");
    textattr(NormalPen);
    gotoxy(0,0);

    getch();
    system("cls");
}

class Queue_v1
{
    int *num_element,first,last,counter_elm,len_Queue;
public:
    Queue_v1()
    {
        len_Queue=5;
        first = last = -1;
        counter_elm=0;
        num_element = new int[len_Queue];
    }
    Queue_v1(int len)
    {
        len_Queue=len;
        first = last = -1;
        counter_elm=0;
        num_element = new int[len_Queue];
    }
    int is_full()
    {
        return (counter_elm == len_Queue);
    }
    int Is_Empty()
    {
        return (counter_elm == 0);
    }
    void En_queue(int n)
    {
        if(!is_full())
        {
            num_element[(++last)%len_Queue]=n;
            counter_elm++;
        }
    }
    int De_queue()
    {

        if(!Is_Empty())
        {
            counter_elm--;
            return num_element[(++first)%len_Queue];
        }
        else
        {
            return -1;
        }
    }
    int Peak()
    {
        if(!Is_Empty())
        {
            return num_element[(first+1)%len_Queue];
        }
        else
        {
            return -1;
        }
    }
    int get_count()
    {
        return counter_elm;
    }
    ~Queue_v1()
    {
        delete []num_element;
    }
};
int main()
{

    Load_Bar();
    int i=0,m,ex=0;
    char ch;


    Queue_v1 q1(5);

    print_shape(i);

    do{
        ch=getch();
        gotoxy(0,0);
        switch(ch)
        {
        case 13:
            {
                gotoxy(0,0);
                switch(i)
                {
                case 0:
                    {
                        view(40,6,i);
                        textattr(3);
                        cin>>m;
                        textattr(NormalPen);
                        q1.En_queue(m);
                        system("cls");
                        print_shape(i);
                        break;
                    }
                case 1:
                    {
                        view(40,6,i);
                        textattr(3);
                        cout<<q1.De_queue();
                        textattr(NormalPen);
                        gotoxy(0,0);
                        getch();
                        system("cls");
                        print_shape(i);
                        break;
                    }
                case 2:
                    {
                        view(40,6,i);
                        textattr(3);
                        cout<<q1.Peak();
                        gotoxy(0,0);
                        getch();
                        system("cls");
                        print_shape(i);
                        break;
                    }
                case 3:
                    {
                        view(40,6,i);
                        textattr(3);
                        cout<<q1.get_count();
                        getch();
                        gotoxy(0,0);
                        getch();
                        system("cls");
                        print_shape(i);
                        textattr(NormalPen);

                        break;
                    }
                case 4:
                    {
                        textattr(NormalPen);
                        system("cls");
                        ex=1;
                        exit(0);
                        break;
                    }
                }
                break;
            }

            case 71:                            //home
                {
                    i=0;
                    print_data(i);
                    break;
                }
            case 79:                             //End
                {
                    i=4;
                    print_data(i);
                    break;
                }
            case 72:                             //up
                {
                    i--;
                    if(i==-1)
                        i=4;
                    print_data(i);
                    break;
                }
            case 80:                             //down
                {
                    i++;
                    if(i==5)
                        i=0;
                    print_data(i);
                    break;
                }
        }


}while(ex!=1);

    /*
    int n,m;
    Queue_v1 q1(5);

    cout<<"1-Enqueue"<<endl;
    cout<<"2-Dequeue"<<endl;
    cout<<"3-Do Peak"<<endl;
    cout<<"4-Count "<<endl;
    cout<<"5-Exit "<<endl;
    do
    {
        cout<<"Enter your option:";
        cin>>n;
        switch(n)
        {
        case 1:
            {
                cout<<"\nEnter Your Number :";
                cin>>m;
                cout<<endl;
                q1.En_queue(m);
                break;
            }
        case 2:
            {
                cout<<"\nThe Number :"<<q1.De_queue()<<endl<<endl;
                break;
            }
        case 3:
            {
                cout<<"\nNumber :"<<q1.Peak()<<endl<<endl;
                break;
            }
        case 4:
            {
                cout<<"count :"<<q1.get_count()<<endl;
                break;
            }
        default:
            {
                exit(0);
            }
        }
    }while(n!=0);
*/
    return 0;
}
