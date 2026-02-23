namespace StudentManagementApp
{
    partial class StudentManagementApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnSearchStudentAll = new Button();
            searchStatusBox = new ComboBox();
            label21 = new Label();
            searchSchoolBox = new ComboBox();
            label20 = new Label();
            studentScoreList = new ListView();
            list_school = new ColumnHeader();
            list_grade = new ColumnHeader();
            list_class = new ColumnHeader();
            list_student_no = new ColumnHeader();
            list_name = new ColumnHeader();
            list_status = new ColumnHeader();
            list_year = new ColumnHeader();
            list_semester = new ColumnHeader();
            list_exam_type = new ColumnHeader();
            list_kor_score = new ColumnHeader();
            list_eng_score = new ColumnHeader();
            list_math_score = new ColumnHeader();
            list_social_score = new ColumnHeader();
            list_science_score = new ColumnHeader();
            list_total_score = new ColumnHeader();
            list_rank = new ColumnHeader();
            searchNoBox = new ComboBox();
            searchGradeBox = new ComboBox();
            searchClassBox = new ComboBox();
            searchNameBox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSaveFile = new Button();
            btnLoadFile = new Button();
            btnShowAll = new Button();
            btnSearch = new Button();
            groupBox2 = new GroupBox();
            btnDelete = new Button();
            btnModify = new Button();
            groupBox6 = new GroupBox();
            label16 = new Label();
            rank = new TextBox();
            label17 = new Label();
            totalScore = new TextBox();
            label15 = new Label();
            scienceScore = new TextBox();
            label14 = new Label();
            socialScore = new TextBox();
            label13 = new Label();
            mathScore = new TextBox();
            label12 = new Label();
            engScore = new TextBox();
            label11 = new Label();
            koreanScore = new TextBox();
            groupBox5 = new GroupBox();
            examType = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            examSemester = new TextBox();
            label8 = new Label();
            examYear = new TextBox();
            btnAdd = new Button();
            groupBox4 = new GroupBox();
            btnAddImage = new Button();
            studentStatus = new ComboBox();
            label19 = new Label();
            label18 = new Label();
            studentSchool = new TextBox();
            studentPictureBox = new PictureBox();
            label7 = new Label();
            studentNo = new TextBox();
            label6 = new Label();
            studentClass = new TextBox();
            label5 = new Label();
            studentGrade = new TextBox();
            label4 = new Label();
            studentName = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentPictureBox).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearchStudentAll);
            groupBox1.Controls.Add(searchStatusBox);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(searchSchoolBox);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(studentScoreList);
            groupBox1.Controls.Add(searchNoBox);
            groupBox1.Controls.Add(searchGradeBox);
            groupBox1.Controls.Add(searchClassBox);
            groupBox1.Controls.Add(searchNameBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnSaveFile);
            groupBox1.Controls.Add(btnLoadFile);
            groupBox1.Controls.Add(btnShowAll);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Location = new Point(12, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1576, 386);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student List";
            // 
            // btnSearchStudentAll
            // 
            btnSearchStudentAll.BackColor = SystemColors.ActiveCaption;
            btnSearchStudentAll.Location = new Point(1130, 49);
            btnSearchStudentAll.Name = "btnSearchStudentAll";
            btnSearchStudentAll.Size = new Size(178, 29);
            btnSearchStudentAll.TabIndex = 9;
            btnSearchStudentAll.Text = "Search Student Scores";
            btnSearchStudentAll.UseVisualStyleBackColor = false;
            btnSearchStudentAll.Click += btnSearchStudentAll_Click;
            // 
            // searchStatusBox
            // 
            searchStatusBox.FormattingEnabled = true;
            searchStatusBox.Location = new Point(240, 51);
            searchStatusBox.Name = "searchStatusBox";
            searchStatusBox.Size = new Size(92, 28);
            searchStatusBox.TabIndex = 2;
            searchStatusBox.TextUpdate += searchStatusBox_TextUpdate;
            searchStatusBox.Enter += searchStatusBox_Enter;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(185, 55);
            label21.Name = "label21";
            label21.Size = new Size(50, 20);
            label21.TabIndex = 19;
            label21.Text = "Status";
            // 
            // searchSchoolBox
            // 
            searchSchoolBox.FormattingEnabled = true;
            searchSchoolBox.Location = new Point(82, 53);
            searchSchoolBox.Name = "searchSchoolBox";
            searchSchoolBox.Size = new Size(92, 28);
            searchSchoolBox.TabIndex = 1;
            searchSchoolBox.TextUpdate += searchSchoolBox_TextUpdate;
            searchSchoolBox.Enter += searchSchoolBox_Enter;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(27, 57);
            label20.Name = "label20";
            label20.Size = new Size(55, 20);
            label20.TabIndex = 17;
            label20.Text = "School";
            // 
            // studentScoreList
            // 
            studentScoreList.Columns.AddRange(new ColumnHeader[] { list_school, list_grade, list_class, list_student_no, list_name, list_status, list_year, list_semester, list_exam_type, list_kor_score, list_eng_score, list_math_score, list_social_score, list_science_score, list_total_score, list_rank });
            studentScoreList.Location = new Point(26, 94);
            studentScoreList.Name = "studentScoreList";
            studentScoreList.Size = new Size(1531, 271);
            studentScoreList.TabIndex = 11;
            studentScoreList.UseCompatibleStateImageBehavior = false;
            studentScoreList.View = View.Details;
            studentScoreList.SelectedIndexChanged += studentScoreList_SelectedIndexChanged;
            // 
            // list_school
            // 
            list_school.Text = "School";
            list_school.Width = 90;
            // 
            // list_grade
            // 
            list_grade.Text = "Grade";
            list_grade.Width = 90;
            // 
            // list_class
            // 
            list_class.Text = "Class";
            list_class.Width = 90;
            // 
            // list_student_no
            // 
            list_student_no.Text = "No.";
            list_student_no.Width = 90;
            // 
            // list_name
            // 
            list_name.Text = "Name";
            list_name.Width = 90;
            // 
            // list_status
            // 
            list_status.Text = "Status";
            list_status.Width = 90;
            // 
            // list_year
            // 
            list_year.Text = "Year";
            list_year.Width = 90;
            // 
            // list_semester
            // 
            list_semester.Text = "Semester";
            list_semester.Width = 90;
            // 
            // list_exam_type
            // 
            list_exam_type.Text = "Exam Type";
            list_exam_type.Width = 100;
            // 
            // list_kor_score
            // 
            list_kor_score.Text = "Korean";
            list_kor_score.Width = 90;
            // 
            // list_eng_score
            // 
            list_eng_score.Text = "English";
            list_eng_score.Width = 90;
            // 
            // list_math_score
            // 
            list_math_score.Text = "Math";
            list_math_score.Width = 90;
            // 
            // list_social_score
            // 
            list_social_score.Text = "Social";
            list_social_score.Width = 90;
            // 
            // list_science_score
            // 
            list_science_score.Text = "Science";
            list_science_score.Width = 90;
            // 
            // list_total_score
            // 
            list_total_score.Text = "Total Score";
            list_total_score.Width = 100;
            // 
            // list_rank
            // 
            list_rank.Text = "Rank";
            list_rank.Width = 90;
            // 
            // searchNoBox
            // 
            searchNoBox.FormattingEnabled = true;
            searchNoBox.Location = new Point(830, 49);
            searchNoBox.Name = "searchNoBox";
            searchNoBox.Size = new Size(57, 28);
            searchNoBox.TabIndex = 6;
            searchNoBox.TextUpdate += searchNoBox_TextUpdate;
            searchNoBox.Enter += searchNoBox_Enter;
            // 
            // searchGradeBox
            // 
            searchGradeBox.FormattingEnabled = true;
            searchGradeBox.Location = new Point(608, 51);
            searchGradeBox.Name = "searchGradeBox";
            searchGradeBox.Size = new Size(83, 28);
            searchGradeBox.TabIndex = 4;
            searchGradeBox.TextUpdate += searchGradeBox_TextUpdate;
            searchGradeBox.Enter += searchGradeBox_Enter;
            // 
            // searchClassBox
            // 
            searchClassBox.FormattingEnabled = true;
            searchClassBox.Location = new Point(697, 51);
            searchClassBox.Name = "searchClassBox";
            searchClassBox.Size = new Size(78, 28);
            searchClassBox.TabIndex = 5;
            searchClassBox.TextUpdate += searchClassBox_TextUpdate;
            searchClassBox.Enter += searchClassBox_Enter;
            // 
            // searchNameBox
            // 
            searchNameBox.FormattingEnabled = true;
            searchNameBox.Location = new Point(399, 50);
            searchNameBox.Name = "searchNameBox";
            searchNameBox.Size = new Size(92, 28);
            searchNameBox.TabIndex = 3;
            searchNameBox.TextUpdate += searchNameBox_TextUpdate;
            searchNameBox.Enter += searchNameBox_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(788, 53);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 12;
            label3.Text = "No.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(506, 55);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 11;
            label2.Text = "Grade/Class";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(344, 54);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 10;
            label1.Text = "Name";
            // 
            // btnSaveFile
            // 
            btnSaveFile.BackColor = Color.DarkSeaGreen;
            btnSaveFile.Location = new Point(1442, 48);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(112, 29);
            btnSaveFile.TabIndex = 10;
            btnSaveFile.Text = "Save File(.csv)";
            btnSaveFile.UseVisualStyleBackColor = false;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // btnLoadFile
            // 
            btnLoadFile.BackColor = SystemColors.Info;
            btnLoadFile.Location = new Point(1317, 48);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(116, 29);
            btnLoadFile.TabIndex = 9;
            btnLoadFile.Text = "Load File(.csv)";
            btnLoadFile.UseVisualStyleBackColor = false;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(996, 47);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(80, 30);
            btnShowAll.TabIndex = 8;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ActiveCaption;
            btnSearch.Location = new Point(913, 48);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 30);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnModify);
            groupBox2.Controls.Add(groupBox6);
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Location = new Point(12, 402);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1576, 555);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Properties";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.RosyBrown;
            btnDelete.Location = new Point(871, 490);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnModify
            // 
            btnModify.BackColor = SystemColors.Info;
            btnModify.Location = new Point(761, 490);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(94, 29);
            btnModify.TabIndex = 28;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label16);
            groupBox6.Controls.Add(rank);
            groupBox6.Controls.Add(label17);
            groupBox6.Controls.Add(totalScore);
            groupBox6.Controls.Add(label15);
            groupBox6.Controls.Add(scienceScore);
            groupBox6.Controls.Add(label14);
            groupBox6.Controls.Add(socialScore);
            groupBox6.Controls.Add(label13);
            groupBox6.Controls.Add(mathScore);
            groupBox6.Controls.Add(label12);
            groupBox6.Controls.Add(engScore);
            groupBox6.Controls.Add(label11);
            groupBox6.Controls.Add(koreanScore);
            groupBox6.Location = new Point(817, 157);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(740, 300);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Score Info";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(509, 248);
            label16.Name = "label16";
            label16.Size = new Size(43, 20);
            label16.TabIndex = 41;
            label16.Text = "Rank";
            // 
            // rank
            // 
            rank.Location = new Point(610, 245);
            rank.Name = "rank";
            rank.ReadOnly = true;
            rank.Size = new Size(100, 27);
            rank.TabIndex = 31;
            rank.Text = "-";
            rank.TextAlign = HorizontalAlignment.Right;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(509, 184);
            label17.Name = "label17";
            label17.Size = new Size(85, 20);
            label17.TabIndex = 39;
            label17.Text = "Total Score";
            // 
            // totalScore
            // 
            totalScore.Location = new Point(610, 181);
            totalScore.Name = "totalScore";
            totalScore.ReadOnly = true;
            totalScore.Size = new Size(100, 27);
            totalScore.TabIndex = 30;
            totalScore.Text = "0";
            totalScore.TextAlign = HorizontalAlignment.Right;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(243, 103);
            label15.Name = "label15";
            label15.Size = new Size(60, 20);
            label15.TabIndex = 37;
            label15.Text = "Science";
            // 
            // scienceScore
            // 
            scienceScore.Location = new Point(316, 100);
            scienceScore.Name = "scienceScore";
            scienceScore.Size = new Size(100, 27);
            scienceScore.TabIndex = 26;
            scienceScore.Text = "0";
            scienceScore.TextAlign = HorizontalAlignment.Right;
            scienceScore.KeyPress += scienceScore_KeyPress;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(44, 103);
            label14.Name = "label14";
            label14.Size = new Size(49, 20);
            label14.TabIndex = 35;
            label14.Text = "Social";
            // 
            // socialScore
            // 
            socialScore.Location = new Point(117, 100);
            socialScore.Name = "socialScore";
            socialScore.Size = new Size(100, 27);
            socialScore.TabIndex = 25;
            socialScore.Text = "0";
            socialScore.TextAlign = HorizontalAlignment.Right;
            socialScore.KeyPress += socialScore_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(443, 48);
            label13.Name = "label13";
            label13.Size = new Size(45, 20);
            label13.TabIndex = 33;
            label13.Text = "Math";
            // 
            // mathScore
            // 
            mathScore.Location = new Point(516, 45);
            mathScore.Name = "mathScore";
            mathScore.Size = new Size(100, 27);
            mathScore.TabIndex = 24;
            mathScore.Text = "0";
            mathScore.TextAlign = HorizontalAlignment.Right;
            mathScore.KeyPress += mathScore_KeyPress;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(243, 48);
            label12.Name = "label12";
            label12.Size = new Size(58, 20);
            label12.TabIndex = 31;
            label12.Text = "English";
            // 
            // engScore
            // 
            engScore.Location = new Point(316, 45);
            engScore.Name = "engScore";
            engScore.Size = new Size(100, 27);
            engScore.TabIndex = 23;
            engScore.Text = "0";
            engScore.TextAlign = HorizontalAlignment.Right;
            engScore.KeyPress += engScore_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(44, 48);
            label11.Name = "label11";
            label11.Size = new Size(57, 20);
            label11.TabIndex = 29;
            label11.Text = "Korean";
            // 
            // koreanScore
            // 
            koreanScore.Location = new Point(117, 45);
            koreanScore.Name = "koreanScore";
            koreanScore.Size = new Size(100, 27);
            koreanScore.TabIndex = 22;
            koreanScore.Text = "0";
            koreanScore.TextAlign = HorizontalAlignment.Right;
            koreanScore.KeyPress += koreanScore_KeyPress;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(examType);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(examSemester);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(examYear);
            groupBox5.Location = new Point(817, 43);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(740, 100);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Exam Info";
            // 
            // examType
            // 
            examType.DropDownStyle = ComboBoxStyle.DropDownList;
            examType.FormattingEnabled = true;
            examType.Items.AddRange(new object[] { ExamType.Midterm, ExamType.Final, ExamType.MidFinal });
            examType.Location = new Point(556, 43);
            examType.Name = "examType";
            examType.Size = new Size(100, 28);
            examType.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(466, 47);
            label10.Name = "label10";
            label10.Size = new Size(82, 20);
            label10.TabIndex = 28;
            label10.Text = "Exam Type";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(246, 48);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 26;
            label9.Text = "Semester";
            // 
            // examSemester
            // 
            examSemester.Location = new Point(324, 45);
            examSemester.Name = "examSemester";
            examSemester.Size = new Size(100, 27);
            examSemester.TabIndex = 20;
            examSemester.KeyPress += examSemester_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 48);
            label8.Name = "label8";
            label8.Size = new Size(38, 20);
            label8.TabIndex = 24;
            label8.Text = "Year";
            // 
            // examYear
            // 
            examYear.Location = new Point(99, 45);
            examYear.Name = "examYear";
            examYear.Size = new Size(100, 27);
            examYear.TabIndex = 19;
            examYear.KeyPress += examYear_KeyPress;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkSeaGreen;
            btnAdd.Location = new Point(646, 490);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnAddImage);
            groupBox4.Controls.Add(studentStatus);
            groupBox4.Controls.Add(label19);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(studentSchool);
            groupBox4.Controls.Add(studentPictureBox);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(studentNo);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(studentClass);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(studentGrade);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(studentName);
            groupBox4.Location = new Point(18, 44);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(778, 413);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Student Info";
            // 
            // btnAddImage
            // 
            btnAddImage.BackColor = Color.FromArgb(160, 0, 0, 0);
            btnAddImage.FlatAppearance.BorderSize = 0;
            btnAddImage.FlatStyle = FlatStyle.Flat;
            btnAddImage.ForeColor = Color.White;
            btnAddImage.Location = new Point(330, 79);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(155, 101);
            btnAddImage.TabIndex = 11;
            btnAddImage.TabStop = false;
            btnAddImage.Text = "Change Image";
            btnAddImage.UseVisualStyleBackColor = false;
            btnAddImage.Click += btnAddImage_Click;
            btnAddImage.MouseLeave += btnAddImage_MouseLeave;
            btnAddImage.MouseHover += btnAddImage_MouseHover;
            // 
            // studentStatus
            // 
            studentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            studentStatus.FormattingEnabled = true;
            studentStatus.Items.AddRange(new object[] { StudentStatus.Studying, StudentStatus.Graduated, StudentStatus.Break });
            studentStatus.Location = new Point(580, 294);
            studentStatus.Name = "studentStatus";
            studentStatus.Size = new Size(100, 28);
            studentStatus.TabIndex = 17;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(524, 294);
            label19.Name = "label19";
            label19.Size = new Size(50, 20);
            label19.TabIndex = 30;
            label19.Text = "Status";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(98, 247);
            label18.Name = "label18";
            label18.Size = new Size(55, 20);
            label18.TabIndex = 25;
            label18.Text = "School";
            // 
            // studentSchool
            // 
            studentSchool.Location = new Point(153, 244);
            studentSchool.Name = "studentSchool";
            studentSchool.Size = new Size(100, 27);
            studentSchool.TabIndex = 12;
            // 
            // studentPictureBox
            // 
            studentPictureBox.BorderStyle = BorderStyle.FixedSingle;
            studentPictureBox.Location = new Point(314, 42);
            studentPictureBox.Name = "studentPictureBox";
            studentPictureBox.Size = new Size(186, 176);
            studentPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            studentPictureBox.TabIndex = 24;
            studentPictureBox.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(525, 241);
            label7.Name = "label7";
            label7.Size = new Size(32, 20);
            label7.TabIndex = 22;
            label7.Text = "No.";
            // 
            // studentNo
            // 
            studentNo.Location = new Point(580, 238);
            studentNo.Name = "studentNo";
            studentNo.Size = new Size(100, 27);
            studentNo.TabIndex = 14;
            studentNo.KeyPress += studentNo_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(306, 297);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 20;
            label6.Text = "Class";
            // 
            // studentClass
            // 
            studentClass.Location = new Point(361, 294);
            studentClass.Name = "studentClass";
            studentClass.Size = new Size(100, 27);
            studentClass.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(306, 244);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 18;
            label5.Text = "Grade";
            // 
            // studentGrade
            // 
            studentGrade.Location = new Point(361, 241);
            studentGrade.Name = "studentGrade";
            studentGrade.Size = new Size(100, 27);
            studentGrade.TabIndex = 13;
            studentGrade.KeyPress += studentGrade_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 297);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 17;
            label4.Text = "Name";
            // 
            // studentName
            // 
            studentName.Location = new Point(153, 294);
            studentName.Name = "studentName";
            studentName.Size = new Size(100, 27);
            studentName.TabIndex = 15;
            // 
            // StudentManagementApp
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 970);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "StudentManagementApp";
            Text = "Student Management App";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListView studentScoreList;
        private ComboBox searchNoBox;
        private ComboBox searchGradeBox;
        private ComboBox searchClassBox;
        private ComboBox searchNameBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSaveFile;
        private Button btnLoadFile;
        private Button btnShowAll;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnModify;
        private Button btnAdd;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private Label label4;
        private TextBox studentName;
        private Label label16;
        private TextBox rank;
        private Label label17;
        private TextBox totalScore;
        private Label label15;
        private TextBox scienceScore;
        private Label label14;
        private TextBox socialScore;
        private Label label13;
        private TextBox mathScore;
        private Label label12;
        private TextBox engScore;
        private Label label11;
        private TextBox koreanScore;
        private ComboBox examType;
        private Label label10;
        private Label label9;
        private TextBox examSemester;
        private Label label8;
        private TextBox examYear;
        private Label label7;
        private TextBox studentNo;
        private Label label6;
        private TextBox studentClass;
        private Label label5;
        private TextBox studentGrade;
        private ColumnHeader list_year;
        private ColumnHeader list_semester;
        private ColumnHeader list_exam_type;
        private ColumnHeader list_grade;
        private ColumnHeader list_class;
        private ColumnHeader list_student_no;
        private ColumnHeader list_name;
        private ColumnHeader list_rank;
        private ColumnHeader list_total_score;
        private ColumnHeader list_kor_score;
        private ColumnHeader list_eng_score;
        private ColumnHeader list_math_score;
        private ColumnHeader list_social_score;
        private ColumnHeader list_science_score;
        private Label label18;
        private TextBox studentSchool;
        private PictureBox studentPictureBox;
        private ComboBox studentStatus;
        private Label label19;
        private Button btnAddImage;
        private ColumnHeader list_school;
        private ColumnHeader list_status;
        private ComboBox searchStatusBox;
        private Label label21;
        private ComboBox searchSchoolBox;
        private Label label20;
        private Button btnSearchStudentAll;
    }
}
