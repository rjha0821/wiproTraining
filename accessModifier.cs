using System;

class Program{
    class calci{
        int no1;
        int no2;
        public calci(int no1, int no2) { 
            this.no1 = no1;
            this.no2 = no2;
        }

        public int getSum(){
            return no1+no2;
        }
        public int getPro(){
            return no1*no2;
        }

    }

    public static void main(string [] args){
        Console.Write("Enter 2 no : ");
        int n1 = int.Parse(Console.ReadLine()); 
        int n2 = int.Parse(Console.ReadLine());
        calci c = new calci(n1, n2);
        
        Console.Write("Sum is "+c.getSum()+" Product is "+c.getPro());
    }

}

Program.main(null);