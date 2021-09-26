using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercuryassignmentfinal
{
    
    public partial class Form1 : Form
    {
        int cashierCounter;
        int totalTicketsSoldData;
        decimal totalRecieptsSum;
        int adultInputData;
        int studentInputData;
        int childInputData;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            summaryButton.Enabled = false;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            panel3.Enabled = false;
            cashierSummaryData.Visible = true;

            string cashierName = cashierNameInputText.Text;
            this.adultInputData = int.Parse(adultInputDataText.Text);
            this.studentInputData = int.Parse(studentInputDataText.Text);
            this.childInputData = int.Parse(childInputDataText.Text);

            
            int ticketssold = (adultInputData + studentInputData + childInputData);
            totalTicketsSold.Text = ticketssold.ToString();
            cashierNameDisplay.Text = cashierName;
            decimal totalCostOfTickets = ((7.99m * adultInputData) + (4.99m * studentInputData) + (2.99m * childInputData));
            totalReceipts.Text = totalCostOfTickets.ToString("c");
            this.totalRecieptsSum = this.totalRecieptsSum + totalCostOfTickets;


            //cashierSummaryData.Visible = true;
            calculateButton.Enabled = false;
            summaryButton.Enabled = true;

            this.cashierCounter =cashierCounter + 1;
            int sumOfTicketsSold = this.adultInputData + this.studentInputData + this.childInputData;
            this.totalTicketsSoldData = this.totalTicketsSoldData + sumOfTicketsSold;

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            cashierSummaryData.Visible = false;
            companySummaryData.Visible = false;
            panel3.Enabled = true;
            cashierNameInputText.Text = null;
            adultInputDataText.Text = "0";
            studentInputDataText.Text = "0";
            childInputDataText.Text = "0";
            cashierNameDisplay.Text = null;
            totalReceipts.Text = null;
            totalTicketsSold.Text = null;
            calculateButton.Enabled = true;
            summaryButton.Enabled = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            companySummaryData.Visible = true;
            cashierSummaryData.Visible = false;
            textBox3.Text = Convert.ToString(this.cashierCounter);
            textBox2.Text = Convert.ToString(this.totalTicketsSoldData);
            textBox1.Text = this.totalRecieptsSum.ToString("c");
            textBox4.Text = (this.totalRecieptsSum / this.totalTicketsSoldData).ToString("c");
        }
    }
}
