namespace magiczneKule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int.TryParse(Console.ReadLine(), out int n);
            
            string[] mocKulStr = Console.ReadLine().Split(' ');
            List<int> mocKulInt = new List<int>();
            foreach(string s in mocKulStr) 
                mocKulInt.Add(int.Parse(s));

            string[] kierunekKul = Console.ReadLine().Split(' ');


            for(int i = 0; i < n; i++){
                if(i+1 < n && (kierunekKul[i] == "0" && kierunekKul[i + 1] == "1")){
                    if (mocKulInt[i] > mocKulInt[i + 1]){
                        mocKulInt[i + 1] = mocKulInt[i];
                        kierunekKul[i + 1] = kierunekKul[i];
                        mocKulInt[i] = 0;
                    } else {
                        mocKulInt[i] = 0;
                    }
                }
                
            }

            foreach (int i in mocKulInt)
                if (i > 0)
                    count++;
                
            Console.WriteLine(count);
        }
    }
}
