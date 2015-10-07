using System;
using System.Threading;

namespace PC_20150822_threads {
	class MainClass {
		public static void Main (string[] args) {

			Prints p = new Prints ();

			for (var i = 0; i < 500; i++) {
				p.printOla ();
				p.printThread ();
			}

			Console.WriteLine ("===============================");

			Thread t1 = new Thread (p.printOla500);
			t1.Start ();

			Thread t2 = new Thread (p.printThread500);
			t2.Start ();
		}
	}
}
