using System.Security.Cryptography.X509Certificates;

///Abstraction Diagram
public class Video{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _commentsArray = new List<Comment>();

    public int CommentsArrayLenght() {
        int count = _commentsArray.Count;

        return count;
    }
    public void DisplayVideoComment(){
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {CommentsArrayLenght()}");
        Console.WriteLine("Comments: ");
        foreach(Comment comment in _commentsArray){
            Console.WriteLine($" - {comment._commentAuthor}: {comment._commentText}");
        }
        Console.WriteLine("=====================================");
    }
}

