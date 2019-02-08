using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{

    class Store
    {
        int AmountOfGame = 4;

        public List<Game> showCase = new List<Game>();

        public Store()
        {
            showCase.Add(new Game("daddy simulator", 15f, "How to Dad", "reallife"));
            showCase.Add(new Game("FEZ", 50f, "Move your fez", "RPG"));
            showCase.Add(new Game("Half_Life 3", 1000000f, "Its´s never comming", "TROLL"));
            showCase.Add(new Game("Fabber", 60f, "Faggot", "reallife"));

        }

        public void addGame(Game game)
        {
            if (showCase.Count < AmountOfGame)
                showCase.Add(game);
            
        }

    

        public void Remove(Game game)
        {
            if (showCase.Contains(game))
                showCase.Remove(game);

        }

        public void Sell(Game game, User user)
        {
            if (user.vallet >= game.price)
            {
                user.libary.Add(game);
                user.vallet -= game.price;
                Remove(game);

            }
            else
                Console.WriteLine("Not Enough Money!");
        }
        
     

    }

    class User
        {   
            
            public float vallet;
            public List<Game> libary = new List<Game>(); 

            public User(float valletFunds)
            {
                vallet = valletFunds;
            }
        }


    class Game
    {
        public string genre;
        public string name;
        public float price;
        public string description;

        public Game(string name, float price, string description, string genre)
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.genre = genre;
        }




    }
}


