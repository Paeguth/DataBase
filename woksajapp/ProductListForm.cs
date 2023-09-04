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
    public partial class ProductListForm : Form
    {
        DBConnection db = new DBConnection();
        MySqlDataAdapter adapter;
        DataSet dataSet;

        public ProductListForm()
        {
            InitializeComponent();
        }
        
        private void ProductListForm_Load(object sender, EventArgs e)
        {
            db.openConnection();

                adapter = new MySqlDataAdapter("SELECT * FROM wok.product", db.getConnection());
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                dataSet = new DataSet();
                adapter.Fill(dataSet);
                DGVProducts.DataSource = dataSet.Tables[0];

            db.closeConnection();
        }
        private void BTNSave_Click(object sender, EventArgs e)
        {
            db.openConnection();

                adapter.Update(dataSet);
                dataSet.Clear();
                adapter.Fill(dataSet);

                MySqlDataAdapter data = new MySqlDataAdapter("UPDATE `wok`.`product` SET `total_price`= `price` * `quantity`;", db.getConnection());
                DataTable table = new DataTable();
                data.Fill(table);
                DGVProducts.DataSource = table;

                adapter = new MySqlDataAdapter("SELECT * FROM wok.product", db.getConnection());
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                dataSet = new DataSet();
                adapter.Fill(dataSet);
                DGVProducts.DataSource = dataSet.Tables[0];

            db.closeConnection();
        }

        private void BTNDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGVProducts.SelectedRows)
            {
                DGVProducts.Rows.Remove(row);
            }
        }

        private void BTNback_Click(object sender, EventArgs e)
        {
            var form = new Authorization();
            form.Show();
            this.Close();
            return;
        }

        Point lastPoint;

        private void ProductListForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void ProductListForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
