using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLabApp_2
{
	public interface ICombinationView
	{
		//вывод высчитанного результата
		void OutputResult(List<string> resultList, OperationType operationType);
		//вывод считанного файла
        void OutputFile(StreamReader resultFile);
		//вывод соббщения с ошибкой
        void OutputErrMess(Exception ex);
		//изменение текущего контроллера для представления
		void SetController(ICombinationController controller);
	}
}
