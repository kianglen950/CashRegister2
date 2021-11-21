using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CashRegister2
{
    public partial class crazyCookiesSuppliesForm : Form
    {
        double pansCost = 23.52;
        double knivesCost = 39.39;
        double cuttingBoardsCost = 15.85;
        double panAmount;
        double knifeAmount;
        double cuttingBoardAmount;
        double orderCost;
        double taxRate = 0.13;
        double taxAmount;
        double totalCost;
        double tenderedAmount;
        double changeAmount;
        double pansTotalCost;
        double knivesTotalCost;
        double cuttingBoardsTotalCost;
        SoundPlayer printSound;

        public crazyCookiesSuppliesForm()
        {
            InitializeComponent();
            receiptLabel.Visible = false;
            printSound = new SoundPlayer(Properties.Resources.printSound);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            panAmount = Convert.ToInt32(pansInput.Text);
            knifeAmount = Convert.ToInt32(knivesInput.Text);
            cuttingBoardAmount = Convert.ToInt32(cuttingBoardInput.Text);

            pansTotalCost = pansCost * panAmount;
            knivesTotalCost = knivesCost * knifeAmount;
            cuttingBoardsTotalCost = cuttingBoardsCost * cuttingBoardAmount;

            orderCost = pansTotalCost + knivesTotalCost + cuttingBoardsTotalCost;
            totalCost = orderCost * (1 + taxRate);
            taxAmount = totalCost - orderCost;

            subTotalLabel.Text = $"Subtotal          {orderCost.ToString("C")}";
            taxLabel.Text = $"Tax           {taxAmount.ToString("C")}";
            totalLabel.Text = $"Total           {totalCost.ToString("C")}";

            calculateButton.Enabled = false;
            changeButton.Enabled = true;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            tenderedAmount = Convert.ToInt32(tenderedInput.Text);

            changeAmount = tenderedAmount - totalCost;
            changeLabel.Text = $"Change             {changeAmount.ToString("C")}";
            changeButton.Enabled = false;
            receiptButton.Enabled = true;
        }

        private async void receiptButton_Click(object sender, EventArgs e)
        {
            receiptLabel.Visible = true;
            receiptButton.Enabled = false;
            printSound.Stream.Position = 0; // Makes sure its at the front of the 'sound queue'
            printSound.Play(); // Start playing receipt sound
            receiptLabel.Text = $"Welcome to Crazy Cooking Supplies";
            await Task.Delay(1000);
            receiptLabel.Text += $"\n\n{panAmount} Pans =      {pansTotalCost.ToString("C")}";
            await Task.Delay(1000);
            receiptLabel.Text += $"\n{knifeAmount} Knives =         {knivesTotalCost.ToString("C")}";
            await Task.Delay(1000);
            receiptLabel.Text += $"\n{cuttingBoardAmount} Cutting Boards =      {cuttingBoardsTotalCost.ToString("C")}\n\n";
            await Task.Delay(1000);
            receiptLabel.Text += $"Sub Total =      {orderCost.ToString("C")}";
            await Task.Delay(1000);
            receiptLabel.Text += $"\nTax =       {taxAmount.ToString("C")}";
            await Task.Delay(1000);
            receiptLabel.Text += $"\nTotal =      {totalCost.ToString("C")}";
            await Task.Delay(1000);
            receiptLabel.Text += $"\n\nTendered = {tenderedAmount.ToString("C")}";
            await Task.Delay(1000);
            receiptLabel.Text += $"\nChange = {changeAmount.ToString("C")}";
            await Task.Delay(1000);
            receiptLabel.Text += $"\n\nThank you for shopping at Crazy Cooking Supplies";
            await Task.Delay(1000);
            receiptLabel.Text += $"\nWe hope to see you again soon.";


            newOrderButton.Enabled = true;
            printSound.Stop();
        }



        private void newOrderButton_Click(object sender, EventArgs e)
        {
            pansInput.Text = "0";
            knivesInput.Text = "0";
            cuttingBoardInput.Text = "0";
            tenderedInput.Text = "";
            panAmount = 0;
            knifeAmount = 0;
            cuttingBoardAmount = 0;
            orderCost = 0;
            taxAmount = 0;
            totalCost = 0;
            tenderedAmount = 0;
            changeAmount = 0;
            pansTotalCost = 0;
            knivesTotalCost = 0;
            cuttingBoardsTotalCost = 0;
            newOrderButton.Enabled = false;
            calculateButton.Enabled = true;
            subTotalLabel.Text = "Sub Total";
            taxLabel.Text = " Tax";
            totalLabel.Text = " Total";
            changeLabel.Text = " Change";
            receiptLabel.Text = "";
            receiptLabel.Visible = false;
        }
    }
}
