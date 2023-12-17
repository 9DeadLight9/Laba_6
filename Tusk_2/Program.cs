using Tusk_2;

class Program
{
    static void Main(string[] args)
    {
        var repository = new Repository<int>();

     
        repository.Add(1);
        repository.Add(2);
        repository.Add(3);
        repository.Add(4);
        repository.Add(5);

   
        Criteria<int> criteria = item => item % 2 == 0;

       
        var result = repository.Find(criteria);

      
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}
