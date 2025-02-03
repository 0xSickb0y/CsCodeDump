using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

internal class Program
{
    async private static void Main(string[] args)
    {
        HttpClient client = new HttpClient();

        HttpResponseMessage response = await client.GetAsync("http://dog-api.kinduff.com/api/facts");
        response.EnsureSuccessStatusCode(); // Throws an exception if the HTTP response status is an error

        string responseBody = await response.Content.ReadAsStringAsync();
        Console.WriteLine(responseBody);

        var url = "http://localhost:5062/Home/Submit";

        var content = new FormUrlEncodedContent(
        new[] 
        {
            new KeyValuePair<string, string>("name", "john"),
            new KeyValuePair<string, string>("email", "john@domain.com"),
            new KeyValuePair<string, string>("message", "Hello!")
        });

        var response2 = await client.PostAsync(url, content);
        response.EnsureSuccessStatusCode();

        var responseBody2 = await response2.Content.ReadAsStringAsync();

        Console.WriteLine(responseBody2);

        var file = Path.Combine(Directory.GetCurrentDirectory(), "dog.jpg");
 
        if (File.Exists(file))
        {
            File.Delete(file);
            Console.WriteLine("Deleted existing dog.jpg");
        }

        HttpClient client3 = new HttpClient();

        var url2 = "https://http.dog/200.jpg";
        HttpResponseMessage response3 = await client.GetAsync(url2);
        response3.EnsureSuccessStatusCode();
        var imageBytes = await response3.Content.ReadAsByteArrayAsync();

        await File.WriteAllBytesAsync(file, imageBytes);
        Console.WriteLine($"Image saved to dog.jpg.  Double-click in Explorer to view.");
    }
}