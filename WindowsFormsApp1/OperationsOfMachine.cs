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
    public partial class OperationsOfMachine : Form
    {
        int index = -1;
        int NumRows = -1;
        public OperationsOfMachine()
        {
            InitializeComponent();
        }

        private void MachinesKey_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OperationsData.Rows.Clear();
            index = e.RowIndex;
            Machine keyMachine = new Machine(Convert.ToInt32(MachinesKey.Rows[index].Cells[1].Value),
                        Convert.ToString(MachinesKey.Rows[index].Cells[2].Value), Convert.ToString(MachinesKey.Rows[index].Cells[3].Value));
            Report<Machine, Operation> report = GUI.myDatabase.MachineOperationReport(keyMachine);
            Operation[] arr = report.Data();
            int size = report.DataSize();
            for (int i = 0; i < size; i++)
            {
                OperationsData.Rows.Add();
                NumRows += 1;
                OperationsData.Rows[NumRows].Cells[0].Value = arr[i].OperationType;
                OperationsData.Rows[NumRows].Cells[1].Value = arr[i].CardNumber;
                OperationsData.Rows[NumRows].Cells[2].Value = arr[i].MachineNumber;
                OperationsData.Rows[NumRows].Cells[3].Value = arr[i].Sum;
            }
            NumRows = -1;
        }
    }
}
