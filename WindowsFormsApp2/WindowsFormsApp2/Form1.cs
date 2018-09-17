using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Purchaser_Click(object sender, EventArgs e)
        {
            var Purchaser = new List<String> { };
            Purchaser_Read(Purchaser);
            
             try {
            File.AppendAllText(@"D:\Purchaser.csv",
                   $"{string.Join(",", Purchaser)}\r\n",
                   Encoding.UTF8
                   );
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
           }
            Purchaser_Empty();
        }
        private void Purchaser_Read(List<String> Purchaser)
        {
            Purchaser.Add(Purchaser_Name.Text);
            Purchaser.Add(Puchaser_Phone.Text);
            Purchaser.Add(Purchaser_Address.Text);
            Purchaser.Add(Receiver_Name.Text);
            Purchaser.Add(Receiver_Phone.Text);
            Purchaser.Add(Receiver_Address.Text);
        }
        private void Purchaser_Empty()
        {
            Purchaser_Name.Text =null;
            Puchaser_Phone.Text = null;
            Purchaser_Address.Text = null;
            Receiver_Name.Text = null;
            Receiver_Phone.Text = null;
            Receiver_Address.Text = null;
        }



    }

}
