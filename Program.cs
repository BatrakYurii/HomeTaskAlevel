using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Master
{
    class Program
    {
        static async Task Main(string[] args)
        {
            FileProcessor userFile = new FileProcessor("D:/A-Level/Master/users.txt");
            FileProcessor ordersFile = new FileProcessor("D:/A-Level/Master/orders.txt");

            List<Task<List<string>>> tasks = new List<Task<List<string>>>();
            tasks.Add(Task.Run(userFile.ReadTextAsync));
            tasks.Add(Task.Run(ordersFile.ReadTextAsync));

            Task.WhenAll(tasks);

            List<string> users = tasks[0].Result;
            List<string> orders = tasks[1].Result;

            DataProcessor dataProcessor = new DataProcessor(users, orders);
            dataProcessor.CreateResultAsync();
        }
    }
}
