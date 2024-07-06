using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Buffes_Sales_Application2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tilltutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int popcorn, ticket, water, tea, total, til;
            popcorn = Convert.ToInt16(txtpopcorn.Text);
            ticket = Convert.ToInt16(TxtTicket.Text);
            water= Convert.ToInt16(TxtWater.Text);
            tea = Convert.ToInt16(TxtTea.Text);

            total = popcorn * 2 + tea * 1 + water * 1 + ticket * 3;
            LblTotal.Text = total.ToString() + " $";
            tilltutar = tilltutar + total;
            LblBill.Text = tilltutar.ToString() + " $";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtTicket.Text = "";
            TxtTea.Text = "";
            TxtWater.Text = "";
            txtpopcorn.Text = "";
            LblTotal.Text = "00$";
            LblBill.Text = "00$";
            txtpopcorn.Focus();
        }
    }
}
