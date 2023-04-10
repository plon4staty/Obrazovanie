using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obrazovanie
{
    public partial class autor : Form
    {
        DataBase db = new DataBase();
        public autor()
        {
            InitializeComponent();
        }

        private void autor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Login = textBox1.Text;
            var Password = textBox2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select IDUsersRoles, LoginUsers, PassUsers from Users where  LoginUsers = '{Login}' and  PassUsers = '{Password}'";
            SqlCommand command = new SqlCommand (querystring, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count == 1)
            {
                var user = new CheckUsers(table.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(table.Rows[0].ItemArray[2]));

                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Osnova osn = new Osnova(user);
                this.Hide();
                osn.ShowDialog();
                this.Show();

            }
            else
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);





        }
    }
}
