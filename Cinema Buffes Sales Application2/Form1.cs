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
            int popcorn, ticket, water, tea, fruitjuice, total, til;

            if (string.IsNullOrEmpty(txtpopcorn.Text))
                popcorn = 0;
            else
                popcorn = Convert.ToInt16(txtpopcorn.Text);
            if (string.IsNullOrEmpty(TxtTicket.Text))
                ticket = 0;
            else
            ticket = Convert.ToInt16(TxtTicket.Text);
            if (string.IsNullOrEmpty(TxtWater.Text))
                water = 0;
            else
            water = Convert.ToInt16(TxtWater.Text);
            if (string.IsNullOrEmpty(TxtTea.Text))
                tea = 0;
            else
                tea = Convert.ToInt16(TxtTea.Text);
            if (string.IsNullOrEmpty(TxtFruitJuice.Text))
                fruitjuice = 0;
            else 
            fruitjuice = Convert.ToInt16(TxtFruitJuice.Text);

            total = popcorn * 2 + tea * 1 + water * 1 + ticket * 3 + fruitjuice * 4;
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
            TxtFruitJuice.Text = "";
            LblTotal.Text = "00$";
            LblBill.Text = "00$";
            txtpopcorn.Focus();
        }


    }
}
