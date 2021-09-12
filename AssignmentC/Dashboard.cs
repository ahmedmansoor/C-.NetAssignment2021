using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

namespace AssignmentC
{
    public partial class Dashboard : Form
    {
        //server connection
        static string myconnstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        Student Obj = new Student();

        public string  newId;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DataTable dataTable = Obj.Select();
            dataGridView1.DataSource = dataTable;
        }

        //register
        private void Btn_Register_Click_1(object sender, EventArgs e)
        {
            if (radioButton_m.Checked)
            {
                Obj.Gender = "Male";
            }
            else if (radioButton_f.Checked)
            {
                Obj.Gender = "Female";
            }
            
            Obj.FirstName = textBox_firstName.Text;
            Obj.LastName = textBox_lastName.Text;
            Obj.Age = int.Parse(textBox_age.Text);
            Obj.PhoneNumber = int.Parse(textBox_phNumber.Text);

            bool success = Obj.StudentAdd(Obj);
            if (success)
            {
                MessageBox.Show("Saved");
                DataTable dataTable = Obj.Select();
                dataGridView1.DataSource = dataTable;
            }
            else
            {
                return;
            }
        }

        //select from db
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rows = dataGridView1.Rows[e.RowIndex];
            newId = rows.Cells[0].Value.ToString();
            textBox_selectedID.Text = rows.Cells[0].Value.ToString();
            textBox_firstName.Text = rows.Cells[1].Value.ToString();
            textBox_lastName.Text = rows.Cells[2].Value.ToString();
            textBox_age.Text = rows.Cells[4].Value.ToString();
            textBox_phNumber.Text = rows.Cells[5].Value.ToString();

            String g = rows.Cells[3].Value.ToString();
            if (g == "Male")
            {
                radioButton_m.Checked = true;
            }
            else
            {
                radioButton_f.Checked = true;
            }
        }

        //update
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (radioButton_m.Checked)
            {
                Obj.Gender = "Male";
            }
            else if (radioButton_f.Checked)
            {
                Obj.Gender = "Female";
            }

            Obj.Id = int.Parse(newId);
            Obj.FirstName = textBox_firstName.Text;
            Obj.LastName = textBox_lastName.Text;
            Obj.Age = int.Parse(textBox_age.Text);
            Obj.PhoneNumber = int.Parse(textBox_phNumber.Text);

            bool success = Obj.StudentUpdate(Obj);
            if (success)
            {
                MessageBox.Show("Updated");
                DataTable dataTable = Obj.Select();
                dataGridView1.DataSource = dataTable;
            }
            else
            {
                return;
            }
        }

        //delete
        private void Btn_Delete_Click_1(object sender, EventArgs e)
        {
            Obj.Id = int.Parse(newId);

            bool success = Obj.StudentDelete(Obj);
            if (success)
            {
                MessageBox.Show("Deleted");
                DataTable dataTable = Obj.Select();
                dataGridView1.DataSource = dataTable;
            }
            else
            {
                return;
            }
        }
    }
}
