using System;

namespace PC_20150822_threads {
	public class Prints {
		public Prints () {
		}

		public void printOla500(){
			for (var i = 0; i < 500; i++)
				Console.WriteLine ("Olá");
		}

		public void printThread500(){
			for (var i = 0; i < 500; i++)
				Console.WriteLine ("Threads!");
		}

		public void printOla(){
			Console.WriteLine ("Olá");
		}

		public void printThread(){
			Console.WriteLine ("Threads!");
		}
	}
}

