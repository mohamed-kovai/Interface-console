using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_console
{
    interface stall
    {
        void display();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="INTERFACE-CONSOLE_APP";
            goldStall gold = new goldStall("jj golds",34000,"Rajesh",8);
            gold.display();
            premiumstall premium = new premiumstall("tech solution", 30000, "Raj", 20);
            premium.display();
            executivestall executive = new executivestall("Fruit Hunt", 30000, "Uber", 7);
            executive.display();

            Console.ReadKey();
        }
    }

    public class goldStall
    {
        private string stallName { get; set; }
        public string StallName {get=>this.stallName; set
            {
                this.stallName = value;
            }
        }
        private int cost { get; set; }
        public int Cost { get => this.cost;
            set
            {
                this.cost = value;
            }
        }
        private int tvSet { get; set; }
        public int Tvset
        {
            get => this.tvSet;
            set
            {
                this.tvSet = value;
            }
        }

        private string ownerNmae { get; set; }
        public string OwnerName
        {
            get => this.ownerNmae; set
            {
                this.ownerNmae = value;
            }
        }
        public goldStall()
        {

        }
        public goldStall(String stallName, int cost, String ownerName, int tvSet)
        {
            this.StallName = stallName;
            this.Cost = cost;
            this.OwnerName = ownerName;
            this.Tvset = tvSet;
        }

        public void display()
        {
            Console.WriteLine("Stall Name: {0}\nCost: {1}\nOwner Name: {2}\nTvset: {3}", stallName, cost, ownerNmae, tvSet);
        }

    }

    public class premiumstall
    {
        private string stallName { get; set; }
        public string StallName
        {
            get => this.stallName; set
            {
                this.stallName = value;
            }
        }
        private int cost { get; set; }
        public int Cost
        {
            get => this.cost;
            set
            {
                this.cost = value;
            }
        }
        private int projector { get; set; }
        public int Projector
        {
            get => this.projector;
            set
            {
                this.projector = value;
            }
        }

        private string ownerNmae { get; set; }
        public string OwnerName
        {
            get => this.ownerNmae; set
            {
                this.ownerNmae = value;
            }
        }
        public premiumstall()
        {
            
        }
        public premiumstall(String stallName, int cost, String ownerName, int projector)
        {
            this.StallName = stallName;
            this.Cost = cost;
            this.OwnerName = ownerName;
            this.Projector = projector;
        }

        public void display()
        {
            Console.WriteLine("Stall Name: {0}\nCost: {1}\nOwner Name: {2}\nTvset: {3}", stallName, cost, ownerNmae, projector);
        }

    }

    public class executivestall
    {
        private string stallName { get; set; }
        public string StallName
        {
            get => this.stallName; set
            {
                this.stallName = value;
            }
        }
        private int cost { get; set; }
        public int Cost
        {
            get => this.cost;
            set
            {
                this.cost = value;
            }
        }
        private int screen { get; set; }
        public int Screen
        {
            get => this.screen;
            set
            {
                this.screen = value;
            }
        }

        private string ownerNmae { get; set; }
        public string OwnerName
        {
            get => this.ownerNmae; set
            {
                this.ownerNmae = value;
            }
        }
        public executivestall()
        {

        }
        public executivestall(String stallName, int cost, String ownerName, int screen)
        {
            this.StallName = stallName;
            this.Cost = cost;
            this.OwnerName = ownerName;
            this.Screen = screen;
        }

        public void display()
        {
            Console.WriteLine("Stall Name: {0}\nCost: {1}\nOwner Name: {2}\nTvset: {3}", stallName, cost, ownerNmae, screen);
        }

    }

}
