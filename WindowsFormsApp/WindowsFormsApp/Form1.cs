using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void titleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.titleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.positions' table. You can move, or remove it, as needed.
            this.positionsTableAdapter.Fill(this.databaseDataSet.positions);
            // TODO: This line of code loads data into the 'databaseDataSet.title' table. You can move, or remove it, as needed.
            this.titleTableAdapter.Fill(this.databaseDataSet.title);

        }
    }
}
