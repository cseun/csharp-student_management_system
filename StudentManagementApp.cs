using System.Collections;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Numerics;
using System.Xml.Linq;

namespace StudentManagementApp
{
    public partial class StudentManagementApp : Form
    {

        public StudentManagementApp()
        {
            InitializeComponent();

            this.Load += StudentManagementApp_Load;
        }

        private void StudentManagementApp_Load(object sender, EventArgs e)
        {
            studentScoreList.View = View.Details;
            studentScoreList.Scrollable = true;
            studentScoreList.HideSelection = false;
            studentScoreList.FullRowSelect = true;
            studentScoreList.GridLines = true;
            studentScoreList.MultiSelect = false;

            UpdateButtonState();
        }

        // 리스트에서 학생을 클릭하면 입력 정보 채우기
        // 리스트에서 학생 클릭하지 않으면 add 버튼만 활성화
        // 리스트에서 학생 클릭하면 add, modify, delete 버튼 활성화
        private void studentScoreList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studentScoreList.SelectedItems.Count == 0)
            {
                clearStudentScoreInfo();
                return;
            }

            var selectedItem = studentScoreList.SelectedItems[0];
            var key = (StudentExamKey)selectedItem.Tag;

            var studentScore = StudentScoreManager
                .SearchStudentScores(key.StudentKey, key.Exam)
                .First();

            fillStudentScoreInfo(studentScore);

            UpdateButtonState();
        }

        private void fillStudentScoreInfo(StudentScore studentScore) // 학생 성적 정보를 UI에 입력하기 
        {
            // 학생 정보
            studentName.Text = studentScore.Student.Name;
            studentGrade.Text = studentScore.Student.Key.Grade.ToString();
            studentClass.Text = studentScore.Student.Key.Class.ToString();
            studentNo.Text = studentScore.Student.Key.No.ToString();

            // 시험 정보
            examYear.Text = studentScore.Score.Exam.Year.ToString();
            examSemester.Text = studentScore.Score.Exam.Semester.ToString();
            examType.SelectedItem = studentScore.Score.Exam.ExamType;

            // 점수 정보
            koreanScore.Text = studentScore.Score.Kor.ToString();
            engScore.Text = studentScore.Score.Eng.ToString();
            mathScore.Text = studentScore.Score.Math.ToString();
            socialScore.Text = studentScore.Score.Social.ToString();
            scienceScore.Text = studentScore.Score.Science.ToString();
            totalScore.Text = studentScore.Score.TotalScore.ToString();
            rank.Text = studentScore.Rank.ToString();
        }

        private void clearStudentScoreInfo() // 학생 정보 입력 UI비우기
        {
            // 학생 정보
            studentName.Text = "";
            studentGrade.Text = "";
            studentClass.Text = "";
            studentNo.Text = "";

            // 시험 정보
            examYear.Text = "";
            examSemester.Text = "";
            examType.SelectedIndex = -1; // 기본값 선택

            // 점수 정보
            koreanScore.Text = "0";
            engScore.Text = "0";
            mathScore.Text = "0";
            socialScore.Text = "0";
            scienceScore.Text = "0";

            // 포커스 초기 위치
            studentName.Focus();

        }

        private void UpdateButtonState()
        {
            bool isSelected = studentScoreList.SelectedItems.Count > 0;

            btnAdd.Enabled = true;
            btnModify.Enabled = isSelected;
            btnDelete.Enabled = isSelected;
        }

        private StudentScore getStudentScoreInfo() // UI에서 학생 성적 정보 가져오기
        {
            if (string.IsNullOrWhiteSpace(studentName.Text) ||
                string.IsNullOrWhiteSpace(studentGrade.Text) ||
                string.IsNullOrWhiteSpace(studentClass.Text) ||
                string.IsNullOrWhiteSpace(studentNo.Text) ||
                string.IsNullOrWhiteSpace(examYear.Text) ||
                string.IsNullOrWhiteSpace(examSemester.Text) ||
                examType.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(koreanScore.Text) ||
                string.IsNullOrWhiteSpace(engScore.Text) ||
                string.IsNullOrWhiteSpace(mathScore.Text) ||
                string.IsNullOrWhiteSpace(socialScore.Text) ||
                string.IsNullOrWhiteSpace(scienceScore.Text))
            {
                throw new InvalidOperationException("모든 항목을 입력해주세요.");
            }

            StudentKey studentKey = new StudentKey(
                int.Parse(studentGrade.Text),
                int.Parse(studentClass.Text),
                int.Parse(studentNo.Text)
             );

            int year = int.Parse(examYear.Text);
            int currentYear = DateTime.Now.Year;

            if (year > currentYear)
            {
                throw new InvalidOperationException(
                    $"시험년도는 {currentYear}년 이하여야 합니다."
                );
            }

            Exam exam = new Exam(
                int.Parse(examYear.Text),
                int.Parse(examSemester.Text),
                examType.SelectedItem is ExamType type ? type : ExamType.Midterm
            );

            StudentScore studentScore = new StudentScore(
                 new Student(
                     studentKey,
                     studentName.Text
                ),
                new Score(
                    exam,
                    int.Parse(koreanScore.Text),
                    int.Parse(engScore.Text),
                    int.Parse(mathScore.Text),
                    int.Parse(socialScore.Text),
                    int.Parse(scienceScore.Text)
                 ));

            return studentScore;
        }

        // 학생 성적 정보 추가하기
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // UI에서 입력된 학생성적 정보 가져오기
            StudentScore studentScoreInfo = getStudentScoreInfo();

            // 학생 성적 추가
            bool result = StudentScoreManager.AddStudentScore(studentScoreInfo);
            if (result)
            {
                MessageBox.Show("학생 성적 정보가 추가되었습니다.");
                clearStudentScoreInfo();
            }
            else
            {
                MessageBox.Show("이미 존재하는 학생 성적 정보입니다.");
            }

            // 현재 선택된 시험 기준
            Exam exam = studentScoreInfo.Score.Exam;

            RefreshStudentScoreList(exam);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //oldKey: 현재 리스트에서 선택된 학생 정보의 key값을 가져오기 (리스트에 표시될 때 key값을 Tag에 가지고 있게 하기)
            if (studentScoreList.SelectedItems.Count == 0)
            {
                MessageBox.Show("수정할 항목을 선택하세요.");
                return;
            }
            ListViewItem selectedItem = studentScoreList.SelectedItems[0];
            StudentExamKey? oldKey = selectedItem.Tag as StudentExamKey;
            if (oldKey == null)
            {
                MessageBox.Show("선택된 항목의 키 정보가 올바르지 않습니다.");
                return;
            }

            // UI에서 입력된 학생성적 정보 가져오기
            StudentScore newStudentScore = getStudentScoreInfo();
            // 학생 성적 수정
            bool result = StudentScoreManager.ModifyStudentScore(oldKey, newStudentScore);
            if (result)
            {
                MessageBox.Show("학생 성적 정보가 수정되었습니다.");
                RefreshStudentScoreList(newStudentScore.Score.Exam);
            }
            else
            {
                MessageBox.Show("학생 성적 정보 수정에 실패하였습니다.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (studentScoreList.SelectedItems.Count == 0)
            {
                MessageBox.Show("삭제할 항목을 선택하세요.");
                return;
            }
            ListViewItem selectedItem = studentScoreList.SelectedItems[0];
            StudentExamKey? key = selectedItem.Tag as StudentExamKey;
            if (key == null)
            {
                MessageBox.Show("선택된 항목의 키 정보가 올바르지 않습니다.");
                return;
            }

            // 학생 성적 삭제
            bool result = StudentScoreManager.DeleteStudentScore(key);
            if (result)
            {
                MessageBox.Show("학생 성적 정보가 삭제되었습니다.");
                RefreshStudentScoreList(key.Exam);
                clearStudentScoreInfo();
            }
            else
            {
                MessageBox.Show("학생 성적 정보 삭제에 실패하였습니다.");
            }

        }

        // 리스트 갱신
        private void RefreshStudentScoreList(Exam? exam = null)
        {
            // 검색
            var list = StudentScoreManager.SearchStudentScores();

            // 시험에 해당하는 석차만 재계산
            if (exam != null)
            {
                StudentScoreManager.CalculateRankByExam(exam);
            }

            studentScoreList.Items.Clear();

            foreach (var ss in list)
            {
                var item = new ListViewItem(ss.Student.Key.Grade.ToString()); // 학년
                item.SubItems.Add(ss.Student.Key.Class.ToString()); // 반
                item.SubItems.Add(ss.Student.Key.No.ToString()); // 번호
                item.SubItems.Add(ss.Student.Name); // 이름

                item.SubItems.Add(ss.Score.Exam.Year.ToString()); // 시험년도
                item.SubItems.Add(ss.Score.Exam.Semester.ToString()); // 학기
                item.SubItems.Add(ss.Score.Exam.ExamType.ToString()); // 시험종류

                item.SubItems.Add(ss.Score.Kor.ToString());
                item.SubItems.Add(ss.Score.Eng.ToString());
                item.SubItems.Add(ss.Score.Math.ToString());
                item.SubItems.Add(ss.Score.Social.ToString());
                item.SubItems.Add(ss.Score.Science.ToString());

                item.SubItems.Add(ss.Score.TotalScore.ToString()); // 총점
                item.SubItems.Add(ss.Rank.ToString()); // 석차

                item.Tag = ss.Key; // Key 숨김

                studentScoreList.Items.Add(item);

                UpdateButtonState();
            }
        }

        #region 입력값 숫자 필터링
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
        #endregion
    }

    #region Student, Score, Exam, StudentScore 클래스
    public enum ExamType
    {
        Midterm,
        Final,
        MidFinal
    }

    public record StudentKey(int Grade, int Class, int No);

    public class Student
    {
        public StudentKey Key { get; }
        public string Name { get; set; }
        public Student(StudentKey key, string name)
        {
            Key = key;
            Name = name;
        }

        public bool HasSameKey(Student other)
        {
            return Key.Equals(other.Key);
        }

        public override string ToString()
        {
            return $"{Key.Grade}-{Key.Class}-{Key.No} {Name}";
        }
    }

    public record Exam(int Year, int Semester, ExamType ExamType);
    public record StudentExamKey(StudentKey StudentKey, Exam Exam);
    public class Score
    {
        public Exam Exam { get; set; }
        public int Kor { get; set; }
        public int Eng { get; set; }
        public int Math { get; set; }
        public int Social { get; set; }
        public int Science { get; set; }
        public int TotalScore => Kor + Eng + Math + Social + Science;

        public Score(Exam exam, int kor, int eng, int math, int social, int science)
        {
            Exam = exam;
            Kor = kor;
            Eng = eng;
            Math = math;
            Social = social;
            Science = science;
        }

        public bool IsSameExam(Exam exam)
        {
            return Exam.Equals(exam);
        }
    }

    class StudentScore
    {
        public StudentExamKey Key { get; }
        public Student Student { get; }
        public Score Score { get; }
        public int Rank { get; set; }

        public StudentScore(Student student, Score score)
        {
            this.Student = student;
            this.Score = score;
            this.Key = new StudentExamKey(student.Key, this.Score.Exam);
        }
        public override string ToString()
        {
            Debug.WriteLine("=== StudentScoreInfo ===");
            Debug.WriteLine($"학생: {this.Student}");
            Debug.WriteLine($"학년: {this.Student.Key.Grade}");
            Debug.WriteLine($"반: {this.Student.Key.Class}");
            Debug.WriteLine($"번호: {this.Student.Key.No}");
            Debug.WriteLine($"이름: {this.Student.Name}");

            Debug.WriteLine($"시험년도: {this.Score.Exam.Year}");
            Debug.WriteLine($"학기: {this.Score.Exam.Semester}");
            Debug.WriteLine($"시험종류: {this.Score.Exam.ExamType}");

            Debug.WriteLine($"국어: {this.Score.Kor}");
            Debug.WriteLine($"영어: {this.Score.Eng}");
            Debug.WriteLine($"수학: {this.Score.Math}");
            Debug.WriteLine($"사회: {this.Score.Social}");
            Debug.WriteLine($"과학: {this.Score.Science}");

            return $"{Student} / {Score.Exam} / 총점 {Score.TotalScore} / 석차 {Rank}";
        }
    }
    #endregion

    class StudentScoreManager
    {
        // 학생 성적 목록
        private static Dictionary<StudentExamKey, StudentScore> studentScores = new Dictionary<StudentExamKey, StudentScore>();

        // 학생 성적 정보 검색
        public static List<StudentScore> SearchStudentScores(StudentKey? studentKey = null, Exam? exam = null)
        {
            return studentScores.Where(keyValue =>
               (studentKey == null || keyValue.Key.StudentKey.Equals(studentKey)) &&
               (exam == null || keyValue.Key.Exam.Equals(exam))
            )
            .Select(keyValue => keyValue.Value)
            .ToList();
        }

        // 학생 성적 정보 추가
        public static bool AddStudentScore(StudentScore studentScoreInfo)
        {
            // 이미 학생 성적이 존재하면 성적 정보를 검색.
            if (studentScores.ContainsKey(studentScoreInfo.Key))
                return false;

            studentScores.Add(studentScoreInfo.Key, studentScoreInfo);

#if DEBUG
            foreach (StudentScore s in SearchStudentScores())
            {
                s.ToString();
            }
#endif
            return true;
        }

        public static bool ModifyStudentScore(StudentExamKey oldKey, StudentScore newStudentScore)
        {
            List<StudentScore> searchedStudentScores = SearchStudentScores(oldKey.StudentKey, oldKey.Exam);

            if (!studentScores.ContainsKey(oldKey))
                return false;

            if (!oldKey.Equals(newStudentScore.Key))
            {
                studentScores.Remove(oldKey);

                if (studentScores.ContainsKey(newStudentScore.Key))
                    return false; // 새 Key 중복

                studentScores.Add(newStudentScore.Key, newStudentScore);
            }
            else
            {
                studentScores[oldKey] = newStudentScore;
            }

            return true;
        }

        public static bool DeleteStudentScore(StudentExamKey key)
        {
            return studentScores.Remove(key);
        }

        // 같은 시험 기준 석차 계산
        public static void CalculateRankByExam(Exam exam)
        {
            // 해당 시험 성적만 가져오기
            var list = studentScores
                .Where(kv => kv.Key.Exam.Equals(exam))
                .Select(kv => kv.Value)
                .OrderByDescending(s => s.Score.TotalScore)
                .ToList();

            int rank = 1;
            int prevScore = -1;
            int sameRankCount = 0;

            foreach (var score in list)
            {
                if (score.Score.TotalScore == prevScore)
                {
                    // 동점일 경우 같은 석차
                    score.Rank = rank;
                    sameRankCount++;
                }
                else
                {
                    // 점수 다르면 석차 갱신
                    rank += sameRankCount;
                    score.Rank = rank;
                    sameRankCount = 1;
                    prevScore = score.Score.TotalScore;
                }
            }
        }

    }
    
}
