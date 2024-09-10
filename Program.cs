class Program{
    public static void Main(){
        Console.WriteLine("Enter any string");
        string n = Console.ReadLine();

        char[] ch = n.ToCharArray();
        for(int i = 0;i<ch.Length;i++)
        {
            int count = 1;
            char c =ch[i];
            ch[i]='^';

            if(c!='^'){
                for(int j=i+1;j<ch.Length;j++){
                    if(c==ch[j]){
                        ch[j]='^';
                        count++;
                    }
                }
                Console.WriteLine(c+" = "+count);
            }
        }
 
        
    }
}
