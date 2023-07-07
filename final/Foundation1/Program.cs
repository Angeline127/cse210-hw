using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video
        {
            Title = "Video 1",
            Author = "Author 1",
            Length = 120,
            Comments = new List<Comment>
            {
                new Comment { CommenterName = "Angeline Nyepen", CommentText = "Good content, I love it" },
                new Comment { CommenterName = "Joyce Appiah", CommentText = "Good job" },
                new Comment { CommenterName = "Alex Brown", CommentText = "Awesome explanation" }
            }
        };

        Video video2 = new Video
        {
            Title = "Video 2",
            Author = "Author 2",
            Length = 180,
            Comments = new List<Comment>
            {
                new Comment { CommenterName = "Felicia Kumi", CommentText = "Breath taking" },
                new Comment { CommenterName = "Francis Agyei", CommentText = "It's giving a positive vibes" },
                new Comment { CommenterName = "Bianca Larbi", CommentText = "tag me in your next video" }
            }
        };

        Video video3 = new Video
        {
            Title = "Video 3",
            Author = "Author 3",
            Length = 150,
            Comments = new List<Comment>
            {
                new Comment { CommenterName = "Princess Owusu", CommentText = "Interesting contents" },
                new Comment { CommenterName = "Titi Mensah", CommentText = "Go for it" },
                new Comment { CommenterName = "Akosua Amankwaah", CommentText = "Nice" }
            }
        };

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine("Commenter: " + comment.CommenterName);
                Console.WriteLine("Comment: " + comment.CommentText);
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------------");
        }

        Console.ReadLine();
    }
}