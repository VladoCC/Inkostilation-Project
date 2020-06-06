using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PercentsOfOperation : Form
    {
        int index = -1;
        int NumRows = -1;
        public PercentsOfOperation()
        {
            InitializeComponent();
        }

        private void OperationsKey_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PercentsData.Rows.Clear();
            index = e.RowIndex;
            if (!(index == -1))
            {
                Operation keyOperation = new Operation(Convert.ToString(OperationsKey.Rows[index].Cells[0].Value),
                          Convert.ToInt32(OperationsKey.Rows[index].Cells[1].Value),
                          Convert.ToInt32(OperationsKey.Rows[index].Cells[2].Value),
                          Convert.ToInt32(OperationsKey.Rows[index].Cells[3].Value));
                Report<Operation, Percent> report = GUI.myDatabase.OperationPercentReport(keyOperation);
                Percent[] arr = report.Data();
                int size = report.DataSize();
                for (int i = 0; i < size; i++)
                {
                    PercentsData.Rows.Add();
                    NumRows += 1;
                    PercentsData.Rows[NumRows].Cells[0].Value = arr[i].OperationName;
                    PercentsData.Rows[NumRows].Cells[1].Value = arr[i].SenderBank;
                    PercentsData.Rows[NumRows].Cells[2].Value = arr[i].ReceiverBank;
                    PercentsData.Rows[NumRows].Cells[3].Value = arr[i].Percent1;
                }
                NumRows = -1;
            }
        }
    }
}
