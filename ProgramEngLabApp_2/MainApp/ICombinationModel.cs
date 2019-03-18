using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace GraphicsLabApp_2
{
	public enum OperationType
	{
		//разбиение числа
		IntSplit,
		//разбиение множества
		SetSplit,
		//перестановка с повторением
		SetPermWithRep,
		//перестановка без повторения
		SetPermWithoutRep
	}
	public interface ICombinationModel
	{
		//обновить текущий результат
		void RaiseTempResult(int n, OperationType operationType);
		//считать сохраненный файл
        void ReadSavedFile(string name);
		//сохранить высчитанный результат в файл 
		void SaveTempFile();
		//имена всех сохранненых файлов
        string FileNames { get; set; }
		// текущий высчитанный результат
        List<string> TempResult { get; set; }
		// текущий тип операции
		OperationType TempOperType { get; set; }

    }
}
