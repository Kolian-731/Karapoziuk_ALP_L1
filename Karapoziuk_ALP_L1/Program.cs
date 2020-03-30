using System;
using System.IO;


namespace Karapoziuk_ALP_L1
{
	class Train 
	{
		public int numberTrain;
		public string destinationStation;
		public int departureTime; //час відправлення 
		public int arrivalTime;   //час прибуття 

		public Train (int numberTrain, string destinationStation,int departureTime, int arrivalTime)
		{
			this.numberTrain = numberTrain; 
			this.destinationStation = destinationStation;
			this.departureTime = departureTime;
			this.arrivalTime = arrivalTime;
		}

		public Train() { }
	}

	class Program
	{
		public static object ReadFile { get; private set; }

		static void writingToFile() // function writing to a file
		{
			Train[] train = new Train[]
			{
					new Train(1,"Odessa",2,20),
					new Train(15,"Kharkiv",2,23),
					new Train(12,"Volochisk",11,14),
					new Train(112,"Lviv",5,8),
					new Train(731,"Kiev",5,11)
			};

			StreamWriter str = new StreamWriter("data.txt");
			
		   for (int i = 0; i < 5; i++)
		   {
		      if (train[i].arrivalTime - train[i].departureTime < 17) //time check on the road not exceeding 17 hours.
				{
			    str.WriteLine("Number of Train: " + train[i].numberTrain);
				str.WriteLine("Destination Station: " + train[i].destinationStation);
			    str.WriteLine("Departure Time: " + train[i].departureTime);
			    str.WriteLine("Arrival Time: " + train[i].arrivalTime + "\n");
			  }
		   }
		   str.WriteLine("--------------------------------------------\n");
			
		 str.Close();
		}

		static void readingFromFile() //file read function
		{
			string[] lines = File.ReadAllLines("data.txt"); 
			foreach (var line in lines) Console.WriteLine(line); 
		}

		static void Main(string[] args)
		{
				writingToFile();
			    readingFromFile();
		}

	}
}
