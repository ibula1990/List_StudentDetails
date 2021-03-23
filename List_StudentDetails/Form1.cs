using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_StudentDetails
{
    public partial class studentDetails : Form
    {
        List<string> details = new List <string>();
        Student s = new Student();
        public studentDetails()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            s.name = txtName.Text;
            s.age = Convert.ToInt32( txtAge.Text);
            s.place = cmboboxPlace.GetItemText(this.cmboboxPlace.SelectedItem);
            
            s.phno = txtphno.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            this.txtnameDisplay.Text  = this.txtName.Text;
            this.txtAgeDisplay.Text = Convert.ToString ( txtAge.Text);
            this.txtPlaceDisplay.Text = this.cmboboxPlace.Text;
            this.txtPhnoDisplay.Text = this.txtphno.Text;
        }
    }
}
