using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class UserInputAnswersForm : Form
    {

        private DataTable dt;

        public UserInputAnswersForm()
        {
            InitializeComponent();
            FillTable();
        }

        private void FillTable()
        {
            dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("#");
            dt.Columns.Add("Your answer");
            dt.Columns[0].ReadOnly = true;

            for (int i = 1; i <= 57; i++)
            {
                DataRow _answerNo = dt.NewRow();
                _answerNo["#"] = i;
                dt.Rows.Add(_answerNo);
            }

            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;
        }
        
        private void UserInputAnswersForm_Load(object sender, EventArgs e)
        {

        }

        public DataTable GetDataTable()
        {
            return this.dt;
        }

    }
}
