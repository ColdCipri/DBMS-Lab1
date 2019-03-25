using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBMS_Lab1
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlDataAdapter daMech, daServ;
        DataSet dataset;
        SqlCommandBuilder cb;
        BindingSource bsMech, bsServ;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            daMech.Update(dataset, "Mechanic");
        }

        private void GridMechanic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source = CIPRI-ASUS\SQLEXPRESS; Initial Catalog=Car_Shop; Integrated Security = True");
            dataset = new DataSet();
            daMech = new SqlDataAdapter("select * from Mechanic", connection);
            daServ = new SqlDataAdapter("select * from Service", connection);
            cb = new SqlCommandBuilder(daMech);

            daMech.Fill(dataset, "Mechanic");
            daServ.Fill(dataset, "Service");

            DataRelation dr = new DataRelation("FK_Service_Mechanic", dataset.Tables["Service"].Columns["ServiceID"], dataset.Tables["Mechanic"].Columns["ServiceID"]);
            dataset.Relations.Add(dr);

            bsServ = new BindingSource
            {
                DataSource = dataset,
                DataMember = "Service"
            };

            bsMech = new BindingSource();
            bsMech.DataSource = bsServ;
            bsMech.DataMember = "FK_Service_Mechanic";

            GridMechanic.DataSource = bsMech;
            GridService.DataSource = bsServ;
        }
        private void GridService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
