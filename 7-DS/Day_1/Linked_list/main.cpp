#include <iostream>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#include<windows.h>
#define NormalPen 0x0F
#define HighLightPen 0xc0
using namespace std;

struct emp
{
    int id,age;
    double salary,over_tm,tax;
    char name[100],address[100],Gen[100];
};
emp temp;
int emp_counter;

/*
int check_for_id(int id)
{
    for(int i=0;i<=100;i++)
    {
        if(e[i].id==id)
            return i+1;
    }
    return 0;
}
**/
///////////////////////////
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

    Pnew->n.id=Data.id;
    Pnew->n.age=Data.age;
    strcpy(Pnew->n.address,Data.address);
    strcpy(Pnew->n.Gen,Data.Gen);
    strcpy(Pnew->n.name,Data.name);
    Pnew->n.over_tm=Data.over_tm;
    Pnew->n.tax=Data.tax;
    Pnew->n.salary=Data.salary;

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
    node *tmp = start;
    while(tmp != nullptr)
    {
        cout<<(tmp->n).id<<" ";
        tmp = tmp->next;
    }
}
node * Search(int Data)
{
    node *tmp = start;
    while(tmp != nullptr)
    {
        if(tmp->n.id == Data)
            break;
        tmp = tmp->next;
    }
    return tmp;
}

void Delete_From_linked_listby_ID(int Emp_id)
{
    node *tmp = Search(Emp_id);
    if(tmp != nullptr)
    {
        emp_counter--;
        if(last == start )
        {
            start=last=nullptr;
        }
        else if(tmp == start)
        {
            start = start->next;

            start->prv = nullptr;
        }
        else if(tmp == last)
        {
            last = last->prv;
            last->next = nullptr;
        }
        else
        {
            tmp->prv->next = tmp->next;
            tmp->next->prv = tmp->prv;
        }
    }
    delete tmp;
}

/////////////////////////////
void set_data_in_array(emp temp)
{
    Delete_From_linked_listby_ID(temp.id);
    Add_Node(temp);
}

void textattr (int i){
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), i);
}

void gotoxy( int column, int line ){
  COORD coord;
  coord.X = column;
  coord.Y = line;
  SetConsoleCursorPosition(
    GetStdHandle( STD_OUTPUT_HANDLE ),
    coord
    );
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
    for(int i=0;i<23;i++)
    {
        gotoxy(40,3+i);
        printf("%c",186);
    }
    gotoxy(40,26);
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
        gotoxy(41+i,26);
        printf("%c",205);
    }


    gotoxy(70,2);
    printf("%c",187);
    for(int i=0;i<23;i++)
    {
        gotoxy(70,3+i);
        printf("%c",186);
    }
    gotoxy(70,26);
    printf("%c",188);
    gotoxy(0,0);

}

void print_last_trinagle(){
    //first col =
    gotoxy(20,5);
    printf("%c",201);
    for(int i=0;i<19;i++)
    {
        gotoxy(20,6+i);
        printf("%c",186);
    }
    gotoxy(20,25);
    printf("%c",200);

    //first row =
    for(int i=0;i<80;i++)
    {
        gotoxy(21+i,5);
        printf("%c",205);
    }
    //last row =
    for(int i=0;i<80;i++)
    {
        gotoxy(21+i,25);
        printf("%c",205);
    }


    gotoxy(100,5);
    printf("%c",187);
    for(int i=0;i<19;i++)
    {
        gotoxy(100,6+i);
        printf("%c",186);
    }
    gotoxy(100,25);
    printf("%c",188);
    gotoxy(0,23);

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
        Sleep(15);
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

void print_number_of_emplyee(int pi)
{
    gotoxy(pi+1,2);
    textattr(HighLightPen);
    printf(" Employee Data ");
    textattr(NormalPen);
    /*
    switch(i)
    {
    case 0:
        {
            textattr(HighLightPen);
            printf(" First Employee  ");
            textattr(NormalPen);
            break;
        }
    case 1:
        {
            gotoxy(pi,2);
            textattr(HighLightPen);
            printf(" Second Employee ");
            textattr(NormalPen);
            break;
        }
    case 2:
        {
            textattr(HighLightPen);
            printf(" Third Employee  ");
            textattr(NormalPen);
            break;
        }
    }
    */
}

void Draw_table_data(int option){
    system("cls");
    textattr(8);
    print_last_trinagle();
    Print_small_trinagle(50,1);                //Employee number
    Print_small_trinagle(35,8);                //id
    Print_small_trinagle(35,12);               //name
    Print_small_trinagle(35,16);               //salary
    Print_small_trinagle(35,20);               //adress
    Print_small_trinagle(75,8);                //Age
    Print_small_trinagle(75,12);               //Gen
    Print_small_trinagle(75,16);               //Tax
    Print_small_trinagle(75,20);               //OverT

    Print_small_trinagle(50,26);               //Back   or ok
    gotoxy(55,27);
    if(option==1)
    {
        printf("   Back    ");
    }
    else
    {
        printf("    OK     ");
        //char ch=getch();
    }
    print_number_of_emplyee(52);


    textattr(6);
    gotoxy(25,9);
    printf("ID     : ");
    gotoxy(25,13);
    printf("NAME   : ");
    gotoxy(25,17);
    printf("Salary : ");
    gotoxy(25,21);
    printf("Addres : ");
    gotoxy(64,9);
    printf("Age     : ");
    gotoxy(64,13);
    printf("Gen     : ");
    gotoxy(64,17);
    printf("Tax     : ");
    gotoxy(64,21);
    printf("over TM : ");

    gotoxy(0,0);
    textattr(NormalPen);

}

void error_rectanle(){
//first col =
    gotoxy(40,10);
    printf("%c",201);
    for(int i=0;i<1;i++)
    {
        gotoxy(40,11+i);
        printf("%c",186);
    }
    gotoxy(40,12);
    printf("%c",200);

    //first row =
    for(int i=0;i<40;i++)
    {
        gotoxy(41+i,10);
        printf("%c",205);
    }
    //last row =
    for(int i=0;i<40;i++)
    {
        gotoxy(41+i,12);
        printf("%c",205);
    }


    gotoxy(80,10);
    printf("%c",187);
    for(int i=0;i<1;i++)
    {
        gotoxy(80,11+i);
        printf("%c",186);
    }
    gotoxy(80,12);
    printf("%c",188);
    gotoxy(0,0);
}

void display_error_table_all_alements(){
    system("cls");
    textattr(8);
    error_rectanle();
    gotoxy(53,8);
    textattr(HighLightPen);
    printf("   WARNNING   ");
    textattr(NormalPen);

    gotoxy(47,11);
    textattr(6);
    printf(" **THIS ID ALREADY EXIST** ");
    textattr(NormalPen);

    gotoxy(28,14);
    textattr(8);
    printf("   RE-ENTER  ");

    gotoxy(53,14);
    printf("     BACK    ");

    gotoxy(78,14);
    printf("    CHANGE   ");

    textattr(NormalPen);

    textattr(8);
    Print_small_trinagle(50,7);    //WARNNING
    Print_small_trinagle(25,13);
    Print_small_trinagle(50,13);
    Print_small_trinagle(75,13);

}

char** Line_editor(int number_of_element,int *size,int *x_pos,int *y_pos,char *st,char *en)
{
    int lo=0,i=0;
    char **arr;

    arr = (char **)malloc(number_of_element*sizeof(char *));
    for(int j=0;j<number_of_element;j++){
        arr[j]=(char *)malloc(size[j]*sizeof(char));
    }
    char ch;

    int all_elment[8]={0},arrow[8]={0};

    do{
        gotoxy(arrow[i]+x_pos[i],y_pos[i]);

        ch=getch();
        gotoxy(0,0);

        if(ch>=st[i] && ch<=en[i] && all_elment[i] <= size[i]-2)
        {
            all_elment[i]++;
            gotoxy(0,0);
            for(int j=size[i]-2;j>arrow[i];j--)
            {
                char tempe = arr[i][j];
                arr[i][j]=arr[i][j-1];
                arr[i][j-1]=tempe;
            }

            arr[i][arrow[i]]=ch;
            if(arrow[i]<size[i]-2)
                arrow[i]++;
        }

        else if(ch==-32)
        {
            ch=getch();

            switch(ch)
            {
                case 71:                            //home
                    {
                        arrow[i]=0;
                        break;

                    }
                case 79:                             //End
                    {
                        arrow[i]=all_elment[i]-1;
                        break;
                    }
                case 77:                            //right
                    {
                        if(arrow[i]!=all_elment[i])
                            arrow[i]=arrow[i]+1;
                        break;
                    }
                case 75:                             //left
                    {
                        if(arrow[i] == 0)
                            arrow[i]=0;
                        else
                            arrow[i] = (arrow[i]+size[i]-2)%(size[i]-1);
                        break;
                    }
                case 72:                             //up
                    {
                        if(i == 0)
                            i=0;
                        else
                            i--;
                        //printf("left %d\n",arrow);

                        break;
                    }
                case 80:                             //down
                    {
                        if(i == 7)
                            i=7;
                        else
                            i++;
                        break;
                    }

            }
        }
        else if(ch==13)         //Enter
        {
            if(i==7)
                lo=1;
            arr[i][all_elment[i]]='\0';
            gotoxy(x_pos[i],y_pos[i]);
            textattr(3);
            for(int j=0;j<12;j++)
            {
                printf(" ");
            }
            gotoxy(x_pos[i],y_pos[i]);
            for(int j=0;j<all_elment[i];j++)
            {
                printf("%c",arr[i][j]);
            }
            i++;
        }
        else if(ch==8)         //backspace
        {
            if(all_elment[i]>0)
                all_elment[i]--;
            for(int j=arrow[i];j<=size[i]-2;j++)
            {
                char tempe = arr[i][j];
                arr[i][j]=arr[i][j-1];
                arr[i][j-1]=tempe;
            }
            arrow[i]--;
            if(arrow[i]==-1)
                arrow[i]=0;
        }

        gotoxy(x_pos[i],y_pos[i]);
        if(ch!=13){
            for(int j=0;j<12;j++)
            {
                printf(" ");
            }
            gotoxy(x_pos[i],y_pos[i]);
            for(int j=0;j<all_elment[i];j++)
            {
                if(j==arrow[i]){
                    textattr(HighLightPen);
                    printf("%c",arr[i][j]);
                    textattr(NormalPen);
                }
                else
                {
                    textattr(3);
                    printf("%c",arr[i][j]);
                    textattr(NormalPen);
                }
            }
        }

}while(!lo);
    return arr;
}

void scan_all_data()
{
    system("cls");
    Draw_table_data(0); //////////////////
    textattr(3);
    int size[]={8,12,4,12,3,2,12,12};
    int x_pos[]={37,37,37,37,77,77,77,77};
    int y_pos[]={9,13,17,21,9,13,17,21};
    char st[]={'1','a','1','a','1','a','1','1'};
    char en[]={'9','z','9','z','9','z','9','9'};
    char **arr = Line_editor(8,size,x_pos,y_pos,st,en);
    temp.id = atoi(arr[0]);
    strcpy(temp.name,arr[1]);
    temp.salary = atof(arr[2]);
    strcpy(temp.address,arr[3]);
    temp.age = atoi(arr[4]);
    strcpy(temp.Gen,arr[5]);
    temp.tax = atof(arr[6]);
    temp.over_tm = atof(arr[7]);

}

void Enter_Data()
{
    char ch,names[3][14]={"   RE-ENTER  ","     BACK    ","    CHANGE   "};
    int current_arrow=0,ex=1,f=1;
    do{
        ex=0;
        scan_all_data();
        gotoxy(55,27);
        textattr(HighLightPen);
        printf("    OK     ");
        textattr(NormalPen);
        gotoxy(0,0);
        if(Search(temp.id)!=nullptr)
        {
            f=0;
            getch();
            display_error_table_all_alements();
            do{

                for(int i=0;i<3;i++)
                {
                    if(current_arrow==i)
                    {
                        textattr(HighLightPen);
                    }
                    else
                    {
                        textattr(8);
                    }
                    gotoxy(28+(25*i),14);
                    printf("%s",names[i]);
                }
                textattr(NormalPen);

                gotoxy(0,0);
                ch=getch();
                switch(ch)
                {
                case 13:    //Enter
                    {
                        switch(current_arrow)
                        {
                            case 0:                         //New Enter DATA
                                {
                                    f=1;
                                    system("cls");
                                    ex=1;
                                    break;
                                }
                            case 1:                        //BACK
                                {
                                    system("cls");
                                    break;
                                }
                            case 2:                       //CHANGE
                                {
                                    textattr(NormalPen);
                                    system("cls");
                                    set_data_in_array(temp);
                                    emp_counter++;
                                    break;
                                }

                        }
                        break;
                    }
                case -32:
                    {
                        gotoxy(0,0);
                        ch=getch();
                        gotoxy(0,0);
                        switch(ch)
                        {

                            case 77:                            //right
                                {
                                    current_arrow=(current_arrow+1)%3;
                                    //print_small_content_info(current_arrow);
                                    break;
                                }
                            case 75:                             //left
                                {
                                    current_arrow=(current_arrow+2)%3;;
                                    //print_small_content_info(current);
                                    break;
                                }

                        }
                        break;
                    }
                }
            }while(ch!=13);

        }
        else
        {
            set_data_in_array(temp);
            emp_counter++;
        }
    }while(ex);
    gotoxy(0,0);
    if(f)
        ch = getch();

}

void diplay_data_of_i_emplyee_small_info(node* Dis)
{


    textattr(3);

    gotoxy(57,8);
    printf("    ");
    gotoxy(57,8);

    printf("%i",Dis->n.id);

    gotoxy(57,12);
    printf("              ");
    gotoxy(57,12);
    printf("%s",Dis->n.name);

    gotoxy(57,16);
    printf("        ");
    gotoxy(57,16);
    printf("%-10.2lf",(Dis->n.salary)+(Dis->n.over_tm)-(Dis->n.tax));
    gotoxy(0,0);
    textattr(NormalPen);
    gotoxy(48,2);
    print_number_of_emplyee(48);
    gotoxy(0,0);


}

void display_full_info(node *Dis)
{
    Draw_table_data(1);
    textattr(3);
    gotoxy(37,9);
    printf("%i",Dis->n.id);
    gotoxy(37,13);
    printf("%s",Dis->n.name);
    gotoxy(37,17);
    printf("%-10.2lf",Dis->n.salary);
    gotoxy(37,21);
    printf("%s",Dis->n.address);
    gotoxy(77,9);
    printf("%d",Dis->n.age);
    gotoxy(77,13);
    printf("%s",Dis->n.Gen);
    gotoxy(77,17);
    printf("%-10.2lf",Dis->n.tax);
    gotoxy(77,21);
    printf("%-10.2lf",Dis->n.over_tm);

    gotoxy(55,27);
    textattr(HighLightPen);
    printf("   Back    ");
    textattr(NormalPen);
    gotoxy(0,0);
}

void print_small_structure_info(int option){



    //first col =
    textattr(8);
    gotoxy(30,4);
    printf("%c",201);
    for(int i=0;i<16;i++)
    {
        gotoxy(30,5+i);
        printf("%c",186);
    }
    gotoxy(30,20);
    printf("%c",200);

    //first row =
    for(int i=0;i<50;i++)
    {
        gotoxy(31+i,4);
        printf("%c",205);
    }
    //last row =
    for(int i=0;i<50;i++)
    {
        gotoxy(31+i,20);
        printf("%c",205);
    }


    gotoxy(80,4);
    printf("%c",187);
    for(int i=0;i<16;i++)
    {
        gotoxy(80,5+i);
        printf("%c",186);
    }
    gotoxy(80,20);
    printf("%c",188);
    gotoxy(0,0);


    textattr(8);
    Print_small_trinagle(46,1);         //Emp name
    Print_small_trinagle(55,7);
    Print_small_trinagle(55,11);
    Print_small_trinagle(55,15);
    Print_small_trinagle(45,22);         //INFO
    Print_small_trinagle(45,26);         //END

    if(option==1){
    Print_small_trinagle(70,22);         //NEXT
    Print_small_trinagle(20,22);         //BACK
    }
}

void print_small_content_info(int current_arrow,int option){
    char names[4][14]={"     BACK    ","     INFO    ","     NEXT    ","     END     "};
    int X[4]={24,49,74,50};
    int Y[4]={23,23,23,27};

    textattr(6);
    if(option==1)
    {
        gotoxy(74,23);
        printf("     NEXT    ");

        gotoxy(24,23);
        printf("     BACK    ");
    }
    gotoxy(49,23);
    printf("     INFO    ");

    gotoxy(50,27);
    printf("     END     ");
    if(option==1){
        for(int i=0;i<4;i++)
        {
            if(current_arrow==i)
            {
                textattr(HighLightPen);
                gotoxy(X[i],Y[i]);
                printf("%s",names[i]);
                textattr(NormalPen);
            }
            else
            {
                textattr(NormalPen);
                gotoxy(X[i],Y[i]);
                printf("%s",names[i]);
            }
        }
    }
    else
    {

        if(current_arrow==0)
        {
            textattr(HighLightPen);
            gotoxy(X[1],Y[1]);
            printf("%s",names[1]);
            textattr(NormalPen);
            gotoxy(X[3],Y[3]);
            printf("%s",names[3]);
        }
        else
        {
            textattr(HighLightPen);
            gotoxy(X[3],Y[3]);
            printf("%s",names[3]);
            textattr(NormalPen);
            gotoxy(X[1],Y[1]);
            printf("%s",names[1]);
        }
    }
/*
    if(current_arrow==0){
        textattr(HighLightPen);
        gotoxy(24,23);
        printf("    BACK    ");
        textattr(NormalPen);
    }
    else if(current_arrow==1){
        textattr(HighLightPen);
        gotoxy(49,23);
        printf("     INFO    ");
        textattr(NormalPen);
    }
    else if(current_arrow==2)
    {
        textattr(HighLightPen);
        gotoxy(74,23);
        printf("     NEXT    ");
        textattr(NormalPen);
    }
    else
    {
        textattr(HighLightPen);
        gotoxy(50,27);
        printf("    END    ");
        textattr(NormalPen);
    }
    }
*/
    textattr(6);
    gotoxy(40,8);
    printf("ID      : ");
    gotoxy(40,12);
    printf("NAME    : ");
    gotoxy(40,16);
    printf("Net Sal : ");
    gotoxy(0,0);
    textattr(NormalPen);
}

void Show_Data_of_all_employee(){
    char ch,current=0,ex=1;

    node *i=start;                              //for first show after delete
    diplay_data_of_i_emplyee_small_info(i);
    print_small_structure_info(1);
    print_small_content_info(current,1);
    do{

        ch=getch();
        switch(ch)
        {
        case 13:
            {
                switch(current)
                {
                case 0:
                    {

                    /*
                        int found=0;
                        for(int k=i-1;k>=0;k--)
                        {
                            if(e[k].id!=-1)
                            {
                                i=k;
                                found=1;
                                break;
                            }
                        }
                        //found delete
                        if(!found){
                        for(int k=100;k>=i;k--)
                        {
                            if(e[k].id!=-1)
                            {
                                i=k;
                                break;
                            }
                        }
                        */
                        if(i->prv!=nullptr)
                            i=i->prv;
                        else
                            i=last;
                        diplay_data_of_i_emplyee_small_info(i);
                        break;
                    }
                case 1:
                    {
                        display_full_info(i);
                        ch=getch();
                        system("cls");
                        diplay_data_of_i_emplyee_small_info(i);
                        print_small_structure_info(1);
                        print_small_content_info(current,1);
                        break;
                    }
                case 2:
                    {
                        /*
                        int found=0;
                        for(int k=i+1;k<=100;k++)
                        {
                            if(e[k].id!=-1)
                            {
                                i=k;
                                found=1;
                                break;
                            }
                        }
                        if(!found){
                        for(int k=0;k<i;k++)
                        {
                            if(e[k].id!=-1)
                            {
                                i=k;
                                break;
                            }
                        }
                        }
                        */

                        if(i->next!=nullptr)
                            i=i->next;
                        else
                            i=start;
                        diplay_data_of_i_emplyee_small_info(i);
                        break;
                    }
                case 3:
                    {

                        ex=0;
                        break;
                    }
                }
                break;
            }


        case -32:
            {
                gotoxy(0,0);
                ch=getch();
                switch(ch)
                {
                case 72:                            //UP
                    {
                        current=1;
                        print_small_content_info(current,1);
                        break;
                    }
                case 80:                            //down
                    {
                        current=3;
                        print_small_content_info(current,1);
                        break;
                    }
                case 77:                            //right
                    {
                        current=(current+1)%4;
                        print_small_content_info(current,1);
                        break;
                    }
                case 75:                             //left
                    {
                        current=(current+3)%4;;
                        print_small_content_info(current,1);
                        break;
                    }
                }
                break;
            }

        }

    }while(ex);

}

void main_build_and_coloe_after_show()
{
    textattr(11);
    print_main_trinagle();
    Print_small_trinagle(45,3);
    Print_small_trinagle(45,7);
    Print_small_trinagle(45,11);
    Print_small_trinagle(45,15);
    Print_small_trinagle(45,19);
    Print_small_trinagle(45,23);

    textattr(NormalPen);
}

void not_found_data(int option)
{
    textattr(8);
    error_rectanle();
    Print_small_trinagle(50,7);
    gotoxy(53,8);
    textattr(HighLightPen);
    printf("   WARNNING   ");
    textattr(NormalPen);

    gotoxy(47,11);
    textattr(6);
    if(option==0)
    {
        printf(" **Please enter Data** ");
    }
    else
    {
        printf(" **    NOT FOUND    ** ");
    }
    textattr(NormalPen);
    gotoxy(0,0);
    getch();
}

void delete_by_id()
{
    int id;
    system("cls");
    textattr(8);
    Print_small_trinagle(54,4);               //for input id
    textattr(6);
    gotoxy(40,5);
    printf("Enter ID : ");
    textattr(11);
    gotoxy(56,5);
    scanf("%d",&id);
    system("cls");
    Delete_From_linked_listby_ID(id);

}

void delete_by_name()
{

    char name[100];
    system("cls");
    textattr(8);
    Print_small_trinagle(54,4);               //for input id
    textattr(6);
    gotoxy(38,5);
    printf("Enter Name : ");
    textattr(11);
    gotoxy(56,5);
    scanf("%s",name);
    system("cls");

    node *nod = start;
    while(nod != nullptr)
    {
        if(!strcmp(nod->n.name,name))
        {
            break;
        }
        nod=nod->next;
    }
    if(nod!=nullptr)
        Delete_From_linked_listby_ID(nod->n.id);
}

void Show_Data_by_id(){
    char ch;
    int current=0,ex=1,tem;
    node *i;
    system("cls");
    textattr(8);
    Print_small_trinagle(54,4);               //for input id
    textattr(6);
    gotoxy(40,5);
    printf("Enter ID : ");
    textattr(11);
    gotoxy(56,5);
    scanf("%d",&tem);
    system("cls");
    //check_for_id
    i=Search(tem);
    if(i==nullptr)
    {
        not_found_data(1);
    }
    else
    {
    diplay_data_of_i_emplyee_small_info(i);
    print_small_structure_info(0);
    print_small_content_info(current,0);
    do{

        ch=getch();
        switch(ch)
        {
        case 13:
            {
                switch(current)
                {
                case 0:
                    {
                        display_full_info(i);
                        ch=getch();
                        system("cls");
                        diplay_data_of_i_emplyee_small_info(i);
                        print_small_structure_info(0);
                        print_small_content_info(current,0);
                        break;
                    }
                case 1:
                    {
                        ex=0;
                        break;
                    }
                }
                break;
            }


        case -32:
            {
                gotoxy(0,0);
                ch=getch();
                switch(ch)
                {
                case 72:                            //UP
                    {
                        current=(current+1)%2;
                        print_small_content_info(current,0);
                        break;
                    }
                case 80:                            //down
                    {
                        current=(current+1)%2;
                        print_small_content_info(current,0);
                        break;
                    }
                case 77:                            //right
                    {
                        current=(current+1)%2;
                        print_small_content_info(current,0);
                        break;
                    }
                case 75:                             //left
                    {
                        current=(current+1)%2;
                        print_small_content_info(current,0);
                        break;
                    }
                }
                break;
            }

        }

    }while(ex);

}
}

int main()
{
    char words[7][14]={"     New     ","  SHOW BY ID ","   SHOW ALL  "," Delete BY ID"," Delete BY NM","     Exit    "},ch;
    int current=0,lo=1;
    Load_Bar();
    system("cls");


    main_build_and_coloe_after_show();

    do{

        for(int i=0;i<6;i++)
        {
            gotoxy(49,4+(4*i));
            if(i==current)
            {
                textattr(HighLightPen);
            }
            else
            {
                textattr(8);
            }
            printf("%s\n",words[i]);

        }
        gotoxy(0,23);
        ch=getch();
        switch(ch)
        {
        case 13:    //Enter
            {
                switch(current)
                {
                    case 0:                         //New Enter NAme
                        {

                            system("cls");
                            Enter_Data();
                            system("cls");
                            main_build_and_coloe_after_show();
                            break;

                        }
                    case 1:                        //Show BY ID if EXIST
                        {
                            system("cls");
                            Show_Data_by_id();
                            system("cls");
                            main_build_and_coloe_after_show();
                            break;
                        }
                    case 2:                       //Show ALL
                        {
                            system("cls");
                            if(emp_counter>0)
                            {
                                Show_Data_of_all_employee();
                            }
                            else
                                not_found_data(0);
                            system("cls");
                            main_build_and_coloe_after_show();
                            textattr(NormalPen);
                            break;
                        }

                    case 3:                         //Delete BY ID
                        {
                            system("cls");
                            delete_by_id();
                            system("cls");
                            main_build_and_coloe_after_show();
                            break;

                        }
                    case 4:                       //Delete BY NAme
                        {
                            system("cls");
                            delete_by_name();
                            system("cls");
                            main_build_and_coloe_after_show();
                            break;
                        }
                    case 5:                       //ExIT
                        {
                            textattr(NormalPen);
                            system("cls");
                            exit(0);
                            break;
                        }
                }
                break;
            }
        case 27:   // Exit
            {
                lo=0;
                system("cls");
                exit(0);
                break;
            }
        case -32:
            {
                gotoxy(0,23);
                ch=getch();
                switch(ch)
                {
                case 72:                            //UP
                    {
                        current=(current+5)%6;
                        break;

                    }
                case 80:                            //down
                    {
                        current=(current+1)%6;
                        break;

                    }
                case 71:                            //home
                    {
                        current=0;
                        break;

                    }
                case 79:                             //End
                    {
                        current=5;
                        break;
                    }
                }
            }
        }
        textattr(NormalPen);

    }while(lo);
    return 0;
}
