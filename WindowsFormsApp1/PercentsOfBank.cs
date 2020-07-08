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
    public partial class PercentsOfBank : Form
    {
        int index = -1;
        int NumRows = -1;
        public PercentsOfBank()
        {
            InitializeComponent();
        }

        private void MachinesKey_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PercentsData.Rows.Clear();
            index = e.RowIndex;
            if (!(index == -1))
            {
                Machine keyMachine = new Machine(Convert.ToInt32(MachinesKey.Rows[index].Cells[1].Value),
                            Convert.ToString(MachinesKey.Rows[index].Cells[2].Value), Convert.ToString(MachinesKey.Rows[index].Cells[3].Value));
                Report<Machine, Percent> report = Database.GetInstance().BankPercentReport(keyMachine);
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
