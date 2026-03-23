public class Comment
{
//-Username: string
private string Username;
//-Text: string
private string Text;
//+Comment(username, text)
public Comment(string username, string text)
    {
        Username = username;
        Text = text; 
    }

public string getUsername()
    {
        return Username;
    }
public string getText()
    {
        return Text;
    }

public void setText(string text)
    {
        Text = text;
    }

    public void setUsername(string username)
    {
        Username = username;
    }

//+DisplayComment(): void
public void DisplayComment()
    {
      Console.WriteLine($"{Username}:{Text}");  
    }
}