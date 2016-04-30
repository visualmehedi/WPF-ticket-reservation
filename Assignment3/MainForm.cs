using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    /// <summary> 
    /// Program starts here 
    /// </summary>
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            InitializeGUI();
        }

        void InitializeGUI()
        {

        }
  /// <summary>
 ///   Loading data 
  /// </summary>
        private void LoadData()
        {
            reservationListBox.Items.Clear();
            Seat[] seats = thtr.GetSeats();

            for (int i = 0; i < seats.Length; i++)
            {
                reservationListBox.Items.Add(string.Format("     {0}              {1}                      {2}                         {3}", seats[i].SeatNo, seats[i].Status, seats[i].Price, seats[i].CustomerName));
            }
        }       
      /// <summary>
      /// Checking the value of input and save value
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
  
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textName.Text == "")
            {
                MessageBox.Show("Please give a valid name!", "Please . . .");
                return;

            }

            if (textPrice.Text == "")
            {
                MessageBox.Show("Please give a price using correct decimal sign!", "Please . . .");
                return;

            }
                  
            if (Convert.ToDecimal(textPrice.Text) < 0)
            {
                MessageBox.Show("Please give a valid price!", "Please . . .");
                return;

            }

            //Previous code

            //if (textName.Text == "" || textPrice.Text == "")
            //{
            //    MessageBox.Show("Please give a name and a price using correct decimal sign!", "Please . . .");
            //    return;
            //}

            //if (textName.Text == "")
            //{
            //    MessageBox.Show("Please give a name using correct decimal sign!", "Please . . .");
            //    return;
            //}

            //if (textPrice.Text == "")
            //{
            //    MessageBox.Show("Please give price using correct decimal sign!", "Please . . .");
            //    return;
            //}

            if (reservationListBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an item from the list!", "Please . . .");
                return;
            }
         
            if (rbtnReserved.Checked)
            {
                thtr.BookReservation(textName.Text, reservationListBox.SelectedIndex + 1, Convert.ToDecimal(textPrice.Text));

                
            }

      

            if (rbtnCancelReserve.Checked)
            {
                thtr.CancelReservation(reservationListBox.SelectedIndex + 1);                
            }

            LoadData();

            textTotalSeat.Text = thtr.GetSeats().Length.ToString();
            textVacantSeat.Text = thtr.GetAvailabaleSeatCount().ToString();
            textReservedSeat.Text = thtr.GetReservedSeatCount().ToString();            
        }        
        

       
        /// <summary>
        /// initialize customer value
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        private void CustomerInfo(out string name, out double price)
        {
            name = textName.Text;
            price = 0.0;// textPrice.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        Theater thtr = new Theater();
        /// <summary>
        /// Assign Total seat and calculate remaining seat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
            textTotalSeat.Text = thtr.GetSeats().Length.ToString();
            textVacantSeat.Text = thtr.GetAvailabaleSeatCount().ToString();
            textReservedSeat.Text = thtr.GetReservedSeatCount().ToString();
        }

        private void reservationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void rbtnReserved_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
