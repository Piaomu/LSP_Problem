using System;

namespace LSP_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Player rooster = new Center();
            rooster.FirstName = "Foghorn";
            rooster.LastName = "Leghorn";
            rooster.ShouldPlay(1, 4);

            Player rabbit = new PowerForward();
            rabbit.FirstName = "Bugs";
            rabbit.LastName = "Bunny";
            rabbit.ShouldPlay(6, 37);

            Player duck = new SmallForward();
            duck.FirstName = "Daffy";
            duck.LastName = "Duck";
            duck.ShouldPlay(1, 31);

            Player superStar = new ShootingGuard();
            superStar.FirstName = "Michael";
            superStar.LastName = "Jordan";
            superStar.ShouldPlay(2, 15);

            Player canary = new PointGuard();
            canary.FirstName = "Tweety";
            canary.LastName = "Bird";
            canary.ShouldPlay(2, 31);

            Player celebrity = new BillMurray();
            celebrity.FirstName = "Bill";
            celebrity.LastName = "Murray";
            celebrity.ShouldPlay(0, 0);

            Console.ReadLine();
        }
    }
}
