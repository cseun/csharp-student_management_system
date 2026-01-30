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
            studentScoreList = new ListView();
            list_grade = new ColumnHeader();
            list_class = new ColumnHeader();
            list_student_no = new ColumnHeader();
            list_name = new ColumnHeader();
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
            btnAdd = new Button();
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
            groupBox4 = new GroupBox();
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
            SuspendLayout();
            // 
            // groupBox1
            // 
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
            groupBox1.Location = new Point(12, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(871, 780);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student List";
            // 
            // studentScoreList
            // 
            studentScoreList.Columns.AddRange(new ColumnHeader[] { list_grade, list_class, list_student_no, list_name, list_year, list_semester, list_exam_type, list_kor_score, list_eng_score, list_math_score, list_social_score, list_science_score, list_total_score, list_rank });
            studentScoreList.Location = new Point(26, 87);
            studentScoreList.Name = "studentScoreList";
            studentScoreList.Size = new Size(822, 602);
            studentScoreList.TabIndex = 16;
            studentScoreList.UseCompatibleStateImageBehavior = false;
            studentScoreList.View = View.Details;
            studentScoreList.SelectedIndexChanged += studentScoreList_SelectedIndexChanged;
            // 
            // list_grade
            // 
            list_grade.Text = "Grade";
            // 
            // list_class
            // 
            list_class.Text = "Class";
            // 
            // list_student_no
            // 
            list_student_no.Text = "No.";
            list_student_no.Width = 40;
            // 
            // list_name
            // 
            list_name.Text = "Name";
            // 
            // list_year
            // 
            list_year.Text = "Year";
            list_year.Width = 50;
            // 
            // list_semester
            // 
            list_semester.Text = "Semester";
            list_semester.Width = 80;
            // 
            // list_exam_type
            // 
            list_exam_type.Text = "Exam Type";
            list_exam_type.Width = 90;
            // 
            // list_kor_score
            // 
            list_kor_score.Text = "Korean";
            // 
            // list_eng_score
            // 
            list_eng_score.Text = "English";
            list_eng_score.Width = 70;
            // 
            // list_math_score
            // 
            list_math_score.Text = "Math";
            // 
            // list_social_score
            // 
            list_social_score.Text = "Social";
            list_social_score.Width = 70;
            // 
            // list_science_score
            // 
            list_science_score.Text = "Science";
            list_science_score.Width = 70;
            // 
            // list_total_score
            // 
            list_total_score.Text = "Total Score";
            list_total_score.Width = 90;
            // 
            // list_rank
            // 
            list_rank.Text = "Rank";
            // 
            // searchNoBox
            // 
            searchNoBox.FormattingEnabled = true;
            searchNoBox.Location = new Point(490, 38);
            searchNoBox.Name = "searchNoBox";
            searchNoBox.Size = new Size(57, 28);
            searchNoBox.TabIndex = 15;
            // 
            // searchGradeBox
            // 
            searchGradeBox.FormattingEnabled = true;
            searchGradeBox.Location = new Point(275, 40);
            searchGradeBox.Name = "searchGradeBox";
            searchGradeBox.Size = new Size(83, 28);
            searchGradeBox.TabIndex = 14;
            // 
            // searchClassBox
            // 
            searchClassBox.FormattingEnabled = true;
            searchClassBox.Location = new Point(364, 40);
            searchClassBox.Name = "searchClassBox";
            searchClassBox.Size = new Size(78, 28);
            searchClassBox.TabIndex = 14;
            // 
            // searchNameBox
            // 
            searchNameBox.FormattingEnabled = true;
            searchNameBox.Location = new Point(80, 40);
            searchNameBox.Name = "searchNameBox";
            searchNameBox.Size = new Size(92, 28);
            searchNameBox.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(452, 42);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 12;
            label3.Text = "No.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 44);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 11;
            label2.Text = "Grade/Class";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 44);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 10;
            label1.Text = "Name";
            // 
            // btnSaveFile
            // 
            btnSaveFile.Location = new Point(435, 718);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(112, 29);
            btnSaveFile.TabIndex = 9;
            btnSaveFile.Text = "Save File(.csv)";
            btnSaveFile.UseVisualStyleBackColor = true;
            // 
            // btnLoadFile
            // 
            btnLoadFile.Location = new Point(295, 718);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(116, 29);
            btnLoadFile.TabIndex = 8;
            btnLoadFile.Text = "Load File(.csv)";
            btnLoadFile.UseVisualStyleBackColor = true;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(768, 37);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(80, 30);
            btnShowAll.TabIndex = 7;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(682, 37);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 30);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnModify);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(groupBox6);
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Location = new Point(900, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(688, 780);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Properties";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(434, 660);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(324, 660);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(94, 29);
            btnModify.TabIndex = 4;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(209, 660);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
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
            groupBox6.Location = new Point(18, 256);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(656, 367);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Score Info";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(435, 304);
            label16.Name = "label16";
            label16.Size = new Size(43, 20);
            label16.TabIndex = 41;
            label16.Text = "Rank";
            // 
            // rank
            // 
            rank.Location = new Point(536, 301);
            rank.Name = "rank";
            rank.ReadOnly = true;
            rank.Size = new Size(96, 27);
            rank.TabIndex = 42;
            rank.Text = "-";
            rank.TextAlign = HorizontalAlignment.Right;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(435, 240);
            label17.Name = "label17";
            label17.Size = new Size(85, 20);
            label17.TabIndex = 39;
            label17.Text = "Total Score";
            // 
            // totalScore
            // 
            totalScore.Location = new Point(536, 237);
            totalScore.Name = "totalScore";
            totalScore.ReadOnly = true;
            totalScore.Size = new Size(96, 27);
            totalScore.TabIndex = 40;
            totalScore.Text = "0";
            totalScore.TextAlign = HorizontalAlignment.Right;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(44, 304);
            label15.Name = "label15";
            label15.Size = new Size(60, 20);
            label15.TabIndex = 37;
            label15.Text = "Science";
            // 
            // scienceScore
            // 
            scienceScore.Location = new Point(117, 301);
            scienceScore.Name = "scienceScore";
            scienceScore.Size = new Size(96, 27);
            scienceScore.TabIndex = 38;
            scienceScore.Text = "0";
            scienceScore.TextAlign = HorizontalAlignment.Right;
            scienceScore.KeyPress += scienceScore_KeyPress;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(44, 240);
            label14.Name = "label14";
            label14.Size = new Size(49, 20);
            label14.TabIndex = 35;
            label14.Text = "Social";
            // 
            // socialScore
            // 
            socialScore.Location = new Point(117, 237);
            socialScore.Name = "socialScore";
            socialScore.Size = new Size(96, 27);
            socialScore.TabIndex = 36;
            socialScore.Text = "0";
            socialScore.TextAlign = HorizontalAlignment.Right;
            socialScore.KeyPress += socialScore_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(44, 176);
            label13.Name = "label13";
            label13.Size = new Size(45, 20);
            label13.TabIndex = 33;
            label13.Text = "Math";
            // 
            // mathScore
            // 
            mathScore.Location = new Point(117, 173);
            mathScore.Name = "mathScore";
            mathScore.Size = new Size(96, 27);
            mathScore.TabIndex = 34;
            mathScore.Text = "0";
            mathScore.TextAlign = HorizontalAlignment.Right;
            mathScore.KeyPress += mathScore_KeyPress;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(44, 112);
            label12.Name = "label12";
            label12.Size = new Size(58, 20);
            label12.TabIndex = 31;
            label12.Text = "English";
            // 
            // engScore
            // 
            engScore.Location = new Point(117, 109);
            engScore.Name = "engScore";
            engScore.Size = new Size(96, 27);
            engScore.TabIndex = 32;
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
            koreanScore.Size = new Size(96, 27);
            koreanScore.TabIndex = 30;
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
            groupBox5.Location = new Point(18, 150);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(656, 100);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Exam Info";
            // 
            // examType
            // 
            examType.DataSource = new ExamType[]
            {
                ExamType.Midterm,
                ExamType.Final,
                ExamType.MidFinal
            };
            examType.DropDownStyle = ComboBoxStyle.DropDownList;
            examType.FormattingEnabled = true;
            //examType.Items.AddRange(new object[] { ExamType.Midterm, ExamType.Final, ExamType.MidFinal });
            examType.Location = new Point(506, 43);
            examType.Name = "examType";
            examType.Size = new Size(102, 28);
            examType.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(416, 47);
            label10.Name = "label10";
            label10.Size = new Size(82, 20);
            label10.TabIndex = 28;
            label10.Text = "Exam Type";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(217, 48);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 26;
            label9.Text = "Semester";
            // 
            // examSemester
            // 
            examSemester.Location = new Point(295, 45);
            examSemester.Name = "examSemester";
            examSemester.Size = new Size(96, 27);
            examSemester.TabIndex = 27;
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
            examYear.Size = new Size(96, 27);
            examYear.TabIndex = 25;
            examYear.KeyPress += examYear_KeyPress;
            // 
            // groupBox4
            // 
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
            groupBox4.Size = new Size(656, 100);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Student Info";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(490, 48);
            label7.Name = "label7";
            label7.Size = new Size(32, 20);
            label7.TabIndex = 22;
            label7.Text = "No.";
            // 
            // studentNo
            // 
            studentNo.Location = new Point(545, 45);
            studentNo.Name = "studentNo";
            studentNo.Size = new Size(50, 27);
            studentNo.TabIndex = 23;
            studentNo.KeyPress += studentNo_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(364, 48);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 20;
            label6.Text = "Class";
            // 
            // studentClass
            // 
            studentClass.Location = new Point(419, 45);
            studentClass.Name = "studentClass";
            studentClass.Size = new Size(50, 27);
            studentClass.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(240, 48);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 18;
            label5.Text = "Grade";
            // 
            // studentGrade
            // 
            studentGrade.Location = new Point(295, 45);
            studentGrade.Name = "studentGrade";
            studentGrade.Size = new Size(50, 27);
            studentGrade.TabIndex = 19;
            studentGrade.KeyPress += studentGrade_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 48);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 17;
            label4.Text = "Name";
            // 
            // studentName
            // 
            studentName.Location = new Point(99, 45);
            studentName.Name = "studentName";
            studentName.Size = new Size(125, 27);
            studentName.TabIndex = 17;
            // 
            // StudentManagementApp
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 800);
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
    }
}
