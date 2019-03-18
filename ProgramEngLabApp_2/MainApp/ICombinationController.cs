using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLabApp_2
{
	public interface ICombinationController
	{
		//решить задачу
		void SolveTask(string data, OperationType operationType);
		//сохранить высчитанный результат в файл 
		void SaveTempFile();
		// наличие высчитанного результата
		bool TempResultExist();

    }
}
