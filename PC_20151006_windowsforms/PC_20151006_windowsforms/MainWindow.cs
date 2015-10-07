using System;
using Gtk;

public partial class MainWindow: Gtk.Window {
	public MainWindow () : base (Gtk.WindowType.Toplevel) {
		Build ();
		/*btnCliqueAqui.Click += Function{
			fhfjhjgk
		};*/
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a) {
		Application.Quit ();
		a.RetVal = true;
	}

	protected void clicou (object sender, EventArgs e) {
		//throw new NotImplementedException ();
		String texto = txtInput.Text;
		MessageDialog dialog = new MessageDialog(this, DialogFlags.Modal, MessageType.Other, ButtonsType.YesNo, texto);
		ResponseType tp = (Gtk.ResponseType)dialog.Run();
		//dialog.Run ();
		dialog.Destroy();
	}
}
