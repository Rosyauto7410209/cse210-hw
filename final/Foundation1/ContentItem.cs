using System.Reflection;

public abstract class Contentitem
{
//-Title:string
private string Title;
//-author:string
private string Author;
//+contentitem(title, author)
public Contentitem(string title, string author)
    {
        Title = title;
        Author = author;
    }
//+Displayinfo():void
public string getAuthor()
    {
        return Author;
    }
public string getTitle()
    {
        return Title;
    }

public void setTitle(string title)
    {
        Title = title;
    }

    public void setAuthor(string author)
    {
        Author = author;
    }

public virtual void Displayinfo()
    {
        Console.WriteLine($"Title{Title}");
        Console.WriteLine($"Author{Author}");        
    }
}