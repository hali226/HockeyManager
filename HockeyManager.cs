using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager_namespace
{
    public class HockeyManager
    {
        string name;
        int age;
        int goals, hits, wins;

        //keďže nepoužijem databázu, budem si to ukladať len do Listov, po skončení programu budú premazané
        List<Forward> ForwardList = new List<Forward>();
        List<Defender> DefenderList = new List<Defender>();
        List<Goalie> GoalieList = new List<Goalie>();

        public void AddNewForward(string name, int age, int goals)
        {
            this.name = name;
            this.age = age;
            this.goals = goals;
            ForwardList.Add(new Forward(this.name, this.age, this.goals));
        }

        public void AddNewDefender(string name, int age, int hits)
        {
            this.name = name;
            this.age = age;
            this.hits = hits;
            DefenderList.Add(new Defender(this.name, this.age, this.hits));
        }

        public void AddNewGoalie(string name, int age, int wins)
        {
            this.name = name;
            this.age = age;
            this.wins = wins;
            GoalieList.Add(new Goalie(this.name, this.age, this.wins));
        }

    public void PrintNameAndAgeOfTheYoungestGoalie()
    {
            int youngestGoalieAge = 0, iters = 0;
            string youngestGoalieName = null;

            foreach (var iList in GoalieList)
            {
                    if ((iList.age < youngestGoalieAge) || (iters == 0))
                    {
                        youngestGoalieAge = iList.age;
                        youngestGoalieName = iList.name;
                    }
                iters++;
            }
            Console.WriteLine("The youngest goalie is " + youngestGoalieName + ". He is " + youngestGoalieAge + " years old.");
        }
}

    public class Player //následne využijem dedičnosť
    {
        public string name;
        public int age;
    }
    public class Forward: Player
    {
        int goals;
        public Forward(string name, int age, int goals)
        {
            this.name = name;
            this.age = age;
            this.goals = goals;
        }
    }

    public class Defender: Player
    {
        int hits;
        public Defender(string name, int age, int hits)
        {
            this.name = name;
            this.age = age;
            this.hits = hits;
        }
    }

    public class Goalie: Player
    {
        public int wins;
        public Goalie(string name, int age, int wins)
        {
            this.name = name;
            this.age = age;
            this.wins = wins;
        }
    }

}