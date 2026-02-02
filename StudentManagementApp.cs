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

            btnAddImage.Parent = studentPictureBox;
            btnAddImage.Dock = DockStyle.Fill;
            btnAddImage.BringToFront();

            UpdateButtonState();
            UpdateImageButtonVisibility();
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
                .FirstOrDefault();

            if (studentScore == null)
            {
                MessageBox.Show("선택된 성적 정보를 찾을 수 없습니다.");
                return;
            }

            fillStudentScoreInfo(studentScore);

            UpdateButtonState();
            UpdateImageButtonVisibility();
        }

        private void fillStudentScoreInfo(StudentScore studentScore) // 학생 성적 정보를 UI에 입력하기 
        {
            // 학생 정보
            studentStatus.SelectedItem = studentScore.Student.Status;
            studentName.Text = studentScore.Student.Name;
            studentSchool.Text = studentScore.Student.Key.School.ToString();
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

            if (!string.IsNullOrEmpty(studentScore.Student.ImagePath) && File.Exists(studentScore.Student.ImagePath))
            {
                studentPictureBox.Image = Image.FromFile(studentScore.Student.ImagePath);
            }
        }

        private void clearStudentScoreInfo() // 학생 정보 입력 UI비우기
        {
            // 학생 정보
            studentStatus.SelectedIndex = -1; // 기본값 선택
            studentSchool.Text = "";
            studentName.Text = "";
            studentGrade.Text = "";
            studentClass.Text = "";
            studentNo.Text = "";
            studentPictureBox.Image = null;
            studentPictureBox.Tag = null;
            btnAddImage.Visible = true;

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
            if (studentStatus.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(studentSchool.Text) ||
                string.IsNullOrWhiteSpace(studentName.Text) ||
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
                studentSchool.Text.Trim(),
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

            string? imagePath = studentPictureBox.Tag as string;

            Exam exam = new Exam(
                int.Parse(examYear.Text),
                int.Parse(examSemester.Text),
                examType.SelectedItem is ExamType type ? type : ExamType.Midterm
            );

            StudentScore studentScore = new StudentScore(
                 new Student(
                     studentKey,
                     studentName.Text,
                     studentStatus.SelectedItem is StudentStatus stype ? stype : StudentStatus.Studying,
                     imagePath
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
            try
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

                RefreshStudentScoreList(exam: exam);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
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
                    RefreshStudentScoreList(exam: newStudentScore.Score.Exam);
                }
                else
                {
                    MessageBox.Show("학생 성적 정보 수정에 실패하였습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                RefreshStudentScoreList(exam: key.Exam);
                clearStudentScoreInfo();
            }
            else
            {
                MessageBox.Show("학생 성적 정보 삭제에 실패하였습니다.");
            }

        }

        // 리스트 갱신
        private void RefreshStudentScoreList(
            Exam? exam = null,
            bool useSearch = false
        )
        {
            studentScoreList.Items.Clear();

            // 시험 정보 존재시 해당하는 석차만 재계산 / 없으면 전체 재계산
            StudentScoreManager.CalculateRank(exam);

            List<StudentScore> list;
            if (useSearch)
            {
                StudentStatus? status = null;

                if (Enum.TryParse(searchStatusBox.Text, out StudentStatus parsedStatus))
                {
                    status = parsedStatus;
                }

                list = StudentScoreManager.SearchStudentScores(
                    status: status,
                    searchSchool: searchSchoolBox.Text,
                    searchName: searchNameBox.Text,
                    searchGrade: searchGradeBox.Text,
                    searchClass: searchClassBox.Text,
                    searchNo: searchNoBox.Text
                );
            }
            else
            {
                list = StudentScoreManager.SearchStudentScores();
            }

            FillSearchBoxes(list);

            foreach (var ss in list)
            {
                var item = new ListViewItem(ss.Student.Key.School.ToString()); // 학교
                item.SubItems.Add(ss.Student.Key.Grade.ToString()); // 학년
                item.SubItems.Add(ss.Student.Key.Class.ToString()); // 반
                item.SubItems.Add(ss.Student.Key.No.ToString()); // 번호
                item.SubItems.Add(ss.Student.Name); // 이름

                item.SubItems.Add(ss.Student.Status.ToString()); // 학생 상태

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
            }

            UpdateButtonState();
            UpdateImageButtonVisibility();
        }

        private void ClearSearchBox()
        {
            searchSchoolBox.SelectedIndex = -1;
            searchStatusBox.SelectedIndex = -1;
            searchNameBox.SelectedIndex = -1;
            searchGradeBox.SelectedIndex = -1;
            searchClassBox.SelectedIndex = -1;
            searchNoBox.SelectedIndex = -1;

            searchSchoolBox.Text = "";
            searchStatusBox.Text = "";
            searchNameBox.Text = "";
            searchGradeBox.Text = "";
            searchClassBox.Text = "";
            searchNoBox.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshStudentScoreList(useSearch: true);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ClearSearchBox();
            RefreshStudentScoreList();
        }

        private void FillSearchBoxes(IEnumerable<StudentScore> list)
        {
            searchSchoolBox.Items.Clear();
            searchStatusBox.Items.Clear();
            searchNameBox.Items.Clear();
            searchGradeBox.Items.Clear();
            searchClassBox.Items.Clear();
            searchNoBox.Items.Clear();

            searchSchoolBox.Items.AddRange(
                list.Select(s => s.Student.Key.School).Distinct().ToArray());

            searchStatusBox.Items.AddRange(
                list.Select(s => s.Student.Status.ToString()).Distinct().ToArray());

            searchNameBox.Items.AddRange(
                list.Select(s => s.Student.Name).Distinct().ToArray());

            searchGradeBox.Items.AddRange(
                list.Select(s => s.Student.Key.Grade.ToString()).Distinct().ToArray());

            searchClassBox.Items.AddRange(
                list.Select(s => s.Student.Key.Class.ToString()).Distinct().ToArray());

            searchNoBox.Items.AddRange(
                list.Select(s => s.Student.Key.No.ToString()).Distinct().ToArray());
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

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            dialog.Title = "학생 성적 파일 불러오기";

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                var result = FileManager.LoadStudentScoresFromFile(dialog.FileName);

                FileManager.LoadStudentScoresFromFile(dialog.FileName);
                RefreshStudentScoreList();
                MessageBox.Show($"파일 불러오기 완료\n\n성공: {result.SuccessCount}건\n실패: {result.FailCount}건");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"파일 로드 중 오류 발생:\n{ex.Message}");
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*",
                Title = "학생 성적 파일 저장",
                FileName = "StudentScores.csv",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                FileManager.SaveStudentScoresToFile(dialog.FileName);
                MessageBox.Show("파일이 성공적으로 저장되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"파일 저장 중 오류가 발생했습니다.\n{ex.Message}");
            }
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png|All Files (*.*)|*.*",
                Title = "학생 이미지 선택"
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            // 이미지 로드
            studentPictureBox.Image = Image.FromFile(dialog.FileName);
            studentPictureBox.Tag = dialog.FileName;

            UpdateImageButtonVisibility();
        }

        private void UpdateImageButtonVisibility()
        {
            Debug.WriteLine("TAG");
            Debug.WriteLine(studentPictureBox.Tag);
            bool hasImage = studentPictureBox.Tag is string path && File.Exists(path);

            if (!hasImage)
            {
                btnAddImage.BackColor = Color.FromArgb(100, 0, 0, 0);
                btnAddImage.Text = "Change Image";
            }
            else
            {
                // 이미지 있으면 투명
                btnAddImage.BackColor = Color.FromArgb(0, 0, 0, 0);
                btnAddImage.Text = "";
            }
        }

        private void btnAddImage_MouseHover(object sender, EventArgs e)
        {
            if (studentPictureBox.Tag is string path && File.Exists(path))
            {
                btnAddImage.Text = "Change Image";
            }
        }

        private void btnAddImage_MouseLeave(object sender, EventArgs e)
        {
            if (studentPictureBox.Tag is string path && File.Exists(path))
            {
                btnAddImage.Text = "";
            }
        }
    }
}
