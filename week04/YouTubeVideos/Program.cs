using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine();

        //Comments
        Comment comment1 = new Comment ();
        comment1._commentAuthor = "Gabriel Gustavo";
        comment1._commentText = "Amazing video, I loved it!";

        Comment comment2 = new Comment (); 
        comment2._commentAuthor = "Alice Johnson"; 
        comment2._commentText = "Amazing video, I loved it!" ;

        Comment comment3 = new Comment(); 
        comment3._commentAuthor = "Mark Spencer";
        comment3._commentText = "This helped me a lot, thanks!" ;

        Comment comment4 = new Comment(); 
        comment4._commentAuthor = "Sophia Lee";
        comment4._commentText = "I have a question about the topic." ;

        Comment comment5 = new Comment(); 
        comment5._commentAuthor = "Michael Brown"; 
        comment5._commentText = "Nice explanation!" ;

        Comment comment6 = new Comment(); 
        comment6._commentAuthor = "Emily White";
        comment6._commentText = "Can you make a part 2?" ;

        Comment comment7 = new Comment(); 
        comment7._commentAuthor = "David Green";
        comment7._commentText = "I totally agree with this!" ;

        Comment comment8 = new Comment(); 
        comment8._commentAuthor = "Olivia Martin"; 
        comment8._commentText = "This changed my perspective." ;

        Comment comment9 = new Comment(); 
        comment9._commentAuthor = "James Carter";
        comment9._commentText = "Well structured video!" ;

        Comment comment10 = new Comment(); 
        comment10._commentAuthor = "Emma Wilson";
        comment10._commentText = "Can you cover another topic next time?" ;

        Comment comment11 = new Comment(); 
        comment11._commentAuthor = "Lucas Adams";
        comment11._commentText = "I've learned something new today." ;

        Comment comment12 = new Comment(); 
        comment12._commentAuthor = "Isabella Moore";
        comment12._commentText = "Looking forward to more videos like this!" ;



        //Video 1
        Video video1 = new Video();
        video1._author = "Rogelio Guerra";
        video1._title = "Amazing Spider-man";
        video1._length = 120;

        video1._commentsArray.Add(comment1);
        video1._commentsArray.Add(comment2);
        video1._commentsArray.Add(comment3);

        video1.DisplayVideoComment();

        //Video 2
        Video video2 = new Video();
        video2._author = "Alice Monroe";
        video2._title = "The Dark Knight";
        video2._length = 152;
        
        video2._commentsArray.Add(comment4);
        video2._commentsArray.Add(comment5);
        video2._commentsArray.Add(comment6);
        video2._commentsArray.Add(comment1);

        video2.DisplayVideoComment();

        //Video 3
        Video video3 = new Video();
        video3._author = "Carlos Mendoza";
        video3._title = "Inception";
        video3._length = 148;

        video3._commentsArray.Add(comment7);
        video3._commentsArray.Add(comment8);
        video3._commentsArray.Add(comment9);

        video3.DisplayVideoComment();

        //Video 4
        Video video4 = new Video();
        video4._author = "Laura Smith";
        video4._title = "Interstellar";
        video4._length = 169;
        
        video4._commentsArray.Add(comment10);
        video4._commentsArray.Add(comment11);
        video4._commentsArray.Add(comment12);

        video4.DisplayVideoComment();
    }
}