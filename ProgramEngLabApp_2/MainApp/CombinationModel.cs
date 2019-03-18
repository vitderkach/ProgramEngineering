using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombinationClassLibrary;
namespace GraphicsLabApp_2
{
    public class CombinationModel : ICombinationModel
    {
        CombinationOperations _operations;
        public string FileNames { get; set; }
        public List<string> TempResult { get; set; }
        public OperationType TempOperType { get; set; }
        OperationType TempOperationType;
        public CombinationModel()
        {
            _operations = new CombinationOperations();
            DecideNewResult += CombinationModel_DecideNewResult;
            ReadFile += CombinationModel_ReadFile;
        }

        private void CombinationModel_DecideNewResult(object sender, CombModelArgs e)
        {
            throw new NotImplementedException();
        }



        private void CombinationModel_ReadFile(object sender, CombModelArgs e)
        {
            throw new NotImplementedException();
        }

        event EventHandler<CombModelArgs> DecideNewResult;
        event EventHandler<CombModelArgs> ReadFile;
        public void RaiseTempResult(int n, OperationType operationType)
        {
            DecideNewResult(this, new CombModelArgs(n, operationType));
        }

        public void ReadSavedFile(string name)
        {
            ReadFile(this, new CombModelArgs(name));
        }

        public void SaveTempFile()
        {
            throw new NotImplementedException();
        }

        public class CombModelArgs : EventArgs
        {
            OperationType? OperationType { get; set; }
            int? Value { get; set; }
            string FileName { get; set; }
            public CombModelArgs(int value, OperationType operationType)
            {
                OperationType = operationType;
                Value = value;
            }

            public CombModelArgs(string fileName)
            {
                FileName = fileName;
            }
        }
    }
}
