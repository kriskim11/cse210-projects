using System;

class Program
{
    static void Main(string[] args)
    {
        // Create some videos
        Video video1 = new Video("1 A.M Study Session 📚 [lofi hip hop]", "lofi girl", 600);
        Video video2 = new Video("3 Days in Arctic Survival Shelter - Solo Bushcraft Camping & Blacksmithing.", "Outdoor Boys", 500);

        // Add comments video1
        video1.AddComment(new Comment("salwama7576", "This girl is a total genius to decorate a house like this."));
        video1.AddComment(new Comment("Casper-jz4oz", "to everyone who is doing homework, leave the chat, breathe slowly, take a sip of water, and focus."));
        video1.AddComment(new Comment("4_feit", "The lofi community has the most positive and chill people ever."));

        // Add comments video2
        video2.AddComment(new Comment("Ben", "thanks for the video, I really enjoyed it!"));
        video2.AddComment(new Comment("Robert", "We love your camping videos!"));
        video2.AddComment(new Comment("Sandra", "Great video, keep it up!"));

        // Displaycomments
        video1.DisplayVideoDetails();
        video2.DisplayVideoDetails();


    }
}