using System;

namespace _02_BlogPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var blogPost01 = new BlogPost();
            var blogPost02 = new BlogPost();
            var blogPost03 = new BlogPost();

            blogPost01.AuthorName = "John Doe";
            blogPost01.Title = "Lorem Ipsum";
            blogPost01.Text = "Lorem ipsum dolor sit amet.";
            blogPost01.PublicationDate = "2000.05.04.";

            blogPost02.AuthorName = "Tim Urban";
            blogPost02.Title = "Wait but why";
            blogPost02.Text = "A popular long-form, stick-figure-illustrated blog about almost everything.";
            blogPost02.PublicationDate = "2010.10.10.";

            blogPost03.AuthorName = "William Turton";
            blogPost03.Title = "One Engineer Is Trying to Get IBM to Reckon With Trump";
            blogPost03.Text = "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. " +
                "When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into " +
                "the whole organizer profile thing.";
            blogPost03.PublicationDate = "2017.03.28.";

            Console.WriteLine(blogPost01.AuthorName + "\n" + blogPost01.Title + "\n" + blogPost01.Text + "\n" + blogPost01.PublicationDate + "\n");
            Console.WriteLine(blogPost02.AuthorName + "\n" + blogPost02.Title + "\n" + blogPost02.Text + "\n" + blogPost02.PublicationDate + "\n");
            Console.WriteLine(blogPost03.AuthorName + "\n" + blogPost03.Title + "\n" + blogPost03.Text + "\n" + blogPost03.PublicationDate + "\n");

            Console.ReadLine();
        }
    }
}
