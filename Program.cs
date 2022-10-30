namespace WebServices;

using System.Text.Json;
class WebServices
{
    public static async Task Main(){
        string url = "https://jsonplaceholder.typicode.com/users";
        HttpClient client = new HttpClient();

        List<Person>? list = new List<Person>();

        var response = await client.GetAsync(url);

        if(response.IsSuccessStatusCode){
            var content = await response.Content.ReadAsStringAsync();
            list = JsonSerializer.Deserialize<List<Person>>(content); 
        }else{
            Console.WriteLine("Bad Request");
        }

        foreach(Person person in list)
        {
            Console.WriteLine($"Name is {person.name} and city is {person.address.city}");
        }
    }
}