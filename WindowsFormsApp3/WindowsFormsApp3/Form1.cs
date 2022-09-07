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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        SqlConnection mycon;
        public Form1()
        {
            InitializeComponent();
            string s = @"Data Source = DESKTOP-E8UQAJI\SQLEXPRESS; Initial Catalog = Лаба16_Курьяков_319/4; Integrated Security = true"; ;
            mycon = new SqlConnection(s);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Лаба16_Курьяков_319_4DataSet._Лист1_". При необходимости она может быть перемещена или удалена.
            this.лист1_TableAdapter.Fill(this._Лаба16_Курьяков_319_4DataSet._Лист1_);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = "delete from dbo.Лист1$ where id = @id";
            SqlParameter p1 = new SqlParameter("@id", textBox5.Text);
            SqlCommand id = new SqlCommand(a, mycon);

            id.Parameters.Add(p1);
            id.Connection.Open();
            id.ExecuteNonQuery();
            MessageBox.Show("Удаление прошло успешно!", "Да-да");
            id.Connection.Close();
            this.лист1_TableAdapter.Fill(this._Лаба16_Курьяков_319_4DataSet._Лист1_);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string add = "insert into dbo.Лист1$ values (@id, @nazvanie, @author, @kolstr, @year)";
            SqlParameter p_1 = new SqlParameter("@id", textBox11.Text);
            SqlParameter p_2 = new SqlParameter("@nazvanie", textBox1.Text);
            SqlParameter p_3 = new SqlParameter("@author", textBox2.Text);
            SqlParameter p_4 = new SqlParameter("@kolstr", textBox3.Text);
            SqlParameter p_5 = new SqlParameter("@year", textBox4.Text);

            SqlCommand af = new SqlCommand(add, mycon);
            af.Parameters.Add(p_1);
            af.Parameters.Add(p_2);
            af.Parameters.Add(p_3);
            af.Parameters.Add(p_4);
            af.Parameters.Add(p_5);

            af.Connection.Open();
            af.ExecuteNonQuery();
            MessageBox.Show("Данные внесены!", "Да-да");
            af.Connection.Close();
            this.лист1_TableAdapter.Fill(this._Лаба16_Курьяков_319_4DataSet._Лист1_);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string update = "update Лист1$ set Название = @nazvanie, Автор = @author, [количество страниц] = @kolstr, год = @year where id = @id";
            SqlParameter pp1 = new SqlParameter("@id", textBox6.Text);
            SqlParameter pp2 = new SqlParameter("@nazvanie", textBox7.Text);
            SqlParameter pp3 = new SqlParameter("@author", textBox8.Text);
            SqlParameter pp4 = new SqlParameter("@kolstr", textBox9.Text);
            SqlParameter pp5 = new SqlParameter("@year", textBox10.Text);

            SqlCommand up = new SqlCommand(update, mycon);
            up.Parameters.Add(pp1);
            up.Parameters.Add(pp2);
            up.Parameters.Add(pp3);
            up.Parameters.Add(pp4);
            up.Parameters.Add(pp5);

            up.Connection.Open();
            up.ExecuteNonQuery();
            MessageBox.Show("Данные изменены!", "Да-да");
            up.Connection.Close();
            this.лист1_TableAdapter.Fill(this._Лаба16_Курьяков_319_4DataSet._Лист1_);
        }
    }
}
