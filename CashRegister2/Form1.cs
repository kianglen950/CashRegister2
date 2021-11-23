// Cash Register made by Kian Glenfield

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
        //Delcaring the variables
        double pansCost = 23.52;
        double knivesCost = 39.39;
        double cuttingBoardsCost = 15.85;
        double orderCost;
        double totalCost;
        double pansTotalCost;
        double knivesTotalCost;
        double cuttingBoardsTotalCost;

        double taxRate = 0.13;
        double taxAmount;

        double tenderedAmount;
        double changeAmount;
        double panAmount;
        double knifeAmount;
        double cuttingBoardAmount;

        SoundPlayer printSound;

        public crazyCookiesSuppliesForm()
        {
            InitializeComponent();
            receiptLabel.Visible = false; //making the reciept invisible
            printSound = new SoundPlayer(Properties.Resources.printSound);// create the sound
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //get the input and convert into intergers
            panAmount = Convert.ToInt32(pansInput.Text);
            knifeAmount = Convert.ToInt32(knivesInput.Text);
            cuttingBoardAmount = Convert.ToInt32(cuttingBoardInput.Text);
            //calculating the total costs

            pansTotalCost = pansCost * panAmount;
            knivesTotalCost = knivesCost * knifeAmount;
            cuttingBoardsTotalCost = cuttingBoardsCost * cuttingBoardAmount;

            //calculating full costs
            orderCost = pansTotalCost + knivesTotalCost + cuttingBoardsTotalCost;
            totalCost = orderCost * (1 + taxRate);
            //calculating tax
            taxAmount = totalCost - orderCost;
            //displaying the amounts
            subTotalLabel2.Text = $"{orderCost.ToString("C")}";
            taxLabel2.Text = $"{taxAmount.ToString("C")}";
            totalLabel2.Text = $"{totalCost.ToString("C")}";
            
            calculateButton.Enabled = false; //disabling the calculate button
            changeButton.Enabled = true; //enabling the  change button
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            tenderedAmount = Convert.ToInt32(tenderedInput.Text); //converting the input into intergers

            changeAmount = tenderedAmount - totalCost; //calculating the change
            if (tenderedAmount < totalCost)
            {
                changeLabel2.Text = $"Insufficient Funds";
            }
            else
            {
                changeLabel2.Text = $"{changeAmount.ToString("C")}"; //displaying the change amount
                changeButton.Enabled = false; //disabling the change button
                receiptButton.Enabled = true; //enabling the reciept button
            }

           
        }

        private async void receiptButton_Click(object sender, EventArgs e)
        {
            receiptLabel.Visible = true; //making the receipt visible
            receiptButton.Enabled = false; //diabling the reciept button
            printSound.Stream.Position = 0; // Makes sure its at the front of the 'sound queue'
            printSound.Play(); // Start playing receipt sound
            receiptLabel.Text = $"Welcome to Crazy Cooking Supplies"; //showing the text
            if(panAmount > 0)
            {
            await Task.Delay(1000); //delay the next text by a second
            receiptLabel.Text += $"\n\n{panAmount} Pans =      {pansTotalCost.ToString("C")}";
            }
            if(knifeAmount > 0)
            {
            await Task.Delay(1000);
            receiptLabel.Text += $"\n{knifeAmount} Knives =         {knivesTotalCost.ToString("C")}";
            }
            if(cuttingBoardAmount > 0)
            {
            await Task.Delay(1000);
            receiptLabel.Text += $"\n{cuttingBoardAmount} Cutting Boards =      {cuttingBoardsTotalCost.ToString("C")}\n\n";
            }
            await Task.Delay(1000);
            receiptLabel.Text += $"\nSub Total =      {orderCost.ToString("C")}";
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


            newOrderButton.Enabled = true; //enabling the new order button 
            printSound.Stop(); //stopping the sound
        }



        private void newOrderButton_Click(object sender, EventArgs e)
        {
            //resets everything to the original st
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

        private void receiptLabel_Click(object sender, EventArgs e)
        {

        }

        private void crazyCookiesSuppliesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
