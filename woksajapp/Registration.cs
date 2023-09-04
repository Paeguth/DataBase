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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void BTNregistration_Click(object sender, EventArgs e)
        {
            char[] notAllowedSymbols = { '!', '@', '#', '$', '%', '^', '&' };
            foreach (char a in notAllowedSymbols)
            {
                if (TXTpassword1.Text.Contains(a))
                {
                    MessageBox.Show("В пароле присутствуют недопустимые символы");
                    return;
                }
            }

            if (String.IsNullOrEmpty(TXTusername.Text) || String.IsNullOrEmpty(TXTpassword1.Text) || String.IsNullOrEmpty(TXTpassword2.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return;
            }

            if (TXTpassword1.Text != TXTpassword2.Text)
            {
                MessageBox.Show("Пароли не совпадают, введите пароль ещё раз");
                return;
            }

            if (isUserExist())
                return;


            DBConnection db = new DBConnection();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("INSERT INTO `wok`.`user` (`name`, `password`) VALUES (@regname, @regpass);", db.getConnection());

            command.Parameters.Add("@regname", MySqlDbType.VarChar).Value = TXTusername.Text;
            command.Parameters.Add("@regpass", MySqlDbType.VarChar).Value = TXTpassword2.Text;
 
            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт зарегистрирован");
            else
                MessageBox.Show("Аккаунт не зарегистрирован");

            db.closeConnection();

            
        }
        public Boolean isUserExist()
        {
            DBConnection db = new DBConnection();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM wok.user WHERE `name` = @name;", db.getConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = TXTusername.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким именем уже существует. Измените имя пользователя");
                return true;
            }
            else
                return false;
        }

        Point lastPoint;
        private void Registration_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void Registration_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void BTNback_Click(object sender, EventArgs e)
        {
            var form = new Authorization();
            form.Show();
            this.Close();
            return;
        }
    }
}
