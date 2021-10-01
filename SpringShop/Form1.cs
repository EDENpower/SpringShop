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


namespace SpringShop
{
    public partial class SpringShop : Form
    {
        Double cakePrice = 5.55;
        Double numOfCake = 0;

        Double flowerPrice = 3.55;
        Double NumOfFlower = 0;

        Double wandPrice = 10.55;
        Double NumOfWand = 0;

        double totalCake = 0;
        double totalFlower = 0;
        double totalWand = 0;

        double subtotal;
        double total;
        double taxAmount;
        double tendered;
        double change;
        double taxrate;



        public SpringShop()
        {
            InitializeComponent();

            //Button disable
            changeButton.Enabled = false;
            printButton.Enabled = false;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        // Setting prices
        {


            try
            {
                numOfCake = Convert.ToInt32(cakeBox.Text);
                NumOfFlower = Convert.ToInt32(flowerBox.Text);
                NumOfWand = Convert.ToInt32(wandBox.Text);

                //Calcuation
                totalCake = cakePrice * numOfCake;
                totalWand = wandPrice * NumOfWand;
                totalFlower = flowerPrice * NumOfFlower;
                 taxrate = 0.13;

                 subtotal = totalCake + totalFlower + totalWand;
                 total = subtotal * (1 + taxrate);
                 taxAmount = total - subtotal;

                //Display
                subTotalLabel.Text = $"Sub Total:{subtotal.ToString("0.00")}";
                totalLabel.Text = $"Total : {total.ToString("0.00")}";
                taxLabel.Text = $"Tax : {taxAmount.ToString("0.00")}";

                //Dialog 
                BlobbyWelcome.Text = $"Yes yes *blorp* fine choices human :)";
                calculateButton.Enabled = false;
                changeButton.Enabled = true;
            }
            catch
            {
                BlobbyWelcome.Text = $"Sorry Blobby does not understand.";
                calculateButton.Enabled = true;
                changeButton.Enabled = false;







            }
        }
    

        private void changeButton_Click(object sender, EventArgs e)
        {

           
            subtotal = totalCake + totalFlower + totalWand;
            total = subtotal * (1 + taxrate);
            taxAmount = total - subtotal;
            tendered = Convert.ToDouble(snackAmount.Text);
            change = tendered - total;



            //Display Change

            changeOwed.Text = $"Blobby gives you: {change.ToString("0.00")}";
                
           //Diagloge 
            BlobbyWelcome.Text = $"*BLURP!!* yummy yummy snack blobby loves snack thank you human <3!!";
            printButton.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //receiptinput.Scale(170, 0);
            // receipt 
            receiptinput.Text = $"Blobs Magical Shop";
            //receiptinput.Scale(170, 62);
            Refresh();
            Thread.Sleep(50);
            receiptinput.Text += $"\n\n\nOrder Number:26\n--------------------------❤";
           
            //receiptinput.Scale(170, 124);
            Refresh();
            Thread.Sleep(50);
            receiptinput.Text += $"\n\n\nSubTotal:{subtotal.ToString("0.00")}";
            Refresh();
            Thread.Sleep(50);
            receiptinput.Text += $"\n\n\nTotal : {total.ToString("0.00")}";
            Refresh();
            Thread.Sleep(50);
            receiptinput.Text += $"\n\n\nTax : {taxAmount.ToString("0.00")}";
            Refresh();
            Thread.Sleep(50);
            receiptinput.Text += $"\n\n\nTender : {tendered.ToString("0.00")}";
            Refresh();
            Thread.Sleep(50);
            receiptinput.Text += $"\n\n\nChange {tendered - total}";
            Refresh();
            Thread.Sleep(50);
            receiptinput.Text += $"\n\n\nThank you kind human \n have a nice day❤";


            //Text display
            BlobbyWelcome.Text = $"This makes Blobby very pleased!";
            
           


            
        }

        private void cakeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
