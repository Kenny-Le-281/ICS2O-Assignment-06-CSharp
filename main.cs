using System;
using System.Reflection;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Nodes;

class Program
{
    public static async Task Main()
    {
        HttpClient client = new HttpClient();
        string response = await client.GetStringAsync(
            "https://animechan.vercel.app/api/random"
        );
        // Console.WriteLine(response);
        var jsonAsDictionary = System.Text.Json.JsonSerializer.Deserialize<Object>(response);
        // Console.WriteLine(jsonAsDictionary);
        Console.WriteLine("");
        JsonNode resultNode = JsonNode.Parse(response)!;
        // Console.WriteLine(animeNode);
        JsonNode animeNode = resultNode!["anime"]!;
        // Console.WriteLine(characterNode);
        JsonNode characterNode = resultNode!["character"]!;
        // Console.WriteLine(quoteNode);
        JsonNode quoteNode = resultNode!["quote"]!;
        Console.WriteLine("Anime name: " + animeNode);
        Console.WriteLine("");
        Console.WriteLine("Character name: " + characterNode);
        Console.WriteLine("");
        Console.WriteLine("Quote: " + '"' + quoteNode + '"');
        Console.WriteLine("");
        Console.WriteLine("\nDone.");
    }
}