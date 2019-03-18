using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsLabApp_2
{
	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.SetCompatibleTextRenderingDefault(false);
			Application.EnableVisualStyles();
			ICombinationView view = new MainForm();
			ICombinationModel model = new CombinationModel();
			ICombinationController controller = new CombinationController(view, model);
			view.SetController(controller);
			Application.Run((MainForm)view);
			
			
		}
	}
}
