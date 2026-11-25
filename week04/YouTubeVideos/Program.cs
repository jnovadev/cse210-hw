using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video backpackReview = new Video("Everyday Backpack Review", "Travel with Emma", 420);
        backpackReview.AddComment(new Comment("Alex", "The laptop pocket looks really useful."));
        backpackReview.AddComment(new Comment("Maria", "I use this backpack for school every day."));
        backpackReview.AddComment(new Comment("James", "Does the side pocket fit a large water bottle?"));
        videos.Add(backpackReview);

        Video headphonesReview = new Video("Testing Wireless Headphones", "Tech with Daniel", 615);
        headphonesReview.AddComment(new Comment("Sofia", "Thanks for comparing the sound quality."));
        headphonesReview.AddComment(new Comment("Liam", "The battery life is my favorite feature."));
        headphonesReview.AddComment(new Comment("Isabella", "Are these comfortable with glasses?"));
        headphonesReview.AddComment(new Comment("Noah", "I bought these after watching your review."));
        videos.Add(headphonesReview);

        Video cookingTutorial = new Video("Making Smoothies with a Compact Blender", "Cooking with Olivia", 300);
        cookingTutorial.AddComment(new Comment("Ethan", "The blender fits perfectly in my small kitchen."));
        cookingTutorial.AddComment(new Comment("Camila", "I tried the mango recipe and loved it."));
        cookingTutorial.AddComment(new Comment("Lucas", "Can this blender handle frozen fruit?"));
        videos.Add(cookingTutorial);

        Video campingGuide = new Video("Weekend Camping Gear Guide", "Outdoor Adventures", 780);
        campingGuide.AddComment(new Comment("Mia", "That tent looks easy to set up."));
        campingGuide.AddComment(new Comment("Benjamin", "The portable lantern lasted our entire trip."));
        campingGuide.AddComment(new Comment("Valentina", "How much does the sleeping bag weigh?"));
        campingGuide.AddComment(new Comment("Henry", "This helped me choose gear for my first trip."));
        videos.Add(campingGuide);

        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine();
        }
    }
}
