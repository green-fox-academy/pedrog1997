using System;

namespace _02_BlogPost
{
    class Program
    {
        static void Main(string[] args)
        {
            BlogPost LoremIpsum = new BlogPost();
            LoremIpsum.AuthorName = "John Doe";
            LoremIpsum.Title = "Lorem Ipsum";
            LoremIpsum.Text = "Lorem ipsum dolor sit amet";
            LoremIpsum.PublicationDate = "2000.05.04.";

            BlogPost WaitButWhy = new BlogPost();
            WaitButWhy.AuthorName = "Tim Urban";
            WaitButWhy.Title = "Wait But Why";
            WaitButWhy.Text = "A popular long-form, stick-figure-illustrated blog about almost everything.";
            WaitButWhy.PublicationDate = "2010.10.10.";

            BlogPost OneEngineer = new BlogPost();
            OneEngineer.AuthorName = "William Turton";
            OneEngineer.Title = "One Engineer Is Trying to Get IBM to Reckon With Trump";
            OneEngineer.Text = "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.";
            OneEngineer.PublicationDate = "2017.03.28.";
        }
    }
}
