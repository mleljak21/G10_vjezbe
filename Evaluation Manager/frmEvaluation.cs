using Evaluation_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager
{
    public partial class frmEvaluation : Form
    {
        private Student student;
        public FrmEvaluation(Student selectedStudent)
        {
            InitializeComponent();
            student = selectedStudent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public frmEvaluation_Load(Student selectedStudent)
        {
            InitializeComponent(); 
            Student=selectedStudent;
        }

    }
}
