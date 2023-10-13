using System;

public class Book
{
    private string _title;
    private int _pages;

    public string Title
    {
        get
        {
            return _title;
        }
        set
        {
            _title = !string.IsNullOrWhiteSpace(value) ? value : "Unknown";
        }
    }

    public int Pages
    {
        get
        {
            return _pages;
        }
        set
        {
            _pages = value >= 1 ? value : 1;
        }
    }

    public Book(string title, int pages)
    {
        Title = title;
        Pages = pages;
    }

    public void DisplayBookInfo()
    {
        Console.WriteLine("Book Title: {0}", Title);
        Console.WriteLine("Number of Pages: {0}", Pages);
    }
}
