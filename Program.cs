// See https://aka.ms/new-console-template for more information
using BooksTracker.Models;
using System.Text.Json;

Console.WriteLine("Hello, World!");

var supabaseClient = new Supabase.Client(BooksTracker.Models.AppConfig.SUPABASE_URL, BooksTracker.Models.AppConfig.SUPABASE_KEY);

var books = await supabaseClient.From<Book>().Get();

Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(books.Models));

Console.ReadLine();