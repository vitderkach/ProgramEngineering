using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsLabApp_2
{
	public partial class MainForm : Form, ICombinationView
	{
		ICombinationController _controller;
		public MainForm()
		{
			InitializeComponent();
		}

		public string Data { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public List<string> PermuratedList { set => throw new NotImplementedException(); }
		public List<string> SetSplittedList { set => throw new NotImplementedException(); }
		public List<int> IntegerSplittedList { set => throw new NotImplementedException(); }

		public event EventHandler ErrorDialog;

		event EventHandler ICombinationView.Closing
		{
			add
			{
				throw new NotImplementedException();
			}

			remove
			{
				throw new NotImplementedException();
			}
		}

		public void Open()
		{
			throw new NotImplementedException();
		}

		public void RefreshView()
		{
		}

		private void _controller_SolveTaskEvent(object sender, CombControllerArgs e)
		{
			Debug.WriteLine("Yee!");
		}

		public void SetController(ICombinationController controller)
		{
			if (controller != null)
			{
				_controller = controller;
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
            //_controller.RaiseSolveTaskEvent("Hello world!", OperationType.SetPermWithoutRep);
            Exception ex = new IOException("Hello)))");
            ex.Source = "ee";
            OutputErrMess(ex);
		}

		public void OutputResult(List<string> resultList, OperationType operationType)
		{
			throw new NotImplementedException();
		}

        public void OutputErrMess(Exception ex)
        {
            Debug.WriteLine(ex.GetType());
        }
    }
}
