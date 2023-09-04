using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace woksajapp
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void BTNentry_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM wok.user WHERE `name` = @name and `password` = @pass;", db.getConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = TXTusername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = TXTpassword.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Вы авторизованы");
                var form = new ProductListForm();
                form.Show();
                Hide();
            }
            else
                MessageBox.Show("Некорректное имя пользователя или пароль");
        }

        private void BTNregistration_Click(object sender, EventArgs e)
        {
            var form = new Registration();
            form.Show();
            Hide();
        }

        Point lastPoint;

        private void Authorization_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void Authorization_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void BTNexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
