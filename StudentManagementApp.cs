using System.Collections;

namespace StudentManagementApp
{
    public partial class StudentManagementApp : Form
    {
        public StudentManagementApp()
        {
            InitializeComponent();
        }
        // 리스트에서 학생 클릭하지 않으면 add 버튼만 활성화
        // 리스트에서 학생 클릭하면 add, modify, delete 버튼 활성화

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void koreanScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            Score_KeyPress(sender, e);
        }

        private void engScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            Score_KeyPress(sender, e);
        }

        private void mathScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            Score_KeyPress(sender, e);
        }

        private void socialScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            Score_KeyPress(sender, e);
        }

        private void scienceScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            Score_KeyPress(sender, e);
        }

        private void examYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber_KeyPress(sender, e);
        }

        private void examSemester_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber_KeyPress(sender, e);
        }

        private void studentGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber_KeyPress(sender, e);
        }

        private void studentNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber_KeyPress(sender, e);
        }

        private void OnlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Score_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is not TextBox textBox)
                return;

            OnlyNumber_KeyPress(sender, e);

            // 입력된 키가 숫자인 경우
            if (char.IsDigit(e.KeyChar))
            {
                // 현재 텍스트와 새로 입력된 키를 합쳐서 전체 값을 만듦
                string newText = textBox.Text.Insert(textBox.SelectionStart, e.KeyChar.ToString());

                // 전체 값을 정수로 변환하여 0에서 100 사이인지 확인
                if (int.TryParse(newText, out int scoreValue))
                {
                    if (scoreValue < 0 || scoreValue > 100)
                    {
                        e.Handled = true; // 범위를 벗어나면 입력 무시
                    }
                }
                else
                {
                    e.Handled = true; // 정수로 변환할 수 없으면 입력 무시
                }
            }
        }

    }


    public class StudentScore
    {
        
        //Enum StudentScoreInfo = {
        //    Student,
        //    Score
        //};

        //ArrayList studentScoreList<StudentScoreInfo> = new ArrayList();
        //public void addStudentScore(StudentScoreInfo newStudentScore)
        //{
        //    // studentScoreList에서 score 를 찾아서 있으면 추가하지 않음

        //}
        //public void modifyStudentScore(StudentScoreInfo oldStudentScore, StudentScoreInfo newStudentScore)
        //{
        //    // studentScoreList에서 score 를 찾아서 있으면 추가하지 않음
        //}
        //public void deleteStudentScore()
        //{
        //}
    }

    public class Student
    {
        //name, grade, class, no getter setter 정의
        public string Name { get; set; }
        public int Grade { get; set; }
        public int Class { get; set; }
        public int No { get; set; }
        public Student()
        {
        }
    }

    public class Score
    {
        //year, semester, examType, kor, eng, math, social, science getter setter 정의
        public int Year { get; set; }
        public int Semester { get; set; }
        public string ExamType { get; set; }
        public int Kor { get; set; }
        public int Eng { get; set; }
        public int Math { get; set; }
        public int Social { get; set; }
        public int Science { get; set; }
        public Score()
        {
        }
    }
}
