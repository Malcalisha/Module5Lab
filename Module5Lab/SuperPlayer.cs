using System;

namespace Module5Lab
{
    internal class SuperPlayer : Player
    {
        // Additional properties or methods specific to SuperPlayer
        // For example:
        public void Fly()
        {
            Console.WriteLine("SuperPlayer is flying!");
        }

       // Create a super player
SuperPlayer superPlayer = new SuperPlayer();
superPlayer.AddPoints(200);
superPlayer.Fly(); // Demonstrate the additional ability
Console.WriteLine($"SuperPlayer score: {superPlayer.GetScore()}, Lives left: {superPlayer.GetLivesLeft()}"); 
    }
}
           