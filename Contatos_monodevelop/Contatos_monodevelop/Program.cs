using System;
using Gtk;

namespace Contatos_monodevelop {
	class MainClass {
		public static void Main (string[] args) {
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
		}
	}
}
