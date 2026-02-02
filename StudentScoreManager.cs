using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp
{
    public class StudentScoreManager
    {
        // 학생 성적 목록
        private static Dictionary<StudentExamKey, StudentScore> studentScores = new Dictionary<StudentExamKey, StudentScore>();

        // 학생 성적 정보 검색
        public static List<StudentScore> SearchStudentScores(
            StudentKey? studentKey = null,
            Exam? exam = null,
            StudentStatus? status = null,
            string searchSchool = "",
            string searchName = "",
            string searchGrade = "",
            string searchClass = "",
            string searchNo = ""
        )
        {
            bool hasSearchText =
                status != null ||
                !string.IsNullOrWhiteSpace(searchSchool) ||
                !string.IsNullOrWhiteSpace(searchName) ||
                !string.IsNullOrWhiteSpace(searchGrade) ||
                !string.IsNullOrWhiteSpace(searchClass) ||
                !string.IsNullOrWhiteSpace(searchNo);

            if (hasSearchText)
            {
                return studentScores
                    .Where(kv =>
                        (status == null || kv.Value.Student.Status == status) &&

                        (string.IsNullOrWhiteSpace(searchSchool) ||
                         kv.Key.StudentKey.School.Contains(searchSchool, StringComparison.OrdinalIgnoreCase)) &&

                        (string.IsNullOrWhiteSpace(searchName) ||
                         kv.Value.Student.Name.Contains(searchName, StringComparison.OrdinalIgnoreCase)) &&

                        (string.IsNullOrWhiteSpace(searchGrade) ||
                         kv.Key.StudentKey.Grade.ToString() == searchGrade) &&

                        (string.IsNullOrWhiteSpace(searchClass) ||
                         kv.Key.StudentKey.Class.ToString() == searchClass) &&

                        (string.IsNullOrWhiteSpace(searchNo) ||
                         kv.Key.StudentKey.No.ToString() == searchNo)
                    )
                    .Select(kv => kv.Value)
                    .ToList();
            }

            return studentScores
                .Where(kv =>
                    (studentKey == null || kv.Key.StudentKey.Equals(studentKey)) &&
                    (exam == null || kv.Key.Exam.Equals(exam))
                )
                .Select(kv => kv.Value)
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
        public static void CalculateRank(Exam? exam = null)
        {
            // 해당 시험 성적만 가져오기
            var list = studentScores
                .Where(kv => exam == null || kv.Key.Exam.Equals(exam))
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

        public static void Clear()
        {
            studentScores.Clear();
        }

    }
}
