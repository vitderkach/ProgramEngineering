using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;


namespace GraphicsLabApp_2
{
	public class CombinationController: ICombinationController
	{
		private ICombinationView _view = null;
		private ICombinationModel _model = null;
		public CombinationController(ICombinationView view, ICombinationModel model)
		{
			Contract.Requires(view != null, "View can't be null!");
			Contract.Requires(model != null, "Model can't be null!");
			_view = view;
			_model = model;
			SolveTaskEvent += CombinationController_SolveTaskEvent;
		}

		public event EventHandler<CombControllerArgs> SolveTaskEvent;

		public void SaveTempFile()
		{
			throw new NotImplementedException();
		}

		public void SolveTask(string data, OperationType operationType)
		{
			CombControllerArgs combControllerArgs = new CombControllerArgs(data, operationType);
			SolveTaskEvent(this, combControllerArgs);
		}

		public bool TempResultExist()
		{
			if (_model.TempResult == null)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		private void CombinationController_SolveTaskEvent(object sender, CombControllerArgs e)
		{
			Debug.WriteLine(sender.ToString());
			Debug.WriteLine("Yee!");
			Debug.WriteLine(e.Data);
			Debug.WriteLine(e.OperationType);
		}

	}

	public class CombControllerArgs: EventArgs
	{
		public string Data { get; set; }
		public OperationType OperationType { get; set; }

		public CombControllerArgs(string data, OperationType operationType)
		{
			Data = data;
			OperationType = operationType;
		}
	}
}
