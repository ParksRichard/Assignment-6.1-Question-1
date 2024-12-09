/*
Implement a single linked list with each node representing a house
You may add data in like house number, address, type of house,
and display details.
*/

//Create house class
//define values
//make linkedlist?

namespace Assignment_6._1_Question_1
{
    public class House
    {
        public int Number { get; set; }
        public string Address { get; set; }
        //public string Type { get; set; }
        public HouseStyle HouseType { get; set; }

        //splite addres by number and street name?
        //public string city { get; set; }
        //public string state { get; set; }
        //public string zipcode { get; set; }
        //public string country { get; set; }

        public enum HouseStyle {  Colonial, Ranch, Victorian, Modern }

        //define variabels
        public House(int number, string address, HouseStyle houseStyle)
        {
            Number = number;
            Address = address;
            //Type = type;
            HouseType = houseStyle;
        }

        public void Main()
        {
            Console.WriteLine($"House Number: {Number}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Type of House: {HouseType}");
            Console.WriteLine();
        }
    }

    //this is where class stuff mixes and confuses with personal work
    //public class  Node
    //{
    //    public House Data { get; set; }
    //    public Node Next { get; set; }
    //    public Node(House house)
    //    {
    //        Data = house;
    //        Next = null;
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            //make list and sort data types
            LinkedList<House> list = new LinkedList<House>();

            House house1 = new House(1, "958 Wadsworth", House.HouseStyle.Ranch);
            //House house2 = new House();
            //House house3 = new House();

            list.AddLast(house1);
            //list.AddLast(house2); 
            //list.AddLast(house3);

            AllHouses(list);
        }

        //public class LinkedList
        //{
        //    internal Node Head { get; set; }
        //    public int Length { get; set; }
        //}

        //getlastnode?
        //if empty list = null

        //public static House FindHouse(int number)
        //    {
        //     return House house;
        //    }

        //what a amalgam nightmare of code

        static void AllHouses(LinkedList<House> list)
        {

            {
                if (list.Count == 0)
                    Console.WriteLine("The list is empty.");
                return;
            }

            foreach (var house in list)
            {
                house.Main();
            }
        }
    }
}
