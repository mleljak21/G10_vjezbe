using Evaluation_Manager.Models;

namespace Evaluation_Manager
{
    internal class FrmEvaluation : frmEvaluation
    {
        private Student selectedStudent;

        public FrmEvaluation(Student selectedStudent)
        {
            this.selectedStudent = selectedStudent;
        }
    }
}