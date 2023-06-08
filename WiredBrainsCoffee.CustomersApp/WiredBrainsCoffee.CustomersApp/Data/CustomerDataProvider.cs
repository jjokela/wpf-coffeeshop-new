using WiredBrainsCoffee.CustomersApp.Model;

namespace WiredBrainsCoffee.CustomersApp.Data
{
    public interface ICustomerDataProvider
    {
        Task<IEnumerable<Customer>?> GetAllAsync();
    }

    public class CustomerDataProvider : ICustomerDataProvider
    {
        public async Task<IEnumerable<Customer>?> GetAllAsync()
        {
            // simulate delay
            await Task.Delay(200);

            return new List<Customer>
            {
                new Customer{Id=1,FirstName="Julia",LastName="Developer",IsDeveloper=true},
                new Customer{Id=2,FirstName="Alex",LastName="Rider"},
                new Customer{Id=3, FirstName="Thomas Claudius",LastName="Huber",IsDeveloper=true},
                new Customer{Id=4,FirstName="Anna",LastName="Rockstar"},
                new Customer{Id=5,FirstName="Sara",LastName="Metroid"},
                new Customer{Id=6,FirstName="Ben",LastName="Ronaldo"}
            };
        }
    }
}
