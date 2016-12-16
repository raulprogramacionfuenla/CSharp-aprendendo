using System;

namespace PCW_20160308_simple_mono_controller {

	public class MyPageController : System.Web.UI.Page {

		public MyPageController () : base() {
			this.Load += MyPageController_Load;
		}

		void MyPageController_Load (object sender, EventArgs e) {
			String param = Request.Params ["par1"];

			if (param != null) {
				if (param != "OK") {
					Response.Redirect ("Erro.aspx");
				}
			}
		}
	}
}

