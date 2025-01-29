#load "accessModifier.cs"

class help{

    public static void main(String[] args) {
        calci c = new calci(5,3);
        Console.Write("Sum is "+c.getSum()+" \nProduct is "+c.getPro());
    }
}

help.main(null);