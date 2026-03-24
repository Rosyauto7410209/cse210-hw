using System.Reflection;

public class Video:Contentitem
{
//-lengthinSeconds:int
private int _lengthinSeconds;

//-comments:List<Comment>
private List<Comment> _comments;

//+Video(title, author,lengthinSeconds)

public Video(string title, string author, int lengthinSeconds):base(title, author)
    {
        _lengthinSeconds = lengthinSeconds;
        _comments = new List<Comment>();
    }
//+AddComment(Comment): void

public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

//+GetCommentcount(): int

public int GetCommentcount()
    {
        return _comments.Count;
    }
public void setlengthinSeconds(int lengthinSeconds)
    {
        _lengthinSeconds = lengthinSeconds;
    }

public override void Displayinfo()
    {
        base.Displayinfo();
        Console.WriteLine($"Length{_lengthinSeconds}");
    }

public int getlengthinSeconds()
{
        return _lengthinSeconds;
}
//+DisplayDetails(): void
public void DisplayDetails()
    {
        Console.WriteLine("Video Details");
        Console.WriteLine($"Title {getTitle()}");
        Console.WriteLine($"Author {getAuthor()}");
        Console.WriteLine($"Length {_lengthinSeconds}");
        Console.WriteLine($"Comments {GetCommentcount()}");
    }

//+DisplayComments(): void
public void DisplayComments()
    {
        Console.WriteLine("Comments: ");
        foreach (Comment comment in _comments)
        {
             comment.DisplayComment();
        }
    }
}