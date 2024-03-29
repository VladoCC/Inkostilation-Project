﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace WindowsFormsApp1
{
    public partial class GUI : Form
    {
        int NumRows1 = -1;
        int NumRows2 = -1;
        int NumRows3 = -1;
        int NumRows4 = -1;
        int index1 = -1;
        int index2 = -1;
        int index3 = -1;
        int index4 = -1;
        string state = "";

        public static bool stopflag = false;
        public GUI()
        {
            Splash sp = new Splash();
            sp.Show();
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(100);
            }
            sp.Close();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HashMap1Dialog DialogWindow1 = new HashMap1Dialog();
            DialogWindow1.ShowDialog();
            if (!stopflag)
            {
                Machine NewMachine = new Machine(Convert.ToInt32(DialogWindow1.waterMarkTextBox1.Text),
                Convert.ToString(DialogWindow1.waterMarkTextBox2.Text), Convert.ToString(DialogWindow1.waterMarkTextBox3.Text));
                SearchQuery<Machine> query = Database.GetInstance().FindMachine(NewMachine.MachineNumber);
                if (!query.Found())
                {
                    Result res = Database.GetInstance().AddMachine(NewMachine);
                    if (res.Success)
                    {
                        dataGridView1.Rows.Clear();
                        NumRows1 = -1;
                        Machine[] machineArray = Database.GetInstance().MachineArray();
                        for (int i = 0; i < Database.GetInstance().MachineSize(); i++)
                        {
                            dataGridView1.Rows.Add();
                            NumRows1 += 1;
                            HashFunction<int> myHashFunction = Database.GetInstance().MachinesFunction();
                            dataGridView1.Rows[NumRows1].Cells[0].Value = myHashFunction.Hash(machineArray[i].GetKey());
                            dataGridView1.Rows[NumRows1].Cells[1].Value = machineArray[i].MachineNumber;
                            dataGridView1.Rows[NumRows1].Cells[2].Value = machineArray[i].Address;
                            dataGridView1.Rows[NumRows1].Cells[3].Value = machineArray[i].BankName;
                        }
                    }
                    else
                    {
                        ErrorForm ErrorWindow = new ErrorForm();
                        ErrorWindow.label1.Text = res.Message;
                        ErrorWindow.ShowDialog();
                    }
                }
                else 
                {
                    ErrorForm ErrorWindow = new ErrorForm();
                    ErrorWindow.label1.Text = "Нарушение уникальности ключа <Номер банкомата>";
                    ErrorWindow.ShowDialog();
                }
            }
            else 
            {
                stopflag = false;
                return;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            HashMap2Dialog DialogWindow2 = new HashMap2Dialog();
            DialogWindow2.ShowDialog();
            if (!stopflag)
            {
                Client NewClient = new Client(Convert.ToInt32(DialogWindow2.waterMarkTextBox1.Text),
                              Convert.ToString(DialogWindow2.waterMarkTextBox2.Text), Convert.ToString(DialogWindow2.waterMarkTextBox3.Text));
                SearchQuery<Client> query = Database.GetInstance().FindClient(NewClient.CardNumber);
                if (!query.Found())
                {
                    Result res = Database.GetInstance().AddClient(NewClient);
                    if (res.Success)
                    {
                        dataGridView3.Rows.Clear();
                        NumRows2 = -1;
                        Client[] clientArray = Database.GetInstance().ClientArray();
                        for (int i = 0; i < Database.GetInstance().ClientSize(); i++)
                        {
                            dataGridView3.Rows.Add();
                            NumRows2 += 1;
                            HashFunction<int> myHashFunction = Database.GetInstance().ClientsFunction();
                            dataGridView3.Rows[NumRows2].Cells[0].Value = myHashFunction.Hash(clientArray[i].GetKey());
                            dataGridView3.Rows[NumRows2].Cells[1].Value = clientArray[i].CardNumber;
                            dataGridView3.Rows[NumRows2].Cells[2].Value = clientArray[i].BankName;
                            dataGridView3.Rows[NumRows2].Cells[3].Value = clientArray[i].Name;
                        }
                    }
                    else
                    {
                        ErrorForm ErrorWindow = new ErrorForm();
                        ErrorWindow.label1.Text = res.Message;
                        ErrorWindow.ShowDialog();
                    }
                }
                else
                {
                    ErrorForm ErrorWindow = new ErrorForm();
                    ErrorWindow.label1.Text = "Нарушение уникальности ключа <Номер карточки>";
                    ErrorWindow.ShowDialog();
                }
            }
            else
            {
                stopflag = false;
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tree1Dialog DialogWindow3 = new Tree1Dialog();
            DialogWindow3.ShowDialog();
            if (!stopflag)
                {
                Percent NewPercent = new Percent(Convert.ToString(DialogWindow3.waterMarkTextBox1.Text),
                           Convert.ToString(DialogWindow3.waterMarkTextBox2.Text),
                           Convert.ToString(DialogWindow3.waterMarkTextBox3.Text),
                           Convert.ToInt32(DialogWindow3.waterMarkTextBox4.Text));
                Result res = Database.GetInstance().AddPercent(NewPercent);
                if (res.Success)
                {
                    dataGridView2.Rows.Clear();
                    NumRows3 = -1;
                    Percent[] percentArray = Database.GetInstance().PercentArray();
                    for (int i = 0; i < Database.GetInstance().PercentSize(); i++)
                    {
                        dataGridView2.Rows.Add();
                        NumRows3 += 1;
                        dataGridView2.Rows[NumRows3].Cells[0].Value = percentArray[i].OperationName;
                        dataGridView2.Rows[NumRows3].Cells[1].Value = percentArray[i].SenderBank;
                        dataGridView2.Rows[NumRows3].Cells[2].Value = percentArray[i].ReceiverBank;
                        dataGridView2.Rows[NumRows3].Cells[3].Value = percentArray[i].Percent1;
                    }
                }
                else
                {
                    ErrorForm ErrorWindow = new ErrorForm();
                    ErrorWindow.label1.Text = res.Message;
                    ErrorWindow.ShowDialog();
                }
            }
            else
            {
                stopflag = false;
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tree2Dialog DialogWindow4 = new Tree2Dialog();
            DialogWindow4.ShowDialog();
            if (!stopflag)
            {
                Operation NewOperation = new Operation(Convert.ToString(DialogWindow4.waterMarkTextBox1.Text),
                        Convert.ToInt32(DialogWindow4.waterMarkTextBox2.Text),
                        Convert.ToInt32(DialogWindow4.waterMarkTextBox3.Text),
                        Convert.ToInt32(DialogWindow4.waterMarkTextBox4.Text));
                Result res = Database.GetInstance().AddOperation(NewOperation);
                if (res.Success)
                {
                    dataGridView4.Rows.Clear();
                    NumRows4 = -1;
                    Operation[] operationArray = Database.GetInstance().OperationArray();
                    for (int i = 0; i < Database.GetInstance().OperationSize(); i++)
                    {
                        dataGridView4.Rows.Add();
                        NumRows4 += 1;
                        dataGridView4.Rows[NumRows4].Cells[0].Value = operationArray[i].OperationName;
                        dataGridView4.Rows[NumRows4].Cells[1].Value = operationArray[i].CardNumber;
                        dataGridView4.Rows[NumRows4].Cells[2].Value = operationArray[i].MachineNumber;
                        dataGridView4.Rows[NumRows4].Cells[3].Value = operationArray[i].Sum;
                    }
                }
                else
                {
                    dataGridView4.Rows.RemoveAt(NumRows4);
                    NumRows4 -= 1;
                    ErrorForm ErrorWindow = new ErrorForm();
                    ErrorWindow.label1.Text = res.Message;
                    ErrorWindow.ShowDialog();
                }
            }
            else
            {
                stopflag = false;
                return;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index1 = e.RowIndex;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (index1 != -1)
            {
                Machine removableMachine = new Machine(Convert.ToInt32(dataGridView1.Rows[index1].Cells[1].Value), Convert.ToString(dataGridView1.Rows[index1].Cells[2].Value), Convert.ToString(dataGridView1.Rows[index1].Cells[3].Value));
                Result res = Database.GetInstance().RemoveMachine(removableMachine);
                if (res.Success)
                {
                    dataGridView1.Rows.Clear();
                    NumRows1 = -1;
                    Machine[] machineArray = Database.GetInstance().MachineArray();
                    for (int i = 0; i < Database.GetInstance().MachineSize(); i++)
                    {
                        dataGridView1.Rows.Add();
                        NumRows1 += 1;
                        HashFunction<int> myHashFunction = Database.GetInstance().MachinesFunction();
                        dataGridView1.Rows[NumRows1].Cells[0].Value = myHashFunction.Hash(machineArray[i].GetKey());
                        dataGridView1.Rows[NumRows1].Cells[1].Value = machineArray[i].MachineNumber;
                        dataGridView1.Rows[NumRows1].Cells[2].Value = machineArray[i].Address;
                        dataGridView1.Rows[NumRows1].Cells[3].Value = machineArray[i].BankName;
                    }
                }
                else
                {
                    ErrorForm ErrorWindow = new ErrorForm();
                    ErrorWindow.label1.Text = res.Message;
                    ErrorWindow.ShowDialog();
                    return;
                }
                if (index1 == -1)
                {

                }
                else
                {
                    index1 -= 1;
                };
            }
            else
            {
                if ((index1 == -1) && (dataGridView1.Rows.Count >= 1))
                    index1 = 0;
                else return;
                Machine removableMachine = new Machine(Convert.ToInt32(dataGridView1.Rows[index1].Cells[1].Value), Convert.ToString(dataGridView1.Rows[index1].Cells[2].Value), Convert.ToString(dataGridView1.Rows[index1].Cells[3].Value));
                Result res = Database.GetInstance().RemoveMachine(removableMachine);
                if (res.Success)
                {
                    dataGridView1.Rows.Clear();
                    NumRows1 = -1;
                    Machine[] machineArray = Database.GetInstance().MachineArray();
                    for (int i = 0; i < Database.GetInstance().MachineSize(); i++)
                    {
                        dataGridView1.Rows.Add();
                        NumRows1 += 1;
                        HashFunction<int> myHashFunction = Database.GetInstance().MachinesFunction();
                        dataGridView1.Rows[NumRows1].Cells[0].Value = myHashFunction.Hash(machineArray[i].GetKey());
                        dataGridView1.Rows[NumRows1].Cells[1].Value = machineArray[i].MachineNumber;
                        dataGridView1.Rows[NumRows1].Cells[2].Value = machineArray[i].Address;
                        dataGridView1.Rows[NumRows1].Cells[3].Value = machineArray[i].BankName;
                    }
                }
                else
                {
                    ErrorForm ErrorWindow = new ErrorForm();
                    ErrorWindow.label1.Text = res.Message;
                    ErrorWindow.ShowDialog();
                    return;
                }
                if (index1 == -1)
                {
                    
                }
                else
                {
                    index1 -= 1;
                };
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (index2 != -1)
            {
                Client removableClient = new Client(Convert.ToInt32(dataGridView3.Rows[index2].Cells[1].Value), Convert.ToString(dataGridView3.Rows[index2].Cells[2].Value), Convert.ToString(dataGridView3.Rows[index2].Cells[3].Value));
                Result res = Database.GetInstance().RemoveClient(removableClient);
                if (res.Success)
                {
                    dataGridView3.Rows.Clear();
                    NumRows2 = -1;
                    Client[] clientArray = Database.GetInstance().ClientArray();
                    for (int i = 0; i < Database.GetInstance().ClientSize(); i++)
                    {
                        dataGridView3.Rows.Add();
                        NumRows2 += 1;
                        HashFunction<int> myHashFunction = Database.GetInstance().ClientsFunction();
                        dataGridView3.Rows[NumRows2].Cells[0].Value = myHashFunction.Hash(clientArray[i].GetKey());
                        dataGridView3.Rows[NumRows2].Cells[1].Value = clientArray[i].CardNumber;
                        dataGridView3.Rows[NumRows2].Cells[2].Value = clientArray[i].BankName;
                        dataGridView3.Rows[NumRows2].Cells[3].Value = clientArray[i].Name;
                    }
                }
                else
                {
                    ErrorForm ErrorWindow = new ErrorForm();
                    ErrorWindow.label1.Text = res.Message;
                    ErrorWindow.ShowDialog();
                    return;
                }
                if (index2 == -1)
                {

                }
                else
                {
                    index2 -= 1;
                };
            }
            else
            {
                if ((index2 == -1) && (dataGridView3.Rows.Count >= 1))
                    index2 = 0;
                else return;
                Client removableClient = new Client(Convert.ToInt32(dataGridView3.Rows[index2].Cells[1].Value), Convert.ToString(dataGridView3.Rows[index2].Cells[2].Value), Convert.ToString(dataGridView3.Rows[index2].Cells[3].Value));
                Result res = Database.GetInstance().RemoveClient(removableClient);
                if (res.Success)
                {
                    dataGridView3.Rows.Clear();
                    NumRows2 = -1;
                    Client[] clientArray = Database.GetInstance().ClientArray();
                    for (int i = 0; i < Database.GetInstance().ClientSize(); i++)
                    {
                        dataGridView3.Rows.Add();
                        NumRows2 += 1;
                        HashFunction<int> myHashFunction = Database.GetInstance().ClientsFunction();
                        dataGridView3.Rows[NumRows2].Cells[0].Value = myHashFunction.Hash(clientArray[i].GetKey());
                        dataGridView3.Rows[NumRows2].Cells[1].Value = clientArray[i].CardNumber;
                        dataGridView3.Rows[NumRows2].Cells[2].Value = clientArray[i].BankName;
                        dataGridView3.Rows[NumRows2].Cells[3].Value = clientArray[i].Name;
                    }
                }
                else
                {
                    ErrorForm ErrorWindow = new ErrorForm();
                    ErrorWindow.label1.Text = res.Message;
                    ErrorWindow.ShowDialog();
                    return;
                }
                if (index2 == -1)
                {

                }
                else
                {
                    index2 -= 1;
                };
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (index3 != -1)
            {
                Percent removablePercent = new Percent(Convert.ToString(dataGridView2.Rows[index3].Cells[0].Value), Convert.ToString(dataGridView2.Rows[index3].Cells[1].Value), Convert.ToString(dataGridView2.Rows[index3].Cells[2].Value), Convert.ToInt32(dataGridView2.Rows[index3].Cells[3].Value));
                Result res = Database.GetInstance().RemovePercent(removablePercent);
                if (res.Success)
                {
                    dataGridView2.Rows.Clear();
                    NumRows3 = -1;
                    Percent[] percentArray = Database.GetInstance().PercentArray();
                    for (int i = 0; i < Database.GetInstance().PercentSize(); i++)
                    {
                        dataGridView2.Rows.Add();
                        NumRows3 += 1;
                        dataGridView2.Rows[NumRows3].Cells[0].Value = percentArray[i].OperationName;
                        dataGridView2.Rows[NumRows3].Cells[1].Value = percentArray[i].SenderBank;
                        dataGridView2.Rows[NumRows3].Cells[2].Value = percentArray[i].ReceiverBank;
                        dataGridView2.Rows[NumRows3].Cells[3].Value = percentArray[i].Percent1;
                    }
                }
                else
                {
                    ErrorForm ErrorWindow = new ErrorForm();
                    ErrorWindow.label1.Text = res.Message;
                    ErrorWindow.ShowDialog();
                    return;
                }
                if (index3 == -1)
                {

                }
                else
                {
                    index3 -= 1;
                };
            }
            else
            {
                if ((index3 == -1) && (dataGridView2.Rows.Count >= 1))
                    index3 = 0;
                else return;
                Percent removablePercent = new Percent(Convert.ToString(dataGridView2.Rows[index3].Cells[0].Value), Convert.ToString(dataGridView2.Rows[index3].Cells[1].Value), Convert.ToString(dataGridView2.Rows[index3].Cells[2].Value), Convert.ToInt32(dataGridView2.Rows[index3].Cells[3].Value));
                Result res = Database.GetInstance().RemovePercent(removablePercent);
                if (res.Success)
                {
                    dataGridView2.Rows.Clear();
                    NumRows3 = -1;
                    Percent[] percentArray = Database.GetInstance().PercentArray();
                    for (int i = 0; i < Database.GetInstance().PercentSize(); i++)
                    {
                        dataGridView2.Rows.Add();
                        NumRows3 += 1;
                        dataGridView2.Rows[NumRows3].Cells[0].Value = percentArray[i].OperationName;
                        dataGridView2.Rows[NumRows3].Cells[1].Value = percentArray[i].SenderBank;
                        dataGridView2.Rows[NumRows3].Cells[2].Value = percentArray[i].ReceiverBank;
                        dataGridView2.Rows[NumRows3].Cells[3].Value = percentArray[i].Percent1;
                    }
                }
                else
                {
                    ErrorForm ErrorWindow = new ErrorForm();
                    ErrorWindow.label1.Text = res.Message;
                    ErrorWindow.ShowDialog();
                    return;
                }
                if (index3 == -1)
                {

                }
                else
                {
                    index3 -= 1;
                };
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (index4 != -1)
            {
                Operation removableOperation = new Operation(Convert.ToString(dataGridView4.Rows[index4].Cells[0].Value), Convert.ToInt32(dataGridView4.Rows[index4].Cells[1].Value), Convert.ToInt32(dataGridView4.Rows[index4].Cells[2].Value), Convert.ToInt32(dataGridView4.Rows[index4].Cells[3].Value));
                Result res = Database.GetInstance().RemoveOperation(removableOperation);
                if (res.Success)
                {
                    dataGridView4.Rows.Clear();
                    NumRows4 = -1;
                    Operation[] operationArray = Database.GetInstance().OperationArray();
                    for (int i = 0; i < Database.GetInstance().OperationSize(); i++)
                    {
                        dataGridView4.Rows.Add();
                        NumRows4 += 1;
                        dataGridView4.Rows[NumRows4].Cells[0].Value = operationArray[i].OperationName;
                        dataGridView4.Rows[NumRows4].Cells[1].Value = operationArray[i].CardNumber;
                        dataGridView4.Rows[NumRows4].Cells[2].Value = operationArray[i].MachineNumber;
                        dataGridView4.Rows[NumRows4].Cells[3].Value = operationArray[i].Sum;
                    }
                }
                else
                {
                    ErrorForm ErrorWindow = new ErrorForm();
                    ErrorWindow.label1.Text = res.Message;
                    ErrorWindow.ShowDialog();
                    return;
                }
                if (index4 == -1)
                {

                }
                else
                {
                    index4 -= 1;
                };
            }
            else
            {
                if ((index4 == -1) && (dataGridView4.Rows.Count >= 1))
                    index4 = 0;
                else return;
                Operation removableOperation = new Operation(Convert.ToString(dataGridView4.Rows[index4].Cells[0].Value), Convert.ToInt32(dataGridView4.Rows[index4].Cells[1].Value), Convert.ToInt32(dataGridView4.Rows[index4].Cells[2].Value), Convert.ToInt32(dataGridView4.Rows[index4].Cells[3].Value));
                Result res = Database.GetInstance().RemoveOperation(removableOperation);
                if (res.Success)
                {
                    dataGridView4.Rows.Clear();
                    NumRows4 = -1;
                    Operation[] operationArray = Database.GetInstance().OperationArray();
                    for (int i = 0; i < Database.GetInstance().OperationSize(); i++)
                    {
                        dataGridView4.Rows.Add();
                        NumRows4 += 1;
                        dataGridView4.Rows[NumRows4].Cells[0].Value = operationArray[i].OperationName;
                        dataGridView4.Rows[NumRows4].Cells[1].Value = operationArray[i].CardNumber;
                        dataGridView4.Rows[NumRows4].Cells[2].Value = operationArray[i].MachineNumber;
                        dataGridView4.Rows[NumRows4].Cells[3].Value = operationArray[i].Sum;
                    }
                }
                else
                {
                    ErrorForm ErrorWindow = new ErrorForm();
                    ErrorWindow.label1.Text = res.Message;
                    ErrorWindow.ShowDialog();
                    return;
                }
                if (index4 == -1)
                {

                }
                else
                {
                    index4 -= 1;
                };
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index2 = e.RowIndex;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index3 = e.RowIndex;
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index4 = e.RowIndex;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int NumRowsF1 = -1;
            int NumRowsF2 = -1;
            int NumRowsF3 = -1;
            int NumRowsF4 = -1;
            int l = 0;
            string errormessage = "";
            string pole = "";
            string pole1 = "";
            string pole2 = "";
            MachineFound machineFound = new MachineFound();
            ClientFound clientFound = new ClientFound();
            operationFound operationfound = new operationFound();
            percentFound percentfound = new percentFound();
            if (!(waterMarkTextBox1.Text == ""))
            {
                if (Convert.ToString(comboBox1.SelectedItem) == "Банкомат")
                {
                    if (!Checks.IsNumber(waterMarkTextBox1.Text))
                    {
                        errormessage = errormessage + "Неверный формат данных в строке поиска\n";
                    }
                    if (Checks.IsNumber(waterMarkTextBox1.Text) && (!Checks.IsValidNumber(Convert.ToInt32(waterMarkTextBox1.Text),1,500)))
                    {
                        errormessage = errormessage + "Значение " + waterMarkTextBox1.Text + " не попадает в допустимый диапазон строки поиска 1..500\n";
                    }
                    if (errormessage == "")
                    {
                        SearchQuery<Machine> query = Database.GetInstance().FindMachine(Convert.ToInt32(waterMarkTextBox1.Text));
                        if (query.Found())
                        {
                            string data = string.Empty;
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                data = Convert.ToString(row.Cells[1].Value);
                                if (data == waterMarkTextBox1.Text)
                                {
                                    machineFound.MachineResults.Rows.Add();
                                    NumRowsF1 += 1;
                                    machineFound.MachineResults.Rows[NumRowsF1].Cells[0].Value = row.Cells[0].Value;
                                    machineFound.MachineResults.Rows[NumRowsF1].Cells[1].Value = row.Cells[1].Value;
                                    machineFound.MachineResults.Rows[NumRowsF1].Cells[2].Value = row.Cells[2].Value;
                                    machineFound.MachineResults.Rows[NumRowsF1].Cells[3].Value = row.Cells[3].Value;
                                }
                            }
                            machineFound.label3.Text = Convert.ToString(query.Counter);
                            machineFound.ShowDialog();
                        }
                        else
                        {
                            machineFound.label3.Text = Convert.ToString(query.Counter);
                            machineFound.ShowDialog();
                        }
                    }
                    else
                    {
                        ErrorForm ErrorWindow = new ErrorForm();
                        ErrorWindow.label1.Text = errormessage;
                        ErrorWindow.ShowDialog();
                    }
                }
                if (Convert.ToString(comboBox1.SelectedItem) == "Клиент")
                {
                    if (!Checks.IsNumber(waterMarkTextBox1.Text))
                    {
                        errormessage = errormessage + "Неверный формат данных в строке поиска\n";
                    }
                    if (Checks.IsNumber(waterMarkTextBox1.Text) && (!Checks.IsValidNumber(Convert.ToInt32(waterMarkTextBox1.Text), 1, 99999999)))
                    {
                        errormessage = errormessage + "Значение " + waterMarkTextBox1.Text + " не попадает в допустимый диапазон строки поиска 1..99999999\n";
                    }
                    if (errormessage == "")
                    {
                        SearchQuery<Client> query = Database.GetInstance().FindClient(Convert.ToInt32(waterMarkTextBox1.Text));
                        if (query.Found())
                        {
                            string data = string.Empty;
                            foreach (DataGridViewRow row in dataGridView3.Rows)
                            {
                                data = Convert.ToString(row.Cells[1].Value);
                                if (data == waterMarkTextBox1.Text)
                                {
                                    clientFound.ClientResults.Rows.Add();
                                    NumRowsF2 += 1;
                                    clientFound.ClientResults.Rows[NumRowsF2].Cells[0].Value = row.Cells[0].Value;
                                    clientFound.ClientResults.Rows[NumRowsF2].Cells[1].Value = row.Cells[1].Value;
                                    clientFound.ClientResults.Rows[NumRowsF2].Cells[2].Value = row.Cells[2].Value;
                                    clientFound.ClientResults.Rows[NumRowsF2].Cells[3].Value = row.Cells[3].Value;
                                }
                            }
                            clientFound.label1.Text = Convert.ToString(query.Counter);
                            clientFound.ShowDialog();
                        }
                        else
                        {
                            clientFound.label1.Text = Convert.ToString(query.Counter);
                            clientFound.ShowDialog();
                        }
                    }
                    else
                    {
                        ErrorForm ErrorWindow = new ErrorForm();
                        ErrorWindow.label1.Text = errormessage;
                        ErrorWindow.ShowDialog();
                    }
                }
                if (Convert.ToString(comboBox1.SelectedItem) == "Операция")
                {
                    if (waterMarkTextBox1.Text[waterMarkTextBox1.Text.Length - 1] == '/')
                    {
                        for (int i = 0; i < waterMarkTextBox1.Text.Length; i++)
                        {
                            while (waterMarkTextBox1.Text[i] != '/')
                            {
                                pole = pole + waterMarkTextBox1.Text[i];
                                i++;
                            }
                            l = i;
                            break;
                        }
                        for (int i = l + 1; i < waterMarkTextBox1.Text.Length; i++)
                        {
                            while (waterMarkTextBox1.Text[i] != '/')
                            {
                                pole1 = pole1 + waterMarkTextBox1.Text[i];
                                i++;
                            }
                            l = i;
                            break;
                        }
                        for (int i = l + 1; i < waterMarkTextBox1.Text.Length; i++)
                        {
                            while (waterMarkTextBox1.Text[i] != '/')
                            {
                                pole2 = pole2 + waterMarkTextBox1.Text[i];
                                i++;
                            }
                        }
                        if (!Checks.IsWord(pole, false))
                        {
                            errormessage = errormessage + "Неверный формат данных в поле <Название операции>\n";
                        }
                        if (pole.Length > 20)
                        {
                            errormessage = errormessage + "Слишком длинное поле <Название операции> (более 20 символов)\n";
                        }
                        if (!Checks.IsFirstLetterBig(pole))
                        {
                            errormessage = errormessage + "Поле <Название операции> должно начинаться с заглавной буквы\n";
                        }
                        if (Checks.IsFirstLetterBig(pole) && (Checks.CountBigLetters(pole) > 1))
                        {
                            errormessage = errormessage + "В поле <Название операции> не может быть более одной заглавной буквы\n";
                        }
                        if (!Checks.IsNumber(pole1))
                        {
                            errormessage = errormessage + "Неверный формат данных в поле <Номер карточки>\n";
                        }
                        if (Checks.IsNumber(pole1) && (!Checks.IsValidNumber(Convert.ToInt32(pole1), 1, 99999999)))
                        {
                            errormessage = errormessage + "Значение " + pole1 + " не попадает в допустимый диапазон поля <Номер карточки> 1..99999999\n";
                        }
                        if (!Checks.IsNumber(pole2))
                        {
                            errormessage = errormessage + "Неверный формат данных в поле <Номер банкомата>\n";
                        }
                        if (Checks.IsNumber(pole2) && (!Checks.IsValidNumber(Convert.ToInt32(pole2), 1, 500)))
                        {
                            errormessage = errormessage + "Значение " + pole2 + " не попадает в допустимый диапазон поля <Номер банкомата> 1..500\n";
                        }
                        if ((pole == "") || (pole1 == "") || (pole2 == ""))
                        {
                            errormessage = errormessage + "Некорректный формат данных в строке поиска\n";
                        }
                    }
                    else errormessage = errormessage + "Не обнаружен / в конце строки поиска\n";
                    if (errormessage == "")
                    {
                        SearchQuery<Operation> query = Database.GetInstance().FindOperation(pole, Convert.ToInt32(pole1), Convert.ToInt32(pole2));
                        if (query.Found())
                        {
                            string data1 = string.Empty;
                            string data2 = string.Empty;
                            string data3 = string.Empty;
                            foreach (DataGridViewRow row in dataGridView4.Rows)
                            {
                                data1 = Convert.ToString(row.Cells[0].Value);
                                data2 = Convert.ToString(row.Cells[1].Value);
                                data3 = Convert.ToString(row.Cells[2].Value);
                                if ((data1 == pole) && (data2 == pole1) && (data3 == pole2))
                                {
                                    operationfound.operationResults.Rows.Add();
                                    NumRowsF3 += 1;
                                    operationfound.operationResults.Rows[NumRowsF3].Cells[0].Value = row.Cells[0].Value;
                                    operationfound.operationResults.Rows[NumRowsF3].Cells[1].Value = row.Cells[1].Value;
                                    operationfound.operationResults.Rows[NumRowsF3].Cells[2].Value = row.Cells[2].Value;
                                    operationfound.operationResults.Rows[NumRowsF3].Cells[3].Value = row.Cells[3].Value;
                                }
                            }
                            operationfound.label1.Text = Convert.ToString(query.Counter);
                            operationfound.ShowDialog();
                        }
                        else
                        {
                            operationfound.label1.Text = Convert.ToString(query.Counter);
                            operationfound.ShowDialog();
                        }
                    }
                    else
                    {
                        ErrorForm ErrorWindow = new ErrorForm();
                        ErrorWindow.label1.Text = errormessage;
                        ErrorWindow.ShowDialog();
                    }
                }
                if (Convert.ToString(comboBox1.SelectedItem) == "Процент")
                {
                    if (waterMarkTextBox1.Text[waterMarkTextBox1.Text.Length - 1] == '/')
                    {
                        for (int i = 0; i < waterMarkTextBox1.Text.Length; i++)
                        {
                            while (waterMarkTextBox1.Text[i] != '/')
                            {
                                pole = pole + waterMarkTextBox1.Text[i];
                                i++;
                            }
                            l = i;
                            break;
                        }
                        for (int i = l + 1; i < waterMarkTextBox1.Text.Length; i++)
                        {
                            while (waterMarkTextBox1.Text[i] != '/')
                            {
                                pole1 = pole1 + waterMarkTextBox1.Text[i];
                                i++;
                            }
                            l = i;
                            break;
                        }
                        for (int i = l + 1; i < waterMarkTextBox1.Text.Length; i++)
                        {
                            while (waterMarkTextBox1.Text[i] != '/')
                            {
                                pole2 = pole2 + waterMarkTextBox1.Text[i];
                                i++;
                            }
                        }
                        if (!Checks.IsWord(pole, false))
                        {
                            errormessage = errormessage + "Неверный формат данных в поле <Название операции>\n";
                        }
                        if (pole.Length > 20)
                        {
                            errormessage = errormessage + "Слишком длинное поле <Название операции> (более 20 символов)\n";
                        }
                        if (!Checks.IsFirstLetterBig(pole))
                        {
                            errormessage = errormessage + "Поле <Название операции> должно начинаться с заглавной буквы\n";
                        }
                        if (Checks.IsFirstLetterBig(pole) && (Checks.CountBigLetters(pole) > 1))
                        {
                            errormessage = errormessage + "В поле <Название операции> не может быть более одной заглавной буквы\n";
                        }
                        if (!Checks.IsWord(pole1, false))
                        {
                            errormessage = errormessage + "Неверный формат данных в поле <Банк-отправитель>\n";
                        }
                        if (pole1.Length > 20)
                        {
                            errormessage = errormessage + "Слишком длинное поле <Банк-отправитель (более 20 символов)\n";
                        }
                        if (!Checks.IsFirstLetterBig(pole1))
                        {
                            errormessage = errormessage + "Поле <Банк-отправитель> должно начинаться с заглавной буквы\n";
                        }
                        if (!Checks.IsWord(pole2, false))
                        {
                            errormessage = errormessage + "Неверный формат данных в поле <Банк-получатель>\n";
                        }
                        if (pole2.Length > 20)
                        {
                            errormessage = errormessage + "Слишком длинное поле <Банк-получатель (более 20 символов)\n";
                        }
                        if (!Checks.IsFirstLetterBig(pole2))
                        {
                            errormessage = errormessage + "Поле <Банк-отправитель> должно начинаться с заглавной буквы\n";
                        }
                        if ((pole == "") || (pole1 == "") || (pole2 == ""))
                        {
                            errormessage = errormessage + "Некорректный формат данных в строке поиска\n";
                        }
                    }
                    else errormessage = errormessage + "Не обнаружен / в конце строки поиска\n";
                    if (errormessage == "")
                    {
                        SearchQuery<Percent> query = Database.GetInstance().FindPercent(pole, pole1, pole2);
                        if (query.Found())
                        {
                            string data1 = string.Empty;
                            string data2 = string.Empty;
                            string data3 = string.Empty;
                            foreach (DataGridViewRow row in dataGridView2.Rows)
                            {
                                data1 = Convert.ToString(row.Cells[0].Value);
                                data2 = Convert.ToString(row.Cells[1].Value);
                                data3 = Convert.ToString(row.Cells[2].Value);
                                if ((data1 == pole) && (data2 == pole1) && (data3 == pole2))
                                {
                                    percentfound.percentResults.Rows.Add();
                                    NumRowsF4 += 1;
                                    percentfound.percentResults.Rows[NumRowsF4].Cells[0].Value = row.Cells[0].Value;
                                    percentfound.percentResults.Rows[NumRowsF4].Cells[1].Value = row.Cells[1].Value;
                                    percentfound.percentResults.Rows[NumRowsF4].Cells[2].Value = row.Cells[2].Value;
                                    percentfound.percentResults.Rows[NumRowsF4].Cells[3].Value = row.Cells[3].Value;
                                }
                            }
                            percentfound.label3.Text = Convert.ToString(query.Counter);
                            percentfound.ShowDialog();
                        }
                        else
                        {
                            percentfound.label3.Text = Convert.ToString(query.Counter);
                            percentfound.ShowDialog();
                        }
                    }
                    else
                    {
                        ErrorForm ErrorWindow = new ErrorForm();
                        ErrorWindow.label1.Text = errormessage;
                        ErrorWindow.ShowDialog();
                    }
                }
            }
            else
            {
                ErrorForm ErrorWindow = new ErrorForm();
                ErrorWindow.label1.Text = "Строка поиска не может быть пустой";
                ErrorWindow.ShowDialog();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (comboBox1.SelectedItem.ToString() == "Банкомат")
           {
              state = "Введите номер банкомата";
           }
           if (comboBox1.SelectedItem.ToString() == "Клиент")
           {
              state = "Введите номер карточки клиента";
           }
           if (comboBox1.SelectedItem.ToString() == "Операция")
           {
              state = "Введите Название операции/номер карточки/номер банкомата/ (Пример: А/1/1/)";
           }
           if (comboBox1.SelectedItem.ToString() == "Процент")
           {
              state = "Введите Название операции/Банк-отправитель/Банк-получатель/ (Пример: А/А/А/)";
           }
           waterMarkTextBox1.WaterMarkText = state;
        }

        private void операцииПоКлиентуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperationsOfClient OOC = new OperationsOfClient();
            foreach (DataGridViewRow r in dataGridView3.Rows)
            {
                int index = OOC.ClientsKey.Rows.Add(r.Clone() as DataGridViewRow);
                foreach (DataGridViewCell o in r.Cells)
                {
                    OOC.ClientsKey.Rows[index].Cells[o.ColumnIndex].Value = o.Value;
                }
            }
            if (OOC.ClientsKey.RowCount != 0)
            {
                int NumRows = -1;
                int index1 = 0;
                Client keyClient = new Client(Convert.ToInt32(OOC.ClientsKey.Rows[index1].Cells[1].Value), Convert.ToString(OOC.ClientsKey.Rows[index1].Cells[2].Value), Convert.ToString(OOC.ClientsKey.Rows[index1].Cells[3].Value));
                Report<Client, Operation> report = Database.GetInstance().ClientOperationReport(keyClient);
                Operation[] arr = report.Data();
                int size = report.DataSize();
                for (int i = 0; i < size; i++)
                {
                    OOC.OperationsData.Rows.Add();
                    NumRows += 1;
                    OOC.OperationsData.Rows[NumRows].Cells[0].Value = arr[i].OperationName;
                    OOC.OperationsData.Rows[NumRows].Cells[1].Value = arr[i].CardNumber;
                    OOC.OperationsData.Rows[NumRows].Cells[2].Value = arr[i].MachineNumber;
                    OOC.OperationsData.Rows[NumRows].Cells[3].Value = arr[i].Sum;
                }
                NumRows = -1;
            }
            OOC.ShowDialog();
        }

        private void операцииБанкоматаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperationsOfMachine OOM = new OperationsOfMachine();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                int index = OOM.MachinesKey.Rows.Add(r.Clone() as DataGridViewRow);
                foreach (DataGridViewCell o in r.Cells)
                {
                    OOM.MachinesKey.Rows[index].Cells[o.ColumnIndex].Value = o.Value;
                }
            }
            if (OOM.MachinesKey.RowCount != 0)
            {
                int NumRows = -1;
                int index1 = 0;
                Machine keyMachine = new Machine(Convert.ToInt32(OOM.MachinesKey.Rows[index1].Cells[1].Value),
                            Convert.ToString(OOM.MachinesKey.Rows[index1].Cells[2].Value), Convert.ToString(OOM.MachinesKey.Rows[index1].Cells[3].Value));
                Report<Machine, Operation> report = Database.GetInstance().MachineOperationReport(keyMachine);
                Operation[] arr = report.Data();
                int size = report.DataSize();
                for (int i = 0; i < size; i++)
                {
                    OOM.OperationsData.Rows.Add();
                    NumRows += 1;
                    OOM.OperationsData.Rows[NumRows].Cells[0].Value = arr[i].OperationName;
                    OOM.OperationsData.Rows[NumRows].Cells[1].Value = arr[i].CardNumber;
                    OOM.OperationsData.Rows[NumRows].Cells[2].Value = arr[i].MachineNumber;
                    OOM.OperationsData.Rows[NumRows].Cells[3].Value = arr[i].Sum;
                }
                NumRows = -1;
            }
            OOM.ShowDialog();
        }

        private void процентыОперацийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PercentsOfOperation POO = new PercentsOfOperation();
            foreach (DataGridViewRow r in dataGridView4.Rows)
            {
                int index = POO.OperationsKey.Rows.Add(r.Clone() as DataGridViewRow);
                foreach (DataGridViewCell o in r.Cells)
                {
                    POO.OperationsKey.Rows[index].Cells[o.ColumnIndex].Value = o.Value;
                }
            }
            int NumRows = -1;
            int index1 = 0;
            if (POO.OperationsKey.RowCount != 0)
            {
                Operation keyOperation = new Operation(Convert.ToString(POO.OperationsKey.Rows[index1].Cells[0].Value),
                           Convert.ToInt32(POO.OperationsKey.Rows[index1].Cells[1].Value),
                           Convert.ToInt32(POO.OperationsKey.Rows[index1].Cells[2].Value),
                           Convert.ToInt32(POO.OperationsKey.Rows[index1].Cells[3].Value));
                Report<Operation, Percent> report = Database.GetInstance().OperationPercentReport(keyOperation);
                Percent[] arr = report.Data();
                int size = report.DataSize();
                for (int i = 0; i < size; i++)
                {
                    POO.PercentsData.Rows.Add();
                    NumRows += 1;
                    POO.PercentsData.Rows[NumRows].Cells[0].Value = arr[i].OperationName;
                    POO.PercentsData.Rows[NumRows].Cells[1].Value = arr[i].SenderBank;
                    POO.PercentsData.Rows[NumRows].Cells[2].Value = arr[i].ReceiverBank;
                    POO.PercentsData.Rows[NumRows].Cells[3].Value = arr[i].Percent1;
                }
                NumRows = -1;
            }
            POO.ShowDialog();
        }

        private void процентыБанкоматаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PercentsOfMachine POM = new PercentsOfMachine();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                int index = POM.MachinesKey.Rows.Add(r.Clone() as DataGridViewRow);
                foreach (DataGridViewCell o in r.Cells)
                {
                    POM.MachinesKey.Rows[index].Cells[o.ColumnIndex].Value = o.Value;
                }
            }
            int NumRows = -1;
            int index1 = 0;
            if (POM.MachinesKey.RowCount != 0)
            {
                Machine keyMachine = new Machine(Convert.ToInt32(POM.MachinesKey.Rows[index1].Cells[1].Value),
                            Convert.ToString(POM.MachinesKey.Rows[index1].Cells[2].Value), Convert.ToString(POM.MachinesKey.Rows[index1].Cells[3].Value));
                Report<Machine, Percent> report = Database.GetInstance().MachinePercentReport(keyMachine);
                Percent[] arr = report.Data();
                int size = report.DataSize();
                for (int i = 0; i < size; i++)
                {
                    POM.PercentsData.Rows.Add();
                    NumRows += 1;
                    POM.PercentsData.Rows[NumRows].Cells[0].Value = arr[i].OperationName;
                    POM.PercentsData.Rows[NumRows].Cells[1].Value = arr[i].SenderBank;
                    POM.PercentsData.Rows[NumRows].Cells[2].Value = arr[i].ReceiverBank;
                    POM.PercentsData.Rows[NumRows].Cells[3].Value = arr[i].Percent1;
                }
                NumRows = -1;
            }
            POM.ShowDialog();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Сохранить базу данных";
            saveFile.OverwritePrompt = true;
            saveFile.InitialDirectory = Application.StartupPath;
            saveFile.RestoreDirectory = true;
            saveFile.DefaultExt = ".txt";
            saveFile.Filter = "Text documents (.txt)|*.txt|kostil (.kostil)|*.kostil";
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFile.FileName.Length > 0)
            {
                Result res = Database.GetInstance().Save(saveFile.FileName);
                if (res.Success == false)
                {
                    ErrorForm ErrorWindow = new ErrorForm();
                    ErrorWindow.label1.Text = res.Message;
                    ErrorWindow.ShowDialog();
                }
            }
        }

        private void импортироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Загрузить базу данных";
            openFile.CheckFileExists = true;
            openFile.InitialDirectory = Application.StartupPath;
            openFile.RestoreDirectory = true;
            openFile.DefaultExt = ".txt";
            openFile.Filter = "Text documents (.txt)|*.txt|kostil (.kostil)|*.kostil";
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFile.FileName.Length > 0)
            {
                try
                {
                    Result res = Database.LoadInstance(openFile.FileName);
                    if (res.Success == false)
                    {
                        ErrorForm ErrorWindow = new ErrorForm();
                        ErrorWindow.label1.Text = res.Message;
                        ErrorWindow.ShowDialog();
                        return;
                    }
                }
                catch
                {
                    ErrorForm ErrorWindow = new ErrorForm();
                    ErrorWindow.label1.Text = "Некорректный формат загружаемого файла";
                    ErrorWindow.ShowDialog();
                    return;
                }
            }
            dataGridView1.Rows.Clear();
            NumRows1 = -1;
            Machine[] machineArray = Database.GetInstance().MachineArray();
            for (int i = 0; i < Database.GetInstance().MachineSize(); i++)
            {
                dataGridView1.Rows.Add();
                NumRows1 += 1;
                HashFunction<int> myHashFunction = Database.GetInstance().MachinesFunction();
                dataGridView1.Rows[NumRows1].Cells[0].Value = myHashFunction.Hash(machineArray[i].GetKey());
                dataGridView1.Rows[NumRows1].Cells[1].Value = machineArray[i].MachineNumber;
                dataGridView1.Rows[NumRows1].Cells[2].Value = machineArray[i].Address;
                dataGridView1.Rows[NumRows1].Cells[3].Value = machineArray[i].BankName;
            }
            dataGridView3.Rows.Clear();
            NumRows2 = -1;
            Client[] clientArray = Database.GetInstance().ClientArray();
            for (int i = 0; i < Database.GetInstance().ClientSize(); i++)
            {
                dataGridView3.Rows.Add();
                NumRows2 += 1;
                HashFunction<int> myHashFunction = Database.GetInstance().ClientsFunction();
                dataGridView3.Rows[NumRows2].Cells[0].Value = myHashFunction.Hash(clientArray[i].GetKey());
                dataGridView3.Rows[NumRows2].Cells[1].Value = clientArray[i].CardNumber;
                dataGridView3.Rows[NumRows2].Cells[2].Value = clientArray[i].BankName;
                dataGridView3.Rows[NumRows2].Cells[3].Value = clientArray[i].Name;
            }
            dataGridView4.Rows.Clear();
            NumRows4 = -1;
            Operation[] operationArray = Database.GetInstance().OperationArray();
            for (int i = 0; i < Database.GetInstance().OperationSize(); i++)
            {
                dataGridView4.Rows.Add();
                NumRows4 += 1;
                dataGridView4.Rows[NumRows4].Cells[0].Value = operationArray[i].OperationName;
                dataGridView4.Rows[NumRows4].Cells[1].Value = operationArray[i].CardNumber;
                dataGridView4.Rows[NumRows4].Cells[2].Value = operationArray[i].MachineNumber;
                dataGridView4.Rows[NumRows4].Cells[3].Value = operationArray[i].Sum;
            }
            dataGridView2.Rows.Clear();
            NumRows3 = -1;
            Percent[] percentArray = Database.GetInstance().PercentArray();
            for (int i = 0; i < Database.GetInstance().PercentSize(); i++)
            {
                dataGridView2.Rows.Add();
                NumRows3 += 1;
                dataGridView2.Rows[NumRows3].Cells[0].Value = percentArray[i].OperationName;
                dataGridView2.Rows[NumRows3].Cells[1].Value = percentArray[i].SenderBank;
                dataGridView2.Rows[NumRows3].Cells[2].Value = percentArray[i].ReceiverBank;
                dataGridView2.Rows[NumRows3].Cells[3].Value = percentArray[i].Percent1;
            }
            index1 = -1;
            index2 = -1;
            index3 = -1;
            index4 = -1;
            state = "";
        }

        private void создатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Database.GetNewInstance();
            NumRows1 = -1;
            NumRows2 = -1;
            NumRows3 = -1;
            NumRows4 = -1;
            index1 = -1;
            index2 = -1;
            index3 = -1;
            index4 = -1;
            state = "";
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            dataGridView4.Rows.Clear();
        }
    }
}
