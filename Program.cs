using System;
class ProgramNo2{
    static void Main(string[]args){
        char PollamaiSod = 'y';
        Queue<int> S = new Queue<int>();
        Queue<int> M = new Queue<int>();
        Queue<int> L = new Queue<int>();
        while(PollamaiSod == 'L'|| PollamaiSod == 'M'||PollamaiSod == 'S'||PollamaiSod =='y'){
            PollamaiSod = Char.Parse(Console.ReadLine());
            if(PollamaiSod == 'S'){
                S.Push(3);
            }
            else if(PollamaiSod == 'M'){
                S.Push(2);
                for(int i=0;i<3;i++){
                    M.Push(3);
                }
            }
            else if(PollamaiSod == 'L'){
                S.Push(1);
                for(int i=0;i<2;i++){
                    M.Push(2);
                    for(int j=0;j<3;j++){
                        L.Push(3);
                    }
                }
            }
        }
        for(int i=0;i<S.GetLength();i++){
            Console.WriteLine("{0}",S.Get(i));
        }
        for(int i=0;i<M.GetLength();i++){
            Console.WriteLine("{0}",M.Get(i));
        }
        for(int i=0;i<L.GetLength();i++){
            Console.WriteLine("{0}",L.Get(i));
        }
    }
}
